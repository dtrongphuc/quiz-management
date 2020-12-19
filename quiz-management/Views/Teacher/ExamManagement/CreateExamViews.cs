using quiz_management.Models;
using quiz_management.Presenters.Teacher.ExamManagement;
using quiz_management.Views.Teacher.Main;
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
    public partial class ShowMainTeachView : Form, ICreateExamView
    {
        CreateExamPresenter presenter;
        public ShowMainTeachView(int code)
        {
            InitializeComponent();
            dtgHocSinh.AutoGenerateColumns = false;
            dgvThiSinh.AutoGenerateColumns = false;
            presenter = new CreateExamPresenter(this,code);
            linkGoForBack.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGoForBack, e);
            };
            btnExam.Click += (_, e) =>
            {
                Submit?.Invoke(btnExam, e);
            };
            cbMonHoc.SelectedValueChanged += (_, e) =>
            {
                subjectChange?.Invoke(cbMonHoc, e);
            };
            btnMoveRight.Click += (_, e) =>
            {
                MoveRight?.Invoke(btnMoveRight, e);
            };
            btnMoveLeft.Click += (_, e) =>
            {
                MoveLeft?.Invoke(btnMoveLeft, e);
            };
            //còn lỗi ko 
        }

        public DateTime NgayThi => dtpNgayThi.Value;

        public List<monHoc> lstMonHoc { set => cbMonHoc.DataSource = value; }
        public List<thongTin> lstHocSinh { set => dtgHocSinh.DataSource = value; }
        public List<thongTin> lstThiSinh { set => dgvThiSinh.DataSource = value; }
        public List<boDe> lstDeThi { set =>cbBoDe.DataSource = value; }


        public string monHocChon {
            get
            {
                return cbMonHoc.SelectedValue.ToString();
            }
        }

        public string DeThiChon => cbBoDe.SelectedValue.ToString();

        public DataGridView lstThiSinhChon
        {
            get
            {
                return dgvThiSinh;
            }
        }

        public DataGridView lstHocSinhChon
        {
            get
            {
                return dtgHocSinh;
            }
        }
        public event EventHandler GoBackBefore;
        public event EventHandler Submit;
        public event EventHandler subjectChange;
        public event EventHandler MoveLeft;
        public event EventHandler MoveRight;
        public event EventHandler examChange;

        public void MainTeacherView(int code)
        {
            this.Hide();
            MainTeacherView screen = new MainTeacherView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }
    }
}
