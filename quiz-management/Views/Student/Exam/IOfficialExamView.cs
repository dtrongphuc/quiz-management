using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.Exam
{
    interface IOfficialExamView
    {
        string StudentName { set; }
        string StudentClass { set; }
        string ExamCode { set; }
        int ExamTime { set; }
        int Completed { set; }
        int Remain { get; set; }

        //List<string> ExamQuestions { set; }
        //List<string> ExamAnswers { set; }

        event EventHandler Submit;
        event EventHandler Next;
        event EventHandler Prev;
    }
}
