using System;
using System.Collections.Generic;

namespace quiz_management.Views.Student.Exam
{
    internal interface IOfficialExamView
    {
        string StudentName { set; }
        string StudentClass { set; }
        string ExamCode { set; }
        int QuestionCount { set; }
        int ExamTime { set; }
        int Completed { set; }
        int Remain { get; set; }
        //object QuestionsDataSource { set; }

        event EventHandler QuestionChange;

        event EventHandler Submit;

        event EventHandler Next;

        event EventHandler Prev;
    }
}