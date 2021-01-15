using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.MockExamManagement
{
    interface IListMockExamView
    {
        string TeacherName { set; }
        string ExamID { get; }
        BindingList<MockExam> MockExamList { set; }

        event EventHandler GoBackBeFore;
        event EventHandler UpdateExam;
        event EventHandler DeleteExam;
        event EventHandler CreateExam;

        void ShowCreateMockExamView(int code);
        void ShowMessage(string text);
        void ShowUpdateMockExamView(int code,int userid);
        void ShowMainTeacherView(int code);
    }
}
