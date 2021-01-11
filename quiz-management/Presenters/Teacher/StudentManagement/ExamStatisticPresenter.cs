using quiz_management.Models;
using quiz_management.Views.Teacher.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.StudentManagement
{
    internal class ExamStatisticPresenter
    {
        private IExamStatisticView view;

        public ExamStatisticPresenter(IExamStatisticView v)
        {
            view = v;
            GetExamDateTime();
        }

        public void GetExamDateTime()
        {
            using (var db = new QuizDataContext())
            {
                var result = db.lichThis.GroupBy(g => g.ngayThi).Select(s => s.Key).ToList();
                view.ExamDateTimes = result;
            }
        }
    }
}