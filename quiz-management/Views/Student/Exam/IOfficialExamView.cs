using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

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
        int TimeLeft { get; }
        int Completed { get; set; }
        int Remain { get; set; }
        string QuestionString { set; }
        BindingList<Answer> Answers { set; }
        BindingList<int> QuestionsChecked { set; }

        event EventHandler QuestionChange;

        event EventHandler AnswerCheck;

        event EventHandler Timeout;

        event EventHandler Submit;

        event EventHandler Next;

        event EventHandler Prev;

        bool ShowMessage(string caption, string text);

        void ShowStudentView(int userCode);

        void CloseForm();
    }
}