using quiz_management.Models;
using System;
using System.Collections.Generic;
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
        List<Answer> Answers { set; }
        List<int> QuestionsChecked { set; }
        List<monHoc> Courses { set; }
        List<int> ExamCodes { set; }

        event EventHandler QuestionChange;

        event EventHandler AnswerCheck;

        event EventHandler CoursesChange;

        event EventHandler ExamCodeChange;

        event EventHandler Timeout;

        event EventHandler Submit;

        event EventHandler Next;

        event EventHandler Prev;

        bool ShowMessage(string caption, string text);

        void ShowStudentView(int userCode);
    }
}