﻿using quiz_management.Models;
using quiz_management.Presenters.Student.InfoPersonal;
using quiz_management.Views.Student.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Student.InfoPersonal
{
    public partial class ProfileView : Form, IProfileView
    {
        private ProfilePresenter presenter;

        public ProfileView(int code)
        {
            InitializeComponent();
            presenter = new ProfilePresenter(this, code);
            AutoValidate = AutoValidate.Disable;

            btnSubmit.Click += (_, e) =>
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ dữ liệu hợp lệ");
                    return;
                }
                Updatebtn?.Invoke(btnSubmit, e);
            };

            btnClose.Click += (_, e) =>
            {
                Closebtn?.Invoke(btnSubmit, e);
            };

            txtDOBStudent.GotFocus += (_, e) =>
            {
                if (txtDOBStudent.Text == "dd/mm/yyyy")
                {
                    txtDOBStudent.Text = "";
                }
            };

            txtDOBStudent.LostFocus += (_, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtDOBStudent.Text))
                    txtDOBStudent.Text = "dd/mm/yyyy";
            };
        }

        public string _maSo { set => txtIdStudent.Text = value; get => txtIdStudent.Text; }
        public string _hoTen { get => txtNameStudent.Text; set => txtNameStudent.Text = value; }
        public string _ngaysinh { get => txtDOBStudent.Text; set => txtDOBStudent.Text = value; }
        public BindingList<Lop> _lop { set => cbLop.DataSource = value; }

        public Lop _lopChon
        {
            get
            {
                return (Lop)cbLop.SelectedItem;
            }
            set => cbLop.SelectedItem = value;
        }

        public event EventHandler Updatebtn;

        public event EventHandler Closebtn;

        public void swichMainStudent(int code)
        {
            this.Hide();
            MainStudentView screen = new MainStudentView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}