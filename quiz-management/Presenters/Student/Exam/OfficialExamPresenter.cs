﻿using quiz_management.Models;
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
        public List<Question> Questions = new List<Question>();
        public int QuestionSelectedndex;

        public OfficialExamPresenter(IOfficialExamView v, int userCode)
        {
            view = v;
            currentUserCode = userCode;
            GetData();
            view.QuestionChange += View_QuestionChange;
        }

        private void View_QuestionChange(object sender, System.EventArgs e)
        {
            QuestionSelectedndex = (sender as CheckedListBox).SelectedIndex;
            view.QuestionOrder = QuestionSelectedndex + 1;
            view.QuestionString = Questions.ElementAt(QuestionSelectedndex).CauHoi;
            view.Answers = Questions.ElementAt(QuestionSelectedndex).CauTraLoi;
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

                //view.QuestionsDataSource = Questions;
                SetExamDataView(exam, Questions.Count);
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
    }
}