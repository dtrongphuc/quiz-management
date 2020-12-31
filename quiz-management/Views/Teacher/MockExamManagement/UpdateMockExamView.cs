using quiz_management.Models;
using quiz_management.Presenters.Teacher.MockExamManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.MockExamManagement
{
    public partial class UpdateMockExamView : Form,IUpdateMockExamView
    {
        UpdateMockExamPresenter presenter;
        public UpdateMockExamView(int code)
        {
            InitializeComponent();
            dgvBoDe.AutoGenerateColumns = false;
            dgvDeThiChon.AutoGenerateColumns = false;
            dtgHocSinh.AutoGenerateColumns = false;
            dgvThiSinh.AutoGenerateColumns = false;
            presenter = new UpdateMockExamPresenter(this, code);
            btnMoveLeft.Click += (_, e) =>
            {
                MoveLeft?.Invoke(btnMoveLeft, e);
            };
            btnMoveRight.Click += (_, e) =>
            {
                MoveRight?.Invoke(btnMoveRight, e);
            };
            btnSubmit.Click += (_, e) =>
            {
                Submit?.Invoke(btnSubmit, e);
            };
            linkGoBackBefore.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGoBackBefore, e);
            };
            btnMoveRightBoDe.Click += (_, e) =>
            {
                MoveRightBoDe?.Invoke(btnMoveRightBoDe, e);
            };
            btnMoveLeftBoDe.Click += (_, e) =>
            {
                MoveLeftBoDe?.Invoke(btnMoveLeftBoDe, e);
            };
        }

        public string khoiLopChon { set => lbKhoiLop.Text = value; }
        public string monHoc { set => lbMonHoc.Text = value; }
        public DateTime ngayBD { get => dtNgayThiBD.Value; set => dtNgayThiBD.Value = value; }
        public DateTime ngayKT { get => dtNgayThiKT.Value; set => dtNgayThiKT.Value = value; }
        public BindingList<thongTin> lstHocSinh { set => dtgHocSinh.DataSource = value; }
        public BindingList<thongTin> lstThiSinh { set => dgvThiSinh.DataSource = value; }
        public BindingList<boDe> lstDeThi { set => dgvDeThiChon.DataSource = value; }
        public BindingList<boDe> lstBoDe { set => dgvBoDe.DataSource = value; }

        public DataGridView lstThiSinhChon => dgvThiSinh;
        public DataGridView lstHocSinhChon => dtgHocSinh;
        public DataGridView lstBoDeChon => dgvBoDe;
        public DataGridView lstDeThiChon => dgvDeThiChon;

        public event EventHandler GoBackBefore;
        public event EventHandler Submit;
        public event EventHandler MoveLeft;
        public event EventHandler MoveRight;
        public event EventHandler MoveRightBoDe;
        public event EventHandler MoveLeftBoDe;

        public void ShowExamListView(int code)
        {
            this.Hide();
            ListMockExamView screen = new ListMockExamView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }
    }
}
