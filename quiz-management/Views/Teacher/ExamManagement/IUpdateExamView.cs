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
    interface IUpdateExamView
    {
        string NgayThi {set; }
        string monHocChon {  set; }
        string KhoiLopChon { set; }
        string DeThiChon { set; }
        DataGridView lstHocSinh { get; }
        DataGridView lstThiSinh { get; }
        
       

        event EventHandler GoBackBefore;
        event EventHandler Submit;
        event EventHandler MoveLeft;
        event EventHandler MoveRight;

        void ShowExamListView(int code);
        void ShowMessage(string text);
    }
}
