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
        BindingList<TrainScript> ExamList { set; }
        event EventHandler GobackBefore;
        void Message(string text);
        void Home(int code);
    }
}
