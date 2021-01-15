using quiz_management.Models;
using quiz_management.Views.Teacher.QuestionManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.QuestionManagement
{
    class CreateQuestionPresneter
    {
        ICreateQuestionView view;
        int currentUser;
        public CreateQuestionPresneter(ICreateQuestionView v, int code)
        {
            view = v;
            currentUser = code;
            view.ShowListQuestion += ShowListQuestion_View;
            view.Create += Create_View;
            view.GoBackMain += GoBackMain_View;
            LoadPage(code);
        }

        private void LoadPage(int code)
        {
            using (var db = new QuizDataContext())
            {
                //ten gv
                view.TeacherName = db.thongTins.Where(i => i.maNguoidung == currentUser).Select(i => i.tenNguoiDung).ToList()[0].ToString();
                //monhoc
                view.GradeList = db.khoiLops.ToList();
                //monhoc
                view.SubjectList = db.monHocs.ToList();
            }
        }

        private void ShowListQuestion_View(object sender, EventArgs e)
        {
            view.ShowQuestionList(currentUser, "", 0);
        }

        private void Create_View(object sender, EventArgs e)
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
            checkQuestionMustAnwser = answerB == "" && checkA == 1 ? false : true;
            checkQuestionMustAnwser = answerC == "" && checkA == 1 ? false : true;
            checkQuestionMustAnwser = answerD == "" && checkA == 1 ? false : true;
            checkQuestionMustAnwser = answerE == "" && checkA == 1 ? false : true;
            checkQuestionMustAnwser = answerF == "" && checkA == 1 ? false : true;

            string classIDSelected = view.GradeId;
            string subjectIDSelected = view.SubjectId;
            if (checkA == 0 && checkB == 0 && checkC == 0 && checkD == 0 && checkE == 0 && checkF == 0)
            {
                view.ShowMessage("Phải có ít nhất 1 câu trả lời là đúng!!");
            }
            else if(countQuestion <4)
            {
                view.ShowMessage("Phải có ít nhất 4 câu hỏi");
            }
            else if (!checkQuestionMustAnwser)
            {
                view.ShowMessage("Câu trả lời phải có câu hỏi");
            }
            else
            {
                var doKhorr = int.Parse(view.lvDifficute);
                using (var db = new QuizDataContext())
                {
                    //kiểm tra cau hỏi có chưa
                    var checkquestion = db.cauHois.Where(i => i.cauHoi1 == Questionsstring && i.maKhoiLop == classIDSelected && i.maMonHoc == int.Parse(subjectIDSelected)).ToList();
                    if (checkquestion.Count == 0)
                    {
                        //thêm vào bảng câu hỏi
                        db.cauHois.InsertOnSubmit(new cauHoi
                        {
                            maMonHoc = int.Parse(subjectIDSelected),
                            cauHoi1 = Questionsstring,
                            doKho = int.Parse(view.lvDifficute),
                            trangThai = 1,
                            maKhoiLop = classIDSelected
                        });
                        db.SubmitChanges();

                        //thêm vào bảng đáp án
                        //var idContribution_next = db.dongGops.Max(i => i.maDongGop);
                        var QuestionID = db.cauHois.Max(i => i.maCauHoi);
                        int AnswerID = 1;
                        if (answerA != "")
                        {
                            db.dapAns.InsertOnSubmit(new dapAn
                            {
                                maCauHoi = QuestionID,
                                maCauTraloi = AnswerID,
                                cauTraLoi = answerA,
                                dapAn1 = checkA
                            });
                            db.SubmitChanges();
                            AnswerID++;
                        }
                        if (answerB != "")
                        {
                            db.dapAns.InsertOnSubmit(new dapAn
                            {
                                maCauHoi = QuestionID,
                                maCauTraloi = AnswerID,
                                cauTraLoi = answerB,
                                dapAn1 = checkB
                            });
                            db.SubmitChanges();
                            AnswerID++;
                        }
                        if (answerC != "")
                        {
                            db.dapAns.InsertOnSubmit(new dapAn
                            {
                                maCauHoi = QuestionID,
                                maCauTraloi = AnswerID,
                                cauTraLoi = answerC,
                                dapAn1 = checkC
                            });
                            db.SubmitChanges();
                            AnswerID++;
                        }
                        if (answerD != "")
                        {
                            db.dapAns.InsertOnSubmit(new dapAn
                            {
                                maCauHoi = QuestionID,
                                maCauTraloi = AnswerID,
                                cauTraLoi = answerD,
                                dapAn1 = checkD
                            });
                            db.SubmitChanges();
                            AnswerID++;
                        }
                        if (answerE != "")
                        {
                            db.dapAns.InsertOnSubmit(new dapAn
                            {
                                maCauHoi = QuestionID,
                                maCauTraloi = AnswerID,
                                cauTraLoi = answerE,
                                dapAn1 = checkE
                            });
                            db.SubmitChanges();
                            AnswerID++;
                        }
                        if (answerF != "")
                        {
                            db.dapAns.InsertOnSubmit(new dapAn
                            {
                                maCauHoi = QuestionID,
                                maCauTraloi = AnswerID,
                                cauTraLoi = answerF,
                                dapAn1 = checkF
                            });
                            db.SubmitChanges();
                            AnswerID++;
                        }
                        view.ShowMessage("Tạo câu hỏi thành công");
                        view.ShowQuestionList(currentUser, view.GradeId, int.Parse(view.SubjectId));
                    }
                    else
                        view.ShowMessage("Câu hỏi đã tồn tại");
                }
            }
        }

        private void GoBackMain_View(object sender, EventArgs e)
        {
            view.ShowMainTeacher(currentUser);
        }
    }
}
