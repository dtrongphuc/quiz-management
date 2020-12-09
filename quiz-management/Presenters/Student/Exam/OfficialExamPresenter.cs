using quiz_management.Views.Student.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.Exam
{
    class OfficialExamPresenter
    {
        IOfficialExamView view;
        public int time = 1800;

        public OfficialExamPresenter(IOfficialExamView v)
        {
            view = v;
            view.StudentName = "Dương Trọng Phúc";
            view.StudentClass = "18CK2";
            view.ExamTime = time;
        }
    }
}
