using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.ExamManagement
{
    interface IWatchOrPrintExamView
    {
        string TeacherName { set; }
        List<StudentOfExam> ExamList { set; }
        event EventHandler GobackBefore;
        event EventHandler Print;
        void Message(string text);
        void ShowMainTeacher(int code);
    }
}
