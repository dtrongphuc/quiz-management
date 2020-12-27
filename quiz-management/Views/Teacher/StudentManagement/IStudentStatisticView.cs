using quiz_management.Models;
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

        //List<monHoc> Courses { set; }
        List<StudentStatistic> StatisticData { set; }

        event EventHandler DateTimeChanged;

        event EventHandler SearchTextChanged;
    }
}