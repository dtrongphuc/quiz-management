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
    }
}