using quiz_management.Models;
using quiz_management.Views.Student.ContribuQuestions;
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
        public ContribuQuestionPresenter(IMainCQuestionView v)
        {
            view = v;
            //LoadClass();
            view.Send += Send_CLick;
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
            using (var db = new QuizDataContext())
            {
                var idContribution_next = db.dongGops.ToList();
                db.dongGops.InsertOnSubmit(new dongGop
                {
                    maNguoiDung = 1,
                    maMonHoc = 1,
                    trangthai = 1,
                    ngay = DateTime.Now,
                    cauHoi = Questionsstring
                });
                db.cTDongGops.InsertOnSubmit(new cTDongGop
                {
                    maDongGop = idContribution_next.Count()+1,
                    cauTraLoi = answerA,
                });
            }
        }

        public void LoadSubject()
        {
        }

        public void LoadClass()
        {
            using (var db = new QuizDataContext())
            {
                var classlist = db.Lops.ToList();
                if (classlist != null)
                {

                }
            }
        }
    }
}
