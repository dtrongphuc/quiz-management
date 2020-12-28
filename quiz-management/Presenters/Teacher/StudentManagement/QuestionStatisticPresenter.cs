using quiz_management.Views.Teacher.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.StudentManagement
{
    internal class QuestionStatisticPresenter
    {
        private IQuestionStatisticView view;

        public QuestionStatisticPresenter(IQuestionStatisticView v)
        {
            view = v;
        }

        public void CalcData()
        {
        }
    }
}