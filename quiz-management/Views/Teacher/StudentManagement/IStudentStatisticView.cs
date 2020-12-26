using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.StudentManagement
{
    internal interface IStudentStatisticView
    {
        List<DateTime> ExamDateTimes { set; }

        event EventHandler DateTimeChanged;
    }
}