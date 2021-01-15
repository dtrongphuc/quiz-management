using Microsoft.Reporting.WinForms;
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
    public partial class ExportUserView : Form, IExportUserView
    {
        private int _userCode;
        private ExportUserPresenter presenter;

        private BindingSource bsUR;
        private ReportDataSource rdsUR;

        public string AdminName { set => lbAdminName.Text = value; }
        public BindingList<InfoUser> UserList { set => bsUR.DataSource = value; }

        public ExportUserView(int code)
        {
            InitializeComponent();
            _userCode = code;
            bsUR = new BindingSource();
            rdsUR = new ReportDataSource();
            presenter = new ExportUserPresenter(this, code);
        }

        private void ExportUser_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            rdsUR.Value = bsUR;
            rdsUR.Name = "UsersDataset";
            reportViewer1.LocalReport.DataSources.Add(rdsUR);
            this.reportViewer1.RefreshReport();
        }

        private void linkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ListUserView screen = new ListUserView(_userCode);
            screen.FormClosed += (_, ev) => this.Close();
            screen.Show();
        }
    }
}