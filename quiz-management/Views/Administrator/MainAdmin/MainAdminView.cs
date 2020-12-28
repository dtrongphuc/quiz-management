using quiz_management.Presenters.Administrator.MainAdmin;
using quiz_management.Views.Administrator.UserManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Administrator.MainAdmin
{
    public partial class MainAdminView : Form, IMainAdminView
    {
        MainAdminPresenter presenter;
        public MainAdminView(int code)
        {
            InitializeComponent();
            presenter = new MainAdminPresenter(this, code);
            btnAddUser.Click += (_, e) =>
            {
                AddUser?.Invoke(btnAddUser, e);
            };
            btnWatchUserList.Click += (_, e) =>
            {
                WatchUserList?.Invoke(btnWatchUserList, e);
            };
            btnDesentalization.Click += (_, e) =>
            {
                Desentralization?.Invoke(btnDesentalization, e);
            };
        }

        public string DOB { set => lbDOB.Text = value; }
        public string AdminName { set => lbAdminName.Text = value; }

        public event EventHandler AddUser;
        public event EventHandler WatchUserList;
        public event EventHandler Desentralization;

        public void ShowAddUser(int userCode)
        {
            this.Hide();
            CreateUserView screen = new CreateUserView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowDesentralization(int userCode)
        {
            //this.Hide();
            //MainCQuestionView screen = new MainCQuestionView(userCode);
            //screen.FormClosed += (_, e) => this.Close();
            //screen.Show();
        }

        public void ShowMessages(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }

        public void ShowWatchUserList(int userCode)
        {
            //this.Hide();
            //MainCQuestionView screen = new MainCQuestionView(userCode);
            //screen.FormClosed += (_, e) => this.Close();
            //screen.Show();
        }
    }
}
