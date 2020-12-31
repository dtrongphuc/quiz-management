using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.MockExamManagement
{
    interface IListMockExamView
    {
        string TeacherName { set; }
        string ExamID { get; }
        string PaperID { get; }
        string UserID { get; }
        List<MockExam> MockExamList { set; }
        event EventHandler GoBackBeFore;
        event EventHandler UpdateExam;
        event EventHandler DeleteExam;

        void ShowCreateMockExamView(int code);
        void ShowMessage(string text);
        void ShowUpdateMockExamView(int code);
    }
}
