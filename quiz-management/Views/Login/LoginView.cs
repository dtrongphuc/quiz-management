using quiz_management.Presenters.Login;
using quiz_management.Views.Login;
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

namespace quiz_management.Views.Student
{
    public partial class LoginView : Form, ILoginView
    {
        LoginPresenter presenter;

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

        public void ShowStudentView()
        {
            this.Hide();
            MainStudentView screen = new MainStudentView();
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowTeacherView()
        {
            this.Hide();
            //RegisterView screen = new RegisterView();
            //screen.FormClosed += (_, e) => this.Close();
            //screen.Show();
        }

        public void ShowAdminView()
        {
            this.Hide();
            //RegisterView screen = new RegisterView();
            //screen.FormClosed += (_, e) => this.Close();
            //screen.Show();
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

            ToRegisterView.Click += (_, e) =>
            {
                SwitchToRegisterView.Invoke(ToRegisterView, e);
            };
        }
    }
}
