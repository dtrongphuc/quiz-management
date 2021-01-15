using Microsoft.Reporting.WinForms;
using quiz_management.Models;
using quiz_management.Views.Teacher.ExamManagement;
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

namespace quiz_management.Presenters.Teacher.ExamManagement
{
    public partial class WatchOrPrintExamCompletedView : Form, IWatchOrPrintExamCompletedView
    {
        private WatchOrPrintExamCompletedPresenter presenter;
        public BindingSource bsWOPEC;
        public ReportDataSource rdsWOPEC;

        public WatchOrPrintExamCompletedView(int code)
        {
            InitializeComponent();
            bsWOPEC = new BindingSource();
            rdsWOPEC = new ReportDataSource();
            presenter = new WatchOrPrintExamCompletedPresenter(this, code);
            linkGoBackBefore.Click += (_, e) =>
            {
                GobackBefore?.Invoke(linkGoBackBefore, e);
            };
        }

        public BindingList<TrainScript> ExamList { set => bsWOPEC.DataSource = value; }

        public event EventHandler GobackBefore;

        public void Home(int code)
        {
            this.Hide();
            MainTeacherView screen = new MainTeacherView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void Message(string text)
        {
            MessageBox.Show(text);
        }

        private void WatchOrPrintExamCompletedView_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            rdsWOPEC.Value = bsWOPEC;
            rdsWOPEC.Name = "MSECDataset";
            reportViewer1.LocalReport.DataSources.Add(rdsWOPEC);
            this.reportViewer1.RefreshReport();
        }
    }
}