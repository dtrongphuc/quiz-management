using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.ExamManagement
{
    interface IWatchOrPrintExamCompletedView
    {
        string TeacherName { set; }
        BindingList<TrainScript> ExamList { set; }
        event EventHandler GobackBefore;
        event EventHandler Print;
        void Message(string text);
        void Home(int code);
    }
}
