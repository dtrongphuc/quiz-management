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

            int checkA = view.cbResultA ? 1 : 0;
            int checkB = view.cbResultB ? 1 : 0;
            int checkC = view.cbResultC ? 1 : 0;
            int checkD = view.cbResultD ? 1 : 0;
            int checkE = view.cbResultE ? 1 : 0;
            int checkF = view.cbResultF ? 1 : 0;

            string classIDSelected = view.ClassSelect;
            string subjectIDSelected = view.SubjectSelect;

            using (var db = new QuizDataContext())
            {
                var idContribution_next = db.dongGops.ToList();
                db.dongGops.InsertOnSubmit(new dongGop
                {
                    maNguoiDung = currentUserCode,
                    maMonHoc = int.Parse(subjectIDSelected),
                    trangthai = 0,
                    ngay = DateTime.Now,//ToString("yyyy-MM-dd"),
                    cauHoi = Questionsstring,
                    maKhoiLop = classIDSelected
                });
                db.SubmitChanges();

                if (answerA != "")
                {
                    db.cTDongGops.InsertOnSubmit(new cTDongGop
                    {
                        maDongGop = idContribution_next.Count() + 1,
                        cauTraLoi = answerA,
                        dapAn = checkA
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
                            dapAn = checkB
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
                            dapAn = checkC
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
                            dapAn = checkD
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
                            dapAn = checkE
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
                            dapAn = checkF
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
            khoiLop mh1 = new khoiLop();
            khoiLop mh2 = new khoiLop();
            mh1.maKhoiLop = "K10";
            mh1.tenKhoiLop = "10";
            mh2.maKhoiLop = "K11";
            mh2.tenKhoiLop = "11";
            List<khoiLop> list = new List<khoiLop>();
            list.Add(mh1);
            list.Add(mh2);

            view.StudentID = code.ToString();
            using (var db = new QuizDataContext())
            {
                var classlist = db.khoiLops.ToList();
                var subjects = db.monHocs.ToList();
                if (classlist != null)
                {
                    view.classes = list;
                }
                if (subjects != null)
                {
                    view.Subjects = subjects;
                }
            }
        }
    }
}
