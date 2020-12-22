using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.Exam
{
    internal interface IPracticStatistic
    {
        string StudentName { set; }
        string StudentClass { set; }
        int Total { set; }
        int CorrectedCount { set; }
        int WrongCount { set; }
    }
}