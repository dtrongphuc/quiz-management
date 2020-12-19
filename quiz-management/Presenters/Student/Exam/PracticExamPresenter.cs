using quiz_management.Models;
using quiz_management.Views.Student.Exam;
using System;
using System.Collections.Generic;
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
        private int _resultCode = -1;
        private int _selectedCourses;

        public List<Question> Questions = new List<Question>();
        public int QuestionSelectedIndex = 0;

        public PracticExamPresenter(IPracticExamView v, int userCode)
        {
            view = v;
            currentUserCode = userCode;
            SetUserDataView();
            BindingCourses();
            //DataCrashed();
            view.QuestionChange += View_QuestionChange;
            view.AnswerCheck += View_AnswerCheck;
            view.Prev += View_Prev;
            view.Next += View_Next;
            view.Submit += View_Submit;
            view.Timeout += View_Timeout;
            view.CoursesChange += View_CoursesChange;
            view.ExamCodeChange += View_ExamCodeChange;
            view.ViewCurrentAnswers += View_ViewCurrentAnswers;
        }

        private void View_ViewCurrentAnswers(object sender, EventArgs e)
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
                    indexes.Add(index);
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
            BindingCrashedData();
        }

        private void View_CoursesChange(object sender, EventArgs e)
        {
            var coursesCode = (sender as ComboBox).SelectedValue;
            if (coursesCode == null || string.IsNullOrEmpty(coursesCode.ToString())) return;

            _selectedCourses = int.Parse(coursesCode.ToString());
            using (var db = new QuizDataContext())
            {
                var exam = db.boDes.Where(d => d.maMon == _selectedCourses).Select(s => s.maBoDe).ToList();

                view.ExamCodes = exam;
            };
        }

        private void BindingCourses()
        {
            using (var db = new QuizDataContext())
            {
                var courses = db.monHocs.Select(s => s).ToList();
                if (courses.Count > 0)
                {
                    _selectedCourses = courses.ElementAt(0).maMonHoc;
                }
                view.Courses = courses;
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

        private void View_Timeout(object sender, EventArgs e)
        {
            view.ShowMessage("Hết giờ", "Đã hết thời gian làm bài. Hệ thống sẽ tự động nộp bài của bạn");
            int timeLeft = view.TimeLeft;
            bool excute = UpdateResult(timeLeft, view.Remain);
            if (!excute) view.ShowMessage("Lỗi", "Đã có lỗi xảy ra");
            else view.ShowStudentView(currentUserCode);
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
            int timeLeft = view.TimeLeft;
            bool excute = UpdateResult(timeLeft, view.Remain);
            if (!excute) view.ShowMessage("Lỗi", "Đã có lỗi xảy ra");
            else view.ShowStudentView(currentUserCode);
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

            if (!state)
            {
                DeleteAnswerDB(Questions.ElementAt(QuestionSelectedIndex).MaCauHoi,
                ans.ElementAt(index).MaCauTraLoi);
            }
            else
            {
                StoreCheckAnswer(Questions.ElementAt(QuestionSelectedIndex).MaCauHoi,
                ans.ElementAt(index).MaCauTraLoi, view.TimeLeft);
            }

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
                // Fetch exam data
                var exam = db.boDes.Where(d => d.maMon == _selectedCourses).ToList();
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

        private void DataCrashed()
        {
            using (var db = new QuizDataContext())
            {
                var result = db.ketQuas.Where(k => k.maNguoiDung == currentUserCode)
                                    .Where(k => k.maBoDe == _maBoDe)
                                    .Where(k => k.trangThai == 0)
                                    .Select(s => s.maKetQua);
                if (result.Any())
                {
                    _resultCode = result.FirstOrDefault();
                    var detailResult = db.cTKetQuas.Where(k => k.maKetQua == _resultCode).ToList();
                    int time = detailResult.Min(k => k.thoiGian).GetValueOrDefault();
                    if (time > 0) view.ExamTime = time;
                    foreach (var row in detailResult)
                    {
                        int index = Questions.FindIndex(x => x.MaCauHoi == row.maCauHoi);
                        for (int j = 0; j < Questions.ElementAt(index).CauTraLoi.Count; j++)
                        {
                            if (Questions.ElementAt(index).CauTraLoi.ElementAt(j).MaCauTraLoi == row.maCauHoi)
                            {
                                Questions.ElementAt(index).Checked = true;
                                Questions.ElementAt(index).CauTraLoi.ElementAt(j).Checked = true;
                            }
                        }
                    }
                }
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

        private void SetExamDataView(List<boDe> exam, int quantity)
        {
            if (exam == null) return;
            //view.ExamTime = (int)exam.thoiGian;
            view.ExamCodes = exam.Select(s => s.maBoDe).ToList();
            view.QuestionQuantity = quantity;
        }

        private void BindingQuestion()
        {
            view.QuestionSelected = QuestionSelectedIndex;
            view.QuestionOrder = QuestionSelectedIndex + 1;
            view.QuestionString = Questions.ElementAt(QuestionSelectedIndex).CauHoi;
            view.Answers = Questions.ElementAt(QuestionSelectedIndex).CauTraLoi;
        }

        private void BindingCrashedData()
        {
            List<int> CheckedIndexes = Enumerable.Range(0, Questions.Count)
                                                .Where(i => Questions[i].Checked == true)
                                                .ToList();
            view.QuestionsChecked = CheckedIndexes;
            view.Remain = Questions.Count - CheckedIndexes.Count;
            view.Completed = Questions.Count - view.Remain;
        }

        private void StoreCheckAnswer(int questionCode, int answerCode, int time)
        {
            using (var db = new QuizDataContext())
            {
                if (_resultCode <= 0)
                {
                    var result = db.ketQuas.Where(k => k.maNguoiDung == currentUserCode)
                                        .Where(k => k.maBoDe == _maBoDe)
                                        .Where(k => k.trangThai == 0)
                                        .Select(s => s.maKetQua);
                    if (result.Any()) _resultCode = result.FirstOrDefault();
                    else
                    {
                        //Tao ket qua moi neu chua ton tai
                        //Trang thai = 0 -> chua hoan thanh bai thi
                        var newResult = new ketQua
                        {
                            maNguoiDung = currentUserCode,
                            maBoDe = _maBoDe,
                            cauDung = null,
                            cauSai = null,
                            chuaLam = null,
                            ngayLam = DateTime.Today,
                            trangThai = 0,
                            thoiGian = null,
                            diem = null
                        };

                        db.ketQuas.InsertOnSubmit(newResult);
                        db.SubmitChanges();

                        _resultCode = newResult.maKetQua;
                    }
                }

                //Them dap an vao chi tiet ket qua
                db.cTKetQuas.InsertOnSubmit(new cTKetQua
                {
                    maKetQua = _resultCode,
                    maCauHoi = questionCode,
                    maCauTraLoi = answerCode,
                    thoiGian = time
                });
                db.SubmitChanges();
            };
        }

        private void DeleteAnswerDB(int questionCode, int answerCode)
        {
            using (var db = new QuizDataContext())
            {
                var row = db.cTKetQuas.FirstOrDefault(r =>
                (r.maCauHoi == questionCode) && (r.maCauTraLoi == answerCode));
                if (row.maKetQua != _resultCode) return;
                db.cTKetQuas.DeleteOnSubmit(row);
                db.SubmitChanges();
            };
        }

        private bool UpdateResult(int time, int remainCount)
        {
            if (_resultCode <= 0) return false;
            using (var db = new QuizDataContext())
            {
                var result = db.ketQuas.FirstOrDefault(k => k.maKetQua == _resultCode);
                result.chuaLam = remainCount;
                result.thoiGian = time;
                result.trangThai = 1;
                db.SubmitChanges();
            };
            return true;
        }
    }
}