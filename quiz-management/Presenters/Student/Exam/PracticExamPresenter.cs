using quiz_management.Models;
using quiz_management.Views.Student.Exam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Student.Exam
{
    internal class PracticExamPresenter
    {
        private IPracticExamView view;
        private int currentUserCode;
        private int _maBoDe = 1;
        private int _selectedCourses;

        public BindingList<Question> Questions = new BindingList<Question>();
        public int QuestionSelectedIndex = 0;

        public PracticExamPresenter(IPracticExamView v, int userCode)
        {
            view = v;
            currentUserCode = userCode;
            SetUserDataView();
            BindingCourses();
            view.QuestionChange += View_QuestionChange;
            view.AnswerCheck += View_AnswerCheck;
            view.Prev += View_Prev;
            view.Next += View_Next;
            view.Submit += View_Submit;
            view.Timeout += View_Timeout;
            view.CoursesChange += View_CoursesChange;
            view.ExamCodeChange += View_ExamCodeChange;
            view.ViewCurrentAnswers += View_ViewCurrentAnswers;
            view.ViewAllAnswers += View_ViewAllAnswers;
            view.StatisticClicked += View_StatisticClicked;
        }

        private void View_StatisticClicked(object sender, EventArgs e)
        {
            view.ShowStatisticView(currentUserCode);
        }

        private void View_ViewAllAnswers(object sender, EventArgs e)
        {
            ShowCorrectAnswers(sender);
        }

        private void View_ViewCurrentAnswers(object sender, EventArgs e)
        {
            ShowCorrectAnswers(sender);
        }

        private void ShowCorrectAnswers(object sender)
        {
            var cb = (sender as CheckBox);

            if (!cb.Checked)
            {
                view.CorrectAnswers = null;
                return;
            }

            using (var db = new QuizDataContext())
            {
                int questionCode = Questions.ElementAt(QuestionSelectedIndex).MaCauHoi;
                var correctAnswers = db.dapAns.Where(c => (c.maCauHoi == questionCode) && (c.dapAn1 == 1))
                                                .Select(s => s.maCauTraloi);
                List<int> indexes = new List<int>();
                foreach (int ansCode in correctAnswers)
                {
                    int index = Questions[QuestionSelectedIndex].CauTraLoi.FindIndex(a => a.MaCauTraLoi == ansCode);
                    indexes.Add(index + 1);
                }
                view.CorrectAnswers = indexes;
            }
        }

        private void View_ExamCodeChange(object sender, EventArgs e)
        {
            var examCode = (sender as ComboBox).SelectedValue;
            if (examCode == null || string.IsNullOrEmpty(examCode.ToString()))
            {
                BindingEmptyExam();
                return;
            }

            _maBoDe = int.Parse(examCode.ToString());
            GetData();
            BindingQuestion();
        }

        private void View_CoursesChange(object sender, EventArgs e)
        {
            var coursesCode = (sender as ComboBox).SelectedValue;
            if (coursesCode == null || string.IsNullOrEmpty(coursesCode.ToString())) return;

            _selectedCourses = int.Parse(coursesCode.ToString());
            using (var db = new QuizDataContext())
            {
                var exam = db.boDes.Where(d => (d.maMon == _selectedCourses) && (d.trangThai == 0))
                                    .Select(s => s.maBoDe).ToList();

                view.ExamCodes = exam;
            };
        }

        private void BindingCourses()
        {
            using (var db = new QuizDataContext())
            {
                var courses = db.kyThiThus.Where(k => (k.ngayThi <= DateTime.Now) &&
                (k.ngayKT >= DateTime.Now) && (k.maNguoiDung == currentUserCode))
                                            .Select(s => s.monHoc).ToList<monHoc>();
                if (courses.Count > 0)
                {
                    _selectedCourses = courses.ElementAt(0).maMonHoc;
                }
                view.Courses = new BindingList<monHoc>(courses);
            };
        }

        private void BindingEmptyExam()
        {
            Questions.Clear();
            view.Answers = null;
            view.Completed = 0;
            view.Remain = 0;
            view.QuestionString = null;
            view.QuestionQuantity = 0;
            view.QuestionOrder = 0;
        }

        private void View_Timeout()
        {
            view.ShowMessage("Hết giờ", "Đã hết thời gian làm bài. Hệ thống sẽ tự động nộp bài của bạn");
            int timeLeft = view.TimeLeft;
            bool excute = UpdateResult();
            if (!excute) view.ShowMessage("Lỗi", "Đã có lỗi xảy ra");
            else
            {
                using (var db = new QuizDataContext())
                {
                    var user = db.nguoiDungs.SingleOrDefault(n => n.maNguoiDung == currentUserCode);
                    if (user.phanQuyen == 1)
                    {
                        view.ShowStudentView(currentUserCode);
                    }
                    else
                    {
                        view.ShowTeacherView(currentUserCode);
                    }
                }
            }
        }

        private void View_Submit(object sender, System.EventArgs e)
        {
            bool confirm = false;
            if (view.Remain > 0)
            {
                confirm = view.ShowMessage("Nộp bài", "Còn " + view.Remain + " câu chưa hoàn thành.Bạn có chắc không ?");
            }
            else
            {
                confirm = view.ShowMessage("Nộp bài", "Bạn có chắc không ?");
            }

            if (confirm == false) return;
            bool excute = UpdateResult();
            if (!excute) view.ShowMessage("Lỗi", "Đã có lỗi xảy ra");
            else
            {
                using (var db = new QuizDataContext())
                {
                    var user = db.nguoiDungs.SingleOrDefault(n => n.maNguoiDung == currentUserCode);
                    if (user.phanQuyen == 1)
                    {
                        view.ShowStudentView(currentUserCode);
                    }
                    else
                    {
                        view.ShowTeacherView(currentUserCode);
                    }
                }
            }
        }

        private void View_Next(object sender, System.EventArgs e)
        {
            if (QuestionSelectedIndex >= Questions.Count - 1) return;
            QuestionSelectedIndex++;
            BindingQuestion();
        }

        private void View_Prev(object sender, System.EventArgs e)
        {
            if (QuestionSelectedIndex <= 0) return;
            QuestionSelectedIndex--;
            BindingQuestion();
        }

        private void View_AnswerCheck(object sender, System.EventArgs e)
        {
            if ((e as ItemCheckEventArgs).CurrentValue == (e as ItemCheckEventArgs).NewValue) return;
            view.QuestionSelected = QuestionSelectedIndex;
            List<Answer> ans = Questions.ElementAt(QuestionSelectedIndex).CauTraLoi;
            int index = (e as ItemCheckEventArgs).Index;
            bool state = (e as ItemCheckEventArgs).NewValue == CheckState.Checked;
            if (ans.ElementAt(index).Checked == state) return;
            Questions.ElementAt(QuestionSelectedIndex).Checked = state;
            view.Remain = Questions.Count - view.Completed;
            ans.ElementAt(index).Checked = state;

            foreach (Answer item in ans)
            {
                if (item.Checked)
                {
                    Questions.ElementAt(QuestionSelectedIndex).Checked = item.Checked;
                    view.QuestionChecked = item.Checked;
                    UpdateCompleted_RemainCount();
                    return;
                }
            }

            Questions.ElementAt(QuestionSelectedIndex).Checked = state;
            view.QuestionChecked = state;
            UpdateCompleted_RemainCount();
        }

        private void UpdateCompleted_RemainCount()
        {
            int CompletedCount = 0;
            foreach (Question q in Questions)
            {
                if (q.Checked == true) CompletedCount++;
            }
            view.Completed = CompletedCount;
            view.Remain = Questions.Count - CompletedCount;
        }

        private void View_QuestionChange(object sender, System.EventArgs e)
        {
            QuestionSelectedIndex = (sender as CheckedListBox).SelectedIndex;
            if (QuestionSelectedIndex < 0) return;
            BindingQuestion();
        }

        private void GetData()
        {
            using (var db = new QuizDataContext())
            {
                _maBoDe = db.kyThiThus.Where(l => (l.ngayThi <= DateTime.Now) && (DateTime.Now <= l.ngayKT) && (l.maNguoiDung == currentUserCode))
                                    .Select(s => s.maBoDe).First();
                // Fetch exam data
                var exam = db.boDes.FirstOrDefault(d => d.maBoDe == _maBoDe);
                var questions = db.cTBoDes.Where(b => b.maBoDe == _maBoDe).Join(
                                db.cauHois,
                                b => b.maCauHoi,
                                c => c.maCauHoi,
                                (b, c) => new
                                {
                                    MaCauHoi = c.maCauHoi,
                                    CauHoi = c.cauHoi1
                                }
                            ).Join(
                                db.dapAns,
                                c => c.MaCauHoi,
                                d => d.maCauHoi,
                                (c, d) => new
                                {
                                    CauHoi = new
                                    {
                                        MaCauHoi = c.MaCauHoi,
                                        CauHoi = c.CauHoi
                                    },
                                    DapAn = new
                                    {
                                        MaCauTraLoi = d.maCauTraloi,
                                        CauTraLoi = d.cauTraLoi,
                                    }
                                }
                            ).GroupBy(g => g.CauHoi).Select(group => group.Select(
                                    s => new
                                    {
                                        MaCauHoi = s.CauHoi.MaCauHoi,
                                        CauHoi = s.CauHoi.CauHoi,
                                        Checked = false,
                                        CauTraLoi = new Answer
                                        {
                                            MaCauTraLoi = s.DapAn.MaCauTraLoi,
                                            CauTraLoi = s.DapAn.CauTraLoi,
                                            Checked = false,
                                        }
                                    }
                                )
                            ).ToList();

                Questions.Clear();
                for (int i = 0; i < questions.Count; i++)
                {
                    Question Q = new Question();
                    Q.CauHoi = questions[i].ElementAt(0).CauHoi;
                    Q.MaCauHoi = questions[i].ElementAt(0).MaCauHoi;

                    List<Answer> A = new List<Answer>();
                    int answerCount = questions[i].ToList().Count;
                    for (int j = 0; j < answerCount; j++)
                    {
                        A.Add(new Answer
                        {
                            MaCauTraLoi = questions[i].ElementAt(j).CauTraLoi.MaCauTraLoi,
                            CauTraLoi = (j + 1) + ". " + questions[i].ElementAt(j).CauTraLoi.CauTraLoi,
                            Checked = questions[i].ElementAt(j).CauTraLoi.Checked
                        });
                    }
                    Q.CauTraLoi = A;
                    Questions.Add(Q);
                }

                SetExamDataView(exam, Questions.Count);
            };
        }

        private void SetUserDataView()
        {
            using (var db = new QuizDataContext())
            {
                // Fetch user data
                var user = db.nguoiDungs.SingleOrDefault(u => u.maNguoiDung == currentUserCode);
                string name = user.thongTin.tenNguoiDung as string;
                string className = db.Lops.SingleOrDefault(l => l.maLopHoc == user.thongTin.maLopHoc).tenLopHoc as string;
                // Set user data
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(className)) return;
                view.StudentName = name;
                view.StudentClass = className;
            }
        }

        private void SetExamDataView(boDe exam, int quantity)
        {
            if (exam == null) return;
            view.ExamTime = (int)exam.thoiGian;
            view.QuestionQuantity = quantity;
        }

        private void BindingQuestion()
        {
            view.QuestionSelected = QuestionSelectedIndex;
            view.QuestionOrder = QuestionSelectedIndex + 1;
            view.QuestionString = Questions.ElementAt(QuestionSelectedIndex).CauHoi;
            view.Answers = new BindingList<Answer>(Questions.ElementAt(QuestionSelectedIndex).CauTraLoi);
        }

        private bool UpdateResult()
        {
            try
            {
                using (var db = new QuizDataContext())
                {
                    int corrected = 0;
                    int wrong = 0;
                    foreach (Question q in Questions)
                    {
                        if (q.Checked)
                        {
                            var correctAnswers = db.dapAns.Where(d => d.maCauHoi == q.MaCauHoi);
                            bool check = true;
                            foreach (Answer ans in q.CauTraLoi)
                            {
                                var a = correctAnswers.FirstOrDefault(d => d.maCauTraloi == ans.MaCauTraLoi);
                                bool isCorrectAnswer = a.dapAn1 == 1;
                                if (ans.Checked != isCorrectAnswer)
                                {
                                    check = false;
                                    break;
                                }
                            }
                            if (check) corrected++;
                        }
                    }

                    wrong = Questions.Count - corrected;
                    var diem = (10 * 1.0 / Questions.Count) * corrected;

                    var result = db.luyenTaps.FirstOrDefault(t => t.nguoiDung.maNguoiDung == currentUserCode);
                    if (result == null)
                    {
                        var user = db.nguoiDungs.FirstOrDefault(n => n.maNguoiDung == currentUserCode);
                        var lt = new luyenTap
                        {
                            nguoiDung = user,
                            ngay = DateTime.Now,
                            soCauDung = corrected,
                            soCauSai = wrong
                        };

                        db.luyenTaps.InsertOnSubmit(lt);
                    }
                    else
                    {
                        result.soCauDung += corrected;
                        result.soCauSai += wrong;
                    }

                    db.SubmitChanges();
                    view.ShowMessage("Kết quả", "Bạn được " + diem + " điểm");
                };
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}