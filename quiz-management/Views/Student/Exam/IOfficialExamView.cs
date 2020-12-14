using quiz_management.Models;
using System;
using System.Collections.Generic;

namespace quiz_management.Views.Student.Exam
{
    internal interface IOfficialExamView
    {
        string StudentName { set; }
        string StudentClass { set; }
        string ExamCode { set; }
        int QuestionOrder { set; }
        int QuestionQuantity { set; }
        int QuestionSelected { set; }
        bool QuestionChecked { set; }
        int ExamTime { set; }
        int Completed { set; }
        int Remain { get; set; }
        string QuestionString { set; }
        List<Answer> Answers { set; }

        event EventHandler QuestionChange;

        event EventHandler AnswerCheck;

        event EventHandler Submit;

        event EventHandler Next;

        event EventHandler Prev;
    }
}