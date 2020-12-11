using quiz_management.Models;
using quiz_management.Views.Student.ContribuQuestions;
using quiz_management.Views.Student.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.ContribuQuestions
{
    class ContribuQuestionPresenter
    {
        IMainCQuestionView view;
        int currentUserCode;
        public ContribuQuestionPresenter(IMainCQuestionView v, int code)
        {
            view = v;
            currentUserCode = code;
            LoadClass(code);
            view.Send += Send_CLick;
            view.GoBackMain += View_GoBackMain;
        }

        private void View_GoBackMain(object sender, EventArgs e)
        {
            view.ShowMainStudentView(currentUserCode);
        }

        private void Send_CLick(object sender, EventArgs e)
        {
            string Questionsstring = view.Question;
            string answerA = view.AnswerA;
            string answerB = view.AnswerB;
            string answerC = view.AnswerC;
            string answerD = view.AnswerD;
            string answerE = view.AnswerE;
            string answerF = view.AnswerF;

            bool checkA = view.cbResultA;
            bool checkB = view.cbResultB;
            bool checkC = view.cbResultC;
            bool checkD = view.cbResultD;
            bool checkE = view.cbResultE;
            bool checkF = view.cbResultF;
            using (var db = new QuizDataContext())
            {
                var idContribution_next = db.dongGops.ToList();
                db.dongGops.InsertOnSubmit(new dongGop
                {
                    maNguoiDung = 1,
                    maMonHoc = 1,
                    trangthai = 0,
                    ngay = DateTime.Now,
                    cauHoi = Questionsstring
                });
                db.SubmitChanges();

                if (answerA != "")
                {
                    db.cTDongGops.InsertOnSubmit(new cTDongGop
                    {
                        maDongGop = idContribution_next.Count() + 1,
                        cauTraLoi = answerA,

                    });
                    db.SubmitChanges();
                }
                if (answerB != "")
                {
                    db.cTDongGops.InsertOnSubmit(
                        new cTDongGop
                        {
                            maDongGop = idContribution_next.Count() + 1,
                            cauTraLoi = answerB,

                        });
                    db.SubmitChanges();
                }
                if (answerC != "")
                {
                    db.cTDongGops.InsertOnSubmit(
                        new cTDongGop
                        {
                            maDongGop = idContribution_next.Count() + 1,
                            cauTraLoi = answerC,

                        });
                    db.SubmitChanges();
                }
                if (answerD != "")
                {
                    db.cTDongGops.InsertOnSubmit(
                        new cTDongGop
                        {
                            maDongGop = idContribution_next.Count() + 1,
                            cauTraLoi = answerD,

                        });
                    db.SubmitChanges();
                }
                if (answerE != "")
                {
                    db.cTDongGops.InsertOnSubmit(
                        new cTDongGop
                        {
                            maDongGop = idContribution_next.Count() + 1,
                            cauTraLoi = answerE,

                        });
                    db.SubmitChanges();
                } 
                if (answerF != "")
                {
                    db.cTDongGops.InsertOnSubmit(
                        new cTDongGop
                        {
                            maDongGop = idContribution_next.Count() + 1,
                            cauTraLoi = answerF,

                        });
                    db.SubmitChanges();
                }
            }
        }

        public void LoadSubject()
        {
        }

        public void LoadClass(int code)
        {
            view.StudentID = code.ToString();
            using (var db = new QuizDataContext())
            {
                var classlist = db.Lops.ToList();
                var subjects = db.monHocs.ToList();
                if (classlist != null)
                {
                    view.classes = classlist;
                }
                if (subjects != null)
                {
                    view.Subjects = subjects;
                }
            }
        }
    }
}
