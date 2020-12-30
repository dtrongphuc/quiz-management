using quiz_management.Models;
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
        private CreateUserPresenter presenter;

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
            cbbDesentrazation.SelectedIndexChanged += (_, e) =>
            {
                ChangeCbbDesentralization?.Invoke(cbbDesentrazation, e);
            };
        }

        public string AdminName { set => lbAdminName.Text = value; }

        public string UserName => tbUserName.Text;

        public string Pass => tbPass.Text;

        public string Desentralization => cbbDesentrazation.Text;

        public string Datenow { set => lbDOB.Text = value; }

        public string classID => cbbClass.SelectedValue.ToString();

        public List<Lop> ClassList { set => cbbClass.DataSource = value; }
        public bool cbbAllClass { set => cbbClass.Enabled = value; }

        public string AcountName => tbAcoutName.Text;

        public DateTime DOB => dtpDOB.Value;

        public event EventHandler CreateUser;

        public event EventHandler GoBackBefore;

        public event EventHandler ChangeCbbDesentralization;

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

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImportUsersView screen = new ImportUsersView();
            screen.FormClosed += (_, ev) => this.Show();
            screen.Show();
        }
    }
}