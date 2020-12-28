using quiz_management.Presenters.Administrator.UserManagement;
using quiz_management.Views.Administrator.MainAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Administrator.UserManagement
{
    public partial class CreateUserView : Form, ICreateUserView
    {
        CreateUserPresenter presenter;
        public CreateUserView(int code)
        {
            InitializeComponent();
            presenter = new CreateUserPresenter(this, code);
            btnCreateUser.Click += (_, e) =>
            {
                CreateUser?.Invoke(btnCreateUser, e);
            };
            linkGoBack.Click += (_, e) =>
              {
                  GoBackBefore?.Invoke(linkGoBack, e);
              };
        }

        public string AdminName { set => lbAdminName.Text = value; }

        public string UserName => tbUserName.Text;

        public string Pass => tbPass.Text;

        public string Desentralization => cbbDesentrazation.Text;

        public string DOB { set => lbDOB.Text = value; }

        public event EventHandler CreateUser;
        public event EventHandler GoBackBefore;

        public void ShowMainAdmin(int userCode)
        {
            this.Hide();
            MainAdminView screen = new MainAdminView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessages(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }
    }
}
