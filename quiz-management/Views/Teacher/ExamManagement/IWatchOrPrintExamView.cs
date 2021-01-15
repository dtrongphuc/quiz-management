using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.ExamManagement
{
    internal interface IWatchOrPrintExamView
    {
        List<StudentOfExam> ExamList { set; }

        event EventHandler GobackBefore;

        void Message(string text);

        void ShowMainTeacher(int code);
    }
}