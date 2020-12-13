using quiz_management.Models;
using quiz_management.Views.Student.Exam;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace quiz_management.Presenters.Student.Exam
{
    internal class OfficialExamPresenter
    {
        private IOfficialExamView view;
        private int currentUserCode;

        public OfficialExamPresenter(IOfficialExamView v, int userCode)
        {
            view = v;
            currentUserCode = userCode;

            GetData();
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
                var exam = db.boDes.SingleOrDefault(d => d.maBoDe == 1);
                var questions = db.cTBoDes.Where(b => b.maBoDe == 1).Join(
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
                                        CauTraLoi = new Answer
                                        {
                                            MaCauTraLoi = s.DapAn.MaCauTraLoi,
                                            CauTraLoi = s.DapAn.CauTraLoi,
                                        }
                                    }
                                )
                            ).ToList();

                List<Question> Questions = new List<Question>();
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
                            CauTraLoi = questions[i].ElementAt(j).CauTraLoi.CauTraLoi
                        });
                    }
                    Q.CauTraLoi = A;
                    Questions.Add(Q);
                }

                view.QuestionCount = Questions.Count;
                //view.QuestionsDataSource = Questions;
                SetExamDataView(exam);
            };
        }

        private void SetUserDataView(string name, string className)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(className)) return;
            view.StudentName = name;
            view.StudentClass = className;
        }

        private void SetExamDataView(boDe exam)
        {
            if (exam == null) return;
            view.ExamTime = (int)exam.thoiGian;
            view.ExamCode = exam.maBoDe.ToString();
        }
    }
}