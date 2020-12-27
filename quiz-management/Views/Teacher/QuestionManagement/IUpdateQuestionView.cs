using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.QuestionManagement
{
    interface IUpdateQuestionView
    {
        string TeacherName { set; }
        string Question { get; set; }
        string GradeId { get; }
        string SubjectId { get; }
        string lvDifficute { get; set; }
        string AnswerA { get; set;}
        string AnswerB { get; set;}
        string AnswerC { get; set;}
        string AnswerD { get; set;}
        string AnswerE { get; set;}
        string AnswerF { get; set;}
                              
        bool cbResultA { get; set;}
        bool cbResultB { get; set;}
        bool cbResultC { get; set;}
        bool cbResultD { get; set;}
        bool cbResultE { get; set;}
        bool cbResultF { get; set; }

        List<khoiLop> GradeList { set; }
        List<monHoc> SubjectList { set; }
        string GradeSelected { set; }
        string SubjectSelected { set; }

        event EventHandler UpdateQuestion;
        event EventHandler GoBackBefore;

        void ShowListQuestion(int code);
        void ShowMessage(string text);
    }
}
