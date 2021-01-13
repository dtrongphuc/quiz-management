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
    public interface ICreateExamView
    {
        DateTime NgayThi { get; }
        ComboBox lstMonHoc { get; }
        string monHocChon { get; }
        ComboBox lstDeThi { get; }
        string DeThiChon { get; }
        string KhoiLopChon { get; }
        DataGridView lstHocSinh { get; }
        DataGridView lstThiSinh { get; }
        ComboBox lstKhoiLop { get; }
       /* DataGridView lstThiSinhChon { get; }
        DataGridView lstHocSinhChon { get; }*/

        event EventHandler GoBackBefore;
        event EventHandler Submit;
        event EventHandler subjectChange;
        event EventHandler MoveLeft;
        event EventHandler MoveRight;
        event EventHandler ClassChange;

        void ShowExamListView(int code);
        void ShowMessage(string text);
    }
}
