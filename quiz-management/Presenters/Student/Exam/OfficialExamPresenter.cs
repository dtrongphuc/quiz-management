using quiz_management.Models;
using quiz_management.Views.Student.Exam;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace quiz_management.Presenters.Student.Exam
{
    internal class OfficialExamPresenter
    {
        private IOfficialExamView view;
        private int currentUserCode;
        private int _maBoDe = 1;
        private int _resultCode = -1;

        public List<Question> Questions = new List<Question>();
        public int QuestionSelectedIndex;

        public OfficialExamPresenter(IOfficialExamView v, int userCode)
        {
            view = v;
            currentUserCode = userCode;
            GetData();
            view.QuestionChange += View_QuestionChange;
            view.AnswerCheck += View_AnswerCheck;
            view.Prev += View_Prev;
            view.Next += View_Next;
            view.Submit += View_Submit;
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
            view.QuestionSelected = QuestionSelectedIndex;
            int index = (e as ItemCheckEventArgs).Index;
            bool state = (e as ItemCheckEventArgs).NewValue == CheckState.Checked;
            Questions.ElementAt(QuestionSelectedIndex).Checked = state;
            view.Remain = Questions.Count - view.Completed;
            List<Answer> ans = Questions.ElementAt(QuestionSelectedIndex).CauTraLoi;
            ans.ElementAt(index).Checked = state;
            StoreCheckAnswer(Questions.ElementAt(QuestionSelectedIndex).MaCauHoi,
                ans.ElementAt(index).MaCauTraLoi, view.TimeLeft);
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
                // Fetch user data
                var user = db.nguoiDungs.SingleOrDefault(u => u.maNguoiDung == currentUserCode);
                string name = user.thongTin.tenNguoiDung as string;
                string className = db.Lops.SingleOrDefault(l => l.maLopHoc == user.thongTin.maLopHoc).tenLopHoc as string;
                // Set user data
                SetUserDataView(name, className);

                // Fetch exam data
                var exam = db.boDes.SingleOrDefault(d => d.maBoDe == _maBoDe);
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
                            CauTraLoi = questions[i].ElementAt(j).CauTraLoi.CauTraLoi,
                            Checked = questions[i].ElementAt(j).CauTraLoi.Checked
                        });
                    }
                    Q.CauTraLoi = A;
                    Questions.Add(Q);
                }

                SetExamDataView(exam, Questions.Count);
                BindingQuestion();
            };
        }

        private void SetUserDataView(string name, string className)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(className)) return;
            view.StudentName = name;
            view.StudentClass = className;
        }

        private void SetExamDataView(boDe exam, int quantity)
        {
            if (exam == null) return;
            view.ExamTime = (int)exam.thoiGian;
            view.ExamCode = exam.maBoDe.ToString();
            view.QuestionQuantity = quantity;
        }

        private void BindingQuestion()
        {
            view.QuestionSelected = QuestionSelectedIndex; ;
            view.QuestionOrder = QuestionSelectedIndex + 1;
            view.QuestionString = Questions.ElementAt(QuestionSelectedIndex).CauHoi;
            view.Answers = Questions.ElementAt(QuestionSelectedIndex).CauTraLoi;
        }

        private void GetDataSubmit()
        {
            int timeLeft = view.TimeLeft;
            //Questions = Questions
        }

        private void StoreCheckAnswer(int questionCode, int answerCode, int time)
        {
            using (var db = new QuizDataContext())
            {
                if (_resultCode < 0)
                {
                    var result = db.ketQuas.Where(k => k.maNguoiDung == currentUserCode)
                                        .Where(k => k.maBoDe == _maBoDe)
                                        .Where(k => k.trangThai == 0)
                                        .Select(s => s.maKetQua);
                    if (result == null) _resultCode = result.FirstOrDefault();
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
                            ngayLam = null,
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
    }
}