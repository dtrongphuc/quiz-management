using quiz_management.Models;
using quiz_management.Presenters.Administrator.UserManagement;
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
    public partial class UpdateUserView : Form, IUpdateUserView
    {
        UpdateUserPresenter presenter;
        public UpdateUserView(int code, int userid)
        {
            InitializeComponent();
            presenter = new UpdateUserPresenter(this, code, userid);
            linkGoBack.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGoBack, e);
            };
            btnUpdate.Click += (_, e) =>
            {
                SaveUpdate?.Invoke(btnUpdate, e);
            };
            cbbClass.SelectedIndexChanged += (_, e) =>
            {
                ChangeCbbDesentralization?.Invoke(cbbClass, e);
            };
        }

        public string AdminName { set => lbAdminName.Text = value; }

        public string classselected { get => cbbClass.SelectedValue.ToString(); set => cbbClass.Text = value; }

        public List<Lop> ClassList { set => cbbClass.DataSource = value; }
        public bool cbbAllClass { set => cbbClass.Enabled = value; }
        public string UserName { get => tbUserName.Text; set => tbUserName.Text = value; }

        public string Datenow { set => lbDOB.Text = value; }
        public DateTime DOB { get => dtpDOB.Value; set => dtpDOB.Value = value; }

        public string Desentralization => cbbClass.Text;

        public string AcountName { set => tbAcountName.Text = value; }

        public event EventHandler SaveUpdate;
        public event EventHandler GoBackBefore;
        public event EventHandler ChangeCbbDesentralization;

        public void ShowListUser(int userCode)
        {
            this.Hide();
            ListUserView screen = new ListUserView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessages(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }

    }
}
