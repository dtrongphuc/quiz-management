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
    public partial class ListUserView : Form, IListUserView
    {
        ListUserPresenter presenter;
        public ListUserView(int code)
        {
            InitializeComponent();
            presenter = new ListUserPresenter(this, code);
            linkGoBack.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGoBack, e);
            };
            btnUpdate.Click += (_, e) =>
            {
                UpdateUser?.Invoke(btnUpdate, e);
            };
            btnExportExcel.Click += (_, e) =>
            {
                ExportExcel?.Invoke(btnExportExcel, e);
            };
        }

        public string AdminName { set => lbAdminName.Text = value; }
        public string Datenow { set => lbDOB.Text = value; }
        public BindingList<InfoUser> UserList { set => dgvUser.DataSource = value; }

        string IListUserView.UserID => dgvUser.SelectedRows[0].Cells["UserID"].Value.ToString();

        public event EventHandler UpdateUser;
        public event EventHandler GoBackBefore;
        public event EventHandler ExportExcel;

        public void ShowExport(int code)
        {
            this.Hide();
            ExportUserView screen = new ExportUserView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

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

        public void ShowUpdate(int userCode, int userid)
        {
            this.Hide();
            UpdateUserView screen = new UpdateUserView(userCode, userid);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}
