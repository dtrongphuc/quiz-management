using quiz_management.Models;
using quiz_management.Views.Student.ContribuQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.ContribuQuestions
{
    class CQuestionListPresenter
    {
        ICQuestionListView view;
        int currenUserCode;
        public CQuestionListPresenter(ICQuestionListView v, int code)
        {
            view = v;
            currenUserCode = code;
            LoadContributeQuestionList(code);
            view.Closepage += Closepage_View;
            view.GoBackBefore += GoBackBefore_View;
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowMainCQuestionView(currenUserCode);

            
        }

        private void LoadContributeQuestionList(int code)
        {
            //db.dongGops.InsertOnSubmit(new dongGop
            //{
            //    maNguoiDung = currentUserCode,
            //    maMonHoc = int.Parse(subjectIDSelected),
            //    trangthai = 0,
            //    ngay = DateTime.Now,//ToString("yyyy-MM-dd"),
            //    cauHoi = Questionsstring,
            //    maKhoiLop = classIDSelected
            //});

            //List<dongGop> list = new List<dongGop>();
            //dongGop dg1 = new dongGop
            //{
            //    maDongGop = 1,
            //    maNguoiDung = 1,
            //    maMonHoc = 1,
            //    trangthai = 1,
            //    ngay = DateTime.Now,//ToString("yyyy-MM-dd"),
            //    cauHoi = "Cái gì v??",
            //    maKhoiLop = "K10"
            //};
            //list.Add(dg1);
            //view.contributed = list;

            using (var db = new QuizDataContext())
            {
                var questions = db.dongGops.Where(i => i.maNguoiDung == currenUserCode).ToList();
                if (questions.Count > 0 && questions != null)
                    view.contributed = questions;
            }
        }

        private void Closepage_View(object sender, EventArgs e)
        {
            view.ShowMainCQuestionView(currenUserCode);
        }
    }
}
