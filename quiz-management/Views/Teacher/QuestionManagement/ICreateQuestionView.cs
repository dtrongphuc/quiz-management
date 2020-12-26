using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.QuestionManagement
{
    interface ICreateQuestionView
    {
        string TeacherName { set; }
        string Question { get; }
        string GradeId { get; }
        string SubjectId { get; }
        string lvDifficute { get; }
        string AnswerA { get; }
        string AnswerB { get; }
        string AnswerC { get; }
        string AnswerD { get; }
        string AnswerE { get; }
        string AnswerF { get; }

        bool cbResultA { get; }
        bool cbResultB { get; }
        bool cbResultC { get; }
        bool cbResultD { get; }
        bool cbResultE { get; }
        bool cbResultF { get; }

        List<khoiLop> GradeList { set; }
        List<monHoc> SubjectList { set; }

        event EventHandler Create;
        event EventHandler GoBackMain;
        event EventHandler ShowListQuestion;

        void ShowMainTeacher(int code);
        void ShowQuestionList(int code);
        void ShowMessage(string text);
    }
}
