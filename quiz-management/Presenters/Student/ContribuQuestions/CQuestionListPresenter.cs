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
            using (var db = new QuizDataContext())
            {
                var questions = db.dongGops.Where(i => i.maNguoiDung == currenUserCode).ToList();
                if (questions.Count > 0 && questions != null)
                    view.contributed = questions;
            }
        }

        private void LoadContributeQuestionList(int code)
        {
            view.ShowMainCQuestionView(currenUserCode);
        }

        private void Closepage_View(object sender, EventArgs e)
        {
            view.ShowMainCQuestionView(currenUserCode);
        }
    }
}
