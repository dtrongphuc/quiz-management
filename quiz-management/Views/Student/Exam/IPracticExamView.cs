using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.Exam
{
    internal interface IPracticExamView
    {
        string StudentName { set; }
        string StudentClass { set; }
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
        List<int> QuestionsChecked { set; }
        BindingList<monHoc> Courses { set; }
        List<int> ExamCodes { set; }
        List<int> CorrectAnswers { set; }

        event EventHandler QuestionChange;

        event EventHandler AnswerCheck;

        event EventHandler CoursesChange;

        event EventHandler ExamCodeChange;

        event EventHandler ViewCurrentAnswers;

        event EventHandler ViewAllAnswers;

        event EventHandler StatisticClicked;

        event Action Timeout;

        event EventHandler Submit;

        event EventHandler Next;

        event EventHandler Prev;

        bool ShowMessage(string caption, string text);

        void ShowStudentView(int userCode);

        void ShowStatisticView(int userCode);
    }
}