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
    public partial class CreateExamView : Form, ICreateExamView
    {
        CreateExamPresenter presenter;
        public CreateExamView(int code)
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
            cbbKhoiLop.SelectedValueChanged += (_, e) =>
            {
                ClassChange?.Invoke(cbbKhoiLop, e);
            };
        }

        public DateTime NgayThi => dtpNgayThi.Value;

        public BindingList<monHoc> lstMonHoc { set => cbMonHoc.DataSource = value; }
        public BindingList<thongTin> lstHocSinh { set => dtgHocSinh.DataSource = value; }
        public BindingList<thongTin> lstThiSinh { set => dgvThiSinh.DataSource = value; }
        public BindingList<boDe> lstDeThi { set =>cbBoDe.DataSource = value; }
        public BindingList<khoiLop> lstKhoiLop { set => cbbKhoiLop.DataSource = value; }

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

        public string KhoiLopChon => cbbKhoiLop.SelectedValue.ToString();

        

        public event EventHandler GoBackBefore;
        public event EventHandler Submit;
        public event EventHandler subjectChange;
        public event EventHandler MoveLeft;
        public event EventHandler MoveRight;
        public event EventHandler ClassChange;

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
