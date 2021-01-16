using quiz_management.Models;
using quiz_management.Presenters.Login;
using quiz_management.Views.Administrator.MainAdmin;
using quiz_management.Views.Login;
using quiz_management.Views.Student.Main;
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

namespace quiz_management.Views.Student
{
    public partial class LoginView : Form, ILoginView
    {
        private LoginPresenter presenter;

        public string Username { get => txtUsername.Text.Trim(); set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text.Trim(); set => txtPassword.Text = value; }

        public event EventHandler Submit;

        public event EventHandler SwitchToRegisterView;

        public void ShowMessage(string text)
        {
            MessageBox.Show(text);
        }

        public void ShowRegisterView()
        {
            this.Hide();
            RegisterView screen = new RegisterView();
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowStudentView(int userCode)
        {
            this.Hide();
            MainStudentView screen = new MainStudentView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowTeacherView(int userCode)
        {
            this.Hide();
            MainTeacherView screen = new MainTeacherView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowAdminView(int userCode)
        {
            this.Hide();
            MainAdminView screen = new MainAdminView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public LoginView()
        {
            presenter = new LoginPresenter(this);
            AutoValidate = AutoValidate.Disable;
            InitializeComponent();

            btnSubmit.Click += (_, e) =>
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ dữ liệu hợp lệ");
                    return;
                }
                Submit?.Invoke(btnSubmit, e);
            };

            btnSubmit.KeyPress += BtnSubmit_KeyPress;

            //btnSubmit

            ToRegisterView.Click += (_, e) =>
            {
                SwitchToRegisterView.Invoke(ToRegisterView, e);
            };
        }

        private void BtnSubmit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ dữ liệu hợp lệ");
                    return;
                }
                Submit?.Invoke(btnSubmit, e);
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ dữ liệu hợp lệ");
                    return;
                }
                Submit?.Invoke(btnSubmit, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ dữ liệu hợp lệ");
                    return;
                }
                Submit?.Invoke(btnSubmit, e);
            }
        }
    }
}