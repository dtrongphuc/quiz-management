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
    public partial class CreateMockExamView : Form,ICreateMockExamView
    {
        CreateMockExamPresenter presenter;
        public CreateMockExamView(int code)
        {
            InitializeComponent();
            dgvBoDe.AutoGenerateColumns = false;
            dtgHocSinh.AutoGenerateColumns = false;
            dgvThiSinh.AutoGenerateColumns = false;
            presenter = new CreateMockExamPresenter(this, code);
            linkGoBackBefore.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGoBackBefore, e);
            };
            btnSubmit.Click += (_, e) =>
            {
                Submit?.Invoke(btnSubmit, e);
            };
            cbbKhoiLop.SelectedValueChanged += (_, e) =>
            {
                ClassChange?.Invoke(cbbKhoiLop, e);
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

        }

        

        public BindingList<monHoc> lstMonHoc { set => cbMonHoc.DataSource = value; }

        public string monHocChon => cbMonHoc.SelectedValue.ToString();

        public BindingList<boDe> lstDeThi { set => dgvBoDe.DataSource = value; }

        

        public string KhoiLopChon => cbbKhoiLop.SelectedValue.ToString();

        public BindingList<thongTin> lstHocSinh { set => dtgHocSinh.DataSource = value; }
        public BindingList<thongTin> lstThiSinh { set => dgvThiSinh.DataSource = value; }
        public BindingList<khoiLop> lstKhoiLop { set => cbbKhoiLop.DataSource = value; }

        public DataGridView lstThiSinhChon => dgvThiSinh;

        public DataGridView lstHocSinhChon => dtgHocSinh;

        public DataGridView lstBoDeChon => dgvBoDe;

        public DateTime NgayBD => dtNgayThiBD.Value;

        public DateTime NgayKT => dtNgayThiKT.Value;

        public event EventHandler GoBackBefore;
        public event EventHandler Submit;
        public event EventHandler subjectChange;
        public event EventHandler MoveLeft;
        public event EventHandler MoveRight;
        public event EventHandler ClassChange;


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
