using quiz_management.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.ContribuQuestions
{
    interface IMainCQuestionView
    {
        string StudentID { set; }
        List<khoiLop> classes { set; }
        List<monHoc> Subjects { set; }
        string ClassSelect { get; }
        string SubjectSelect { get; }
        string Question { get; set; }
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
        event EventHandler Send;
        event EventHandler GoBackMain;
        void ShowMainStudentView(int code);
    }
}
