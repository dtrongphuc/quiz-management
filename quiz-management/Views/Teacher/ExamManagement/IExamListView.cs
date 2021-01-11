using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.ExamManagement
{
    interface IExamListView
    {
        Binding<TestSchedule> dtgv {set; }
        DataGridView lichthichon { get; }

        event EventHandler GobackBefore;
        event EventHandler Delete;
        event EventHandler UpdateExam;
        event EventHandler AddExam;


        void ShowCreateExamView(int code);
        void ShowMessage(string text);
        void ShowUpdateExamView(int code, int userid);
        void ShowMainTeachView(int code);
        
    }
}
