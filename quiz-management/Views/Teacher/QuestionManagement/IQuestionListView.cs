using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.QuestionManagement
{
    interface IQuestionListView
    {
        string TeacherName { set; }
        string GradeId { get; }
        string SubjectId { get; }
        string QuestionId { get; }
        List<khoiLop> GradeList { set; }
        List<monHoc> SubjectList { set; }
        BindingList<QuestionCreated> QuestionList { set; }

        event EventHandler ShowUpdate;
        event EventHandler GoBackBefore;
        event EventHandler SelectedCBB;

        void ShowCreateQuestion(int code);
        void ShowUpdateQuestion(int code, int questionID);
        void ShowMessage(string text);
    }
}
