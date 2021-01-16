using quiz_management.Models;
using quiz_management.Views.Teacher.QuestionManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.QuestionManagement
{
    class UpdateQuestionPresenter
    {
        IUpdateQuestionView view;
        int currentUser = 0;
        int questionid = 0;
        public UpdateQuestionPresenter(IUpdateQuestionView v, int code, int question)
        {
            view = v;
            currentUser = code;
            questionid = question;
            LoadPage();
            view.GoBackBefore += GoBackBefore_View;
            view.UpdateQuestion += UpdateQuestion_View;
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowListQuestion(currentUser, view.GradeId, int.Parse(view.SubjectId));
        }

        private void UpdateQuestion_View(object sender, EventArgs e)
        {
            int countQuestion = 0;
            int checkQuestionMustAnwser = 0;

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
            checkQuestionMustAnwser = answerA == "" && checkA == 1 ? checkQuestionMustAnwser + 1 : checkQuestionMustAnwser + 0;
            checkQuestionMustAnwser = answerB == "" && checkB == 1 ? checkQuestionMustAnwser + 1 : checkQuestionMustAnwser + 0;
            checkQuestionMustAnwser = answerC == "" && checkC == 1 ? checkQuestionMustAnwser + 1 : checkQuestionMustAnwser + 0;
            checkQuestionMustAnwser = answerD == "" && checkD == 1 ? checkQuestionMustAnwser + 1 : checkQuestionMustAnwser + 0;
            checkQuestionMustAnwser = answerE == "" && checkE == 1 ? checkQuestionMustAnwser + 1 : checkQuestionMustAnwser + 0;
            checkQuestionMustAnwser = answerF == "" && checkF == 1 ? checkQuestionMustAnwser + 1 : checkQuestionMustAnwser + 0;

            string classIDSelected = view.GradeId;
            string subjectIDSelected = view.SubjectId;
            if (checkA == 0 && checkB == 0 && checkC == 0 && checkD == 0 && checkE == 0 && checkF == 0)
            {
                view.ShowMessage("Phải có ít nhất 1 câu trả lời là đúng!!");
            }
            else if (countQuestion < 4)
            {
                view.ShowMessage("Phải có ít nhất 4 câu hỏi");
            }
            else if (checkQuestionMustAnwser > 0)
            {
                view.ShowMessage("Câu trả lời phải có câu hỏi");
            }
            else
            {
                var doKhorr = int.Parse(view.lvDifficute);
                using (var db = new QuizDataContext())
                {
                    //kiểm tra cau hỏi có chưa
                    var questionupdate = db.cauHois.Single(i => i.maCauHoi == questionid);
                    questionupdate.cauHoi1 = Questionsstring;
                    questionupdate.doKho = int.Parse(view.lvDifficute);
                    questionupdate.maKhoiLop = classIDSelected;
                    questionupdate.maMonHoc = int.Parse(subjectIDSelected);
                    db.SubmitChanges();

                    //xóa trong đáp án
                    var answers = db.dapAns.Where(i => i.maCauHoi == questionid).ToList();
                    foreach (var i in answers)
                    {
                        db.dapAns.DeleteOnSubmit(i);
                        db.SubmitChanges();
                    }

                    //thêm lại vào bảng đáp án
                    int AnswerID = 1;
                    if (answerA != "")
                    {
                        db.dapAns.InsertOnSubmit(new dapAn
                        {
                            maCauHoi = questionid,
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
                            maCauHoi = questionid,
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
                            maCauHoi = questionid,
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
                            maCauHoi = questionid,
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
                            maCauHoi = questionid,
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
                            maCauHoi = questionid,
                            maCauTraloi = AnswerID,
                            cauTraLoi = answerF,
                            dapAn1 = checkF
                        });
                        db.SubmitChanges();
                        AnswerID++;
                    }
                    view.ShowMessage("Cập nhật câu hỏi thành công");
                    //cập nhật xong quay lại danh sách
                    view.ShowListQuestion(currentUser, view.GradeId, int.Parse(view.SubjectId));

                }
            }
        }

        private void LoadPage()
        {
            using (var db = new QuizDataContext())
            {
                //ten gv
                view.TeacherName = db.thongTins.Where(i => i.maNguoidung == currentUser).Select(i => i.tenNguoiDung).ToList()[0].ToString();
                //monhoc
                view.GradeList = db.khoiLops.ToList();
                //monhoc
                view.SubjectList = db.monHocs.ToList();

                //cau hoi
                var question = db.cauHois.Where(i => i.maCauHoi == questionid).ToList();
                view.Question = question[0].cauHoi1;
                //cau trả lời
                //view.AnswerA = question[0].dapAns.Where(i => i.maCauHoi == questionid && i.maCauTraloi == 1).Select(i => i.dapAn1).ToList()[0].ToString();
                foreach (var answer in question[0].dapAns)
                {
                    if (answer.maCauTraloi == 1)
                    {
                        view.AnswerA = answer.cauTraLoi;
                        view.cbResultA = answer.dapAn1 == 1 ? true : false;
                    }
                    else if (answer.maCauTraloi == 2)
                    {
                        view.AnswerB = answer.cauTraLoi;
                        view.cbResultB = answer.dapAn1 == 1 ? true : false;
                    }
                    else if (answer.maCauTraloi == 3)
                    {
                        view.AnswerC = answer.cauTraLoi;
                        view.cbResultC = answer.dapAn1 == 1 ? true : false;
                    }
                    else if (answer.maCauTraloi == 4)
                    {
                        view.AnswerD = answer.cauTraLoi;
                        view.cbResultD = answer.dapAn1 == 1 ? true : false;
                    }
                    else if (answer.maCauTraloi == 5)
                    {
                        view.AnswerE = answer.cauTraLoi;
                        view.cbResultE = answer.dapAn1 == 1 ? true : false;
                    }
                    else
                    {
                        view.AnswerF = answer.cauTraLoi;
                        view.cbResultF = answer.dapAn1 == 1 ? true : false;
                    }
                }
                //do khó
                view.lvDifficute = question[0].doKho.ToString();

                //môn hôc và khối lớp đã chọn
                view.GradeSelected = question[0].khoiLop.tenKhoiLop;
                view.SubjectSelected = question[0].monHoc.tenMonHoc;
            }
        }
    }
}
