using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.ContribuQuestions
{
    interface ICQuestionListView
    {
        List<dongGop> contributed { set; }
        event EventHandler Closepage;
        event EventHandler GoBackBefore;
        void ShowMessage(string text);
        void ShowMainCQuestionView(int code);
    }
}
