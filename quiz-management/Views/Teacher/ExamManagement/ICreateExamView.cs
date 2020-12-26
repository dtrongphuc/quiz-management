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
        BindingList<monHoc> lstMonHoc { set; }
        string monHocChon { get; }
        BindingList<boDe> lstDeThi { set; }
        string DeThiChon { get; }
        string KhoiLopChon { get; }
        BindingList<thongTin> lstHocSinh { set; }
        BindingList<thongTin> lstThiSinh { set; }
        BindingList<khoiLop> lstKhoiLop { set; }
        DataGridView lstThiSinhChon { get; }
        DataGridView lstHocSinhChon { get; }

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
