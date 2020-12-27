using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.QuestionManagement
{
    interface IQuestionApprovalView
    {
        string TeacherName { set; }
        BindingList<ContributeQuestion> contributed { set; }
        DataGridView CQuestionSelected { get; }
        event EventHandler Approval;
        event EventHandler GoBackBefore;
        void ShowMessage(string text);
        void ShowMainTeacher(int code);
    }
}
