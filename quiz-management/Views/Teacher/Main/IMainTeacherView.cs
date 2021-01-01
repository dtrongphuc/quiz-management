using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.Main
{
    internal interface IMainTeacherView
    {
        string TeacherName { set; }
        string TeacherID { set; }
        string DOB { set; }

        event EventHandler UpdateInfo;

        event EventHandler CreateQuestion;

        event EventHandler QuestionApproval;

        event EventHandler OfficialExamClick;

        event EventHandler PracticExamClick;

        void ShowUpdateInfo(int code);

        void ShowCreateQuestion(int code);

        void ShowQuestionApproval(int code);

        void ShowMessage(string text);

        void ShowOfficialExamView(int userCode);

        void ShowPracticExamView(int userCode);
    }
}