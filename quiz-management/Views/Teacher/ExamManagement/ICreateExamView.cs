using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.ExamManagement
{
    public interface ICreateExamView
    {
        string NgayThi { get; }
        List<monHoc> lstMonHoc { set; }
        string monHocChon { get; }
        List<boDe> lstDeThi { set; }
        string DeThiChon { get; }
        List<thongTin> lstHocSinh { set; }
        List<thongTin> lstThiSinh { set; }
        DataGridView lstThiSinhChon { get; }
        DataGridView lstHocSinhChon { get; }

        event EventHandler GoBackBefore;
        event EventHandler Submit;
        event EventHandler subjectChange;
        event EventHandler MoveLeft;
        event EventHandler MoveRight;
        event EventHandler DLeft;
        event EventHandler DRight;


        void MainTeacherView(int code);
        void ShowMessage(string text);
    }
}
