using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.StudentManagement
{
    internal interface IExamStatisticView
    {
        List<DateTime> ExamDateTimes { set; }

        int TotalStudent { set; }
        int TotalStudentAboveAverage { set; }
        int TotalStudentBelowAverage { set; }
        int TotalMaxScoring { set; }

        event EventHandler DateTimeChanged;
    }
}