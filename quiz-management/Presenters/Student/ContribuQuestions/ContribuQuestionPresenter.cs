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
            view.WatchContributeQuestions += View_WatchContributeQuestions;
        }

        private void View_WatchContributeQuestions(object sender, EventArgs e)
        {
            view.ShowWatchContributeQuestions(currentUserCode);
        }

        private void View_GoBackMain(object sender, EventArgs e)
        {
            view.ShowMainStudentView(currentUserCode);
        }

        private void Send_CLick(object sender, EventArgs e)
        {
            int countQuestion = 0;
            bool checkQuestionMustAnwser = true;

            string Questionsstring = view.Question;
            string answerA = view.AnswerA;
            string answerB = view.AnswerB;
            string answerC = view.AnswerC;
            string answerD = view.AnswerD;
            string answerE = view.AnswerE;
            string answerF = view.AnswerF;

            //đếm số câu hỏi đã tạo
            countQuestion = answerA == "" ? countQuestion + 0 : countQuestion + 1;
            countQuestion = answerB == "" ? countQuestion + 0 : countQuestion + 1;
            countQuestion = answerC == "" ? countQuestion + 0 : countQuestion + 1;
            countQuestion = answerD == "" ? countQuestion + 0 : countQuestion + 1;
            countQuestion = answerE == "" ? countQuestion + 0 : countQuestion + 1;
            countQuestion = answerF == "" ? countQuestion + 0 : countQuestion + 1;

            int checkA = view.cbResultA ? 1 : 0;
            int checkB = view.cbResultB ? 1 : 0;
            int checkC = view.cbResultC ? 1 : 0;
            int checkD = view.cbResultD ? 1 : 0;
            int checkE = view.cbResultE ? 1 : 0;
            int checkF = view.cbResultF ? 1 : 0;

            //kiem tra cau tra loi phai co cau hoi
            checkQuestionMustAnwser = answerA == "" && checkA == 1 ? false : true;
            checkQuestionMustAnwser = answerB == "" && checkB == 1 ? false : true;
            checkQuestionMustAnwser = answerC == "" && checkC == 1 ? false : true;
            checkQuestionMustAnwser = answerD == "" && checkD == 1 ? false : true;
            checkQuestionMustAnwser = answerE == "" && checkE == 1 ? false : true;
            checkQuestionMustAnwser = answerF == "" && checkF == 1 ? false : true;

            string classIDSelected = view.ClassSelect;
            string subjectIDSelected = view.SubjectSelect;
            if (checkA == 0 && checkB == 0 && checkC == 0 && checkD == 0 && checkE == 0 && checkF == 0)
            {
                view.ShowMessage("Phải có ít nhất 1 câu trả lời là đúng!!");
            }
            else if (countQuestion < 4)
            {
                view.ShowMessage("Phải có ít nhất 4 câu hỏi");
            }
            else if (!checkQuestionMustAnwser)
            {
                view.ShowMessage("Câu trả lời phải có câu hỏi");
            }
            else
            {
                using (var db = new QuizDataContext())
                {
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
                    var idContribution_next = db.dongGops.Max(i => i.maDongGop);
                    if (answerA != "")
                    {
                        db.cTDongGops.InsertOnSubmit(new cTDongGop
                        {
                            maDongGop = idContribution_next,
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
                                maDongGop = idContribution_next,
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
                                maDongGop = idContribution_next,
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
                                maDongGop = idContribution_next,
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
                                maDongGop = idContribution_next,
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
                                maDongGop = idContribution_next,
                                cauTraLoi = answerF,
                                dapAn = checkF
                            });
                        db.SubmitChanges();
                    }

                    view.ShowMessage("Đóng góp câu hỏi thành công");

                }
            }
        }

        public void LoadSubject()
        {
        }

        public void LoadClass(int code)
        {
            using (var db = new QuizDataContext())
            {
                view.StudentID = db.thongTins.Where(i => i.maNguoidung == currentUserCode).Select(i => i.tenNguoiDung).ToList()[0].ToString();
                var classlist = db.khoiLops.ToList();
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
