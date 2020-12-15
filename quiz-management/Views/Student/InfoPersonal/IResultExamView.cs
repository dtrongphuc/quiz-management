using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.InfoPersonal
{
    interface IResultExamView
    {
        List<ResultExam> ResultExam { set; }
       

        event EventHandler BackMain;
        void swichMainStudent(int code);


    }
}
