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
        DateTime NgayThi {set; }
        List<monHoc> lstMonHoc { set; }
        monHoc monHocChon {  set; }
        List<boDe> lstDeThi { set; }
        boDe DeThiChon { set; }
        BindingList<thongTin> lstHocSinh { set; }
        BindingList<thongTin> lstThiSinh { set; }
        DataGridView lstThiSinhChon { get; }
        DataGridView lstHocSinhChon { get; }

        event EventHandler GoBackBefore;
        event EventHandler Submit;
        event EventHandler MoveLeft;
        event EventHandler MoveRight;

        void ShowExamListView(int code);
        void ShowMessage(string text);
    }
}
