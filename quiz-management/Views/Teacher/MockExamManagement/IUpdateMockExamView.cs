using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.MockExamManagement
{
    public interface IUpdateMockExamView
    {
        string khoiLopChon { set; }
        string monHoc { set; }
        DateTime ngayBD { get; set; }
        DateTime ngayKT { get; set; }
        BindingList<thongTin> lstHocSinh { set; }
        BindingList<thongTin> lstThiSinh { set; }
        BindingList<boDe> lstDeThi { set; }
        BindingList<boDe> lstBoDe { set; }
        DataGridView lstThiSinhChon { get; }
        DataGridView lstHocSinhChon { get; }
        DataGridView lstDeThiChon { get; }
        DataGridView lstBoDeChon { get; }

        event EventHandler GoBackBefore;
        event EventHandler Submit;
        event EventHandler MoveLeft;
        event EventHandler MoveRight;

        void ShowExamListView(int code);
        void ShowMessage(string text);
    }
}
