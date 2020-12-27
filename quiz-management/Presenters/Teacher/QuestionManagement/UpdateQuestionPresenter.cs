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
            view.ShowListQuestion(currentUser);
        }

        private void UpdateQuestion_View(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadPage()
        {
            using (var db = new QuizDataContext())
            {
                //ten gv
                view.TeacherName = db.thongTins.Where(i => i.maNguoidung == 1).Select(i => i.tenNguoiDung).ToList()[0].ToString();
                //monhoc
                view.GradeList = db.khoiLops.ToList();
                //monhoc
                view.SubjectList = db.monHocs.ToList();

                //cau hoi
                var question = db.cauHois.Where(i => i.maCauHoi == questionid).ToList();
                view.Question = question[0].cauHoi1;
                //cau trả lời
                //view.AnswerA = question[0].dapAns.Where(i => i.maCauHoi == questionid && i.maCauTraloi == 1).Select(i => i.dapAn1).ToList()[0].ToString();
                foreach(var answer in question[0].dapAns)
                {
                    if(answer.maCauTraloi == 1)
                    {
                        view.AnswerA = answer.cauTraLoi;
                        view.cbResultA = answer.dapAn1 == 1 ? true : false;
                    }
                    else if (answer.maCauTraloi == 2)
                    {
                        view.AnswerB = answer.cauTraLoi;
                        view.cbResultB = answer.dapAn1 == 1 ? true : false;
                    }
                    else if(answer.maCauTraloi == 3)
                    {
                        view.AnswerC = answer.cauTraLoi;
                        view.cbResultC = answer.dapAn1 == 1 ? true : false;
                    }
                    else if(answer.maCauTraloi == 4)
                    {
                        view.AnswerD = answer.cauTraLoi;
                        view.cbResultD = answer.dapAn1 == 1 ? true : false;
                    }
                    else if(answer.maCauTraloi == 5)
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
