using quiz_management.Models;
using quiz_management.Presenters.Teacher.ExamManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.ExamManagement
{
    public partial class UpdateExamView : Form,IUpdateExamView
    {
        UpdateExamPresenter presenter;
        public UpdateExamView(int code, int userid)
        {
            InitializeComponent();
            dtgHocSinh.AutoGenerateColumns = false;
            dgvThiSinh.AutoGenerateColumns = false;
            presenter = new UpdateExamPresenter(this, code,userid);
            linkGoForBack.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGoForBack, e);
            };
            btnExam.Click += (_, e) =>
            {
                Submit?.Invoke(btnExam, e);
            };
            
            btnMoveRight.Click += (_, e) =>
            {
                MoveRight?.Invoke(btnMoveRight, e);
            };
            btnMoveLeft.Click += (_, e) =>
            {
                MoveLeft?.Invoke(btnMoveLeft, e);
            };
            
        }

        
        public BindingList<thongTin> lstHocSinh { set => dtgHocSinh.DataSource = value; }
        public BindingList<thongTin> lstThiSinh { set => dgvThiSinh.DataSource = value; }
        public DataGridView lstThiSinhChon => dgvThiSinh;
        public DataGridView lstHocSinhChon => dtgHocSinh;
        public string monHocChon { set => tbMonHocChon.Text=value; }
        public string DeThiChon { set => tbBoDeChon.Text = value; }
        public string NgayThi {set => tbNgayThiChon.Text = value; }
        public string KhoiLopChon { set => tbKhoiLopChon.Text = value; }

        public event EventHandler GoBackBefore;
        public event EventHandler Submit;
        public event EventHandler MoveLeft;
        public event EventHandler MoveRight;

        public void ShowExamListView(int code)
        {
            this.Hide();
            ExamListView screen = new ExamListView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }
    }
}
