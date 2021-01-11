using Microsoft.Reporting.WinForms;
using quiz_management.Models;
using quiz_management.Presenters.Teacher.ExamManagement;
using quiz_management.Views.Teacher.Main;
using quiz_management.Views.Teacher.MockExamManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.ExamManagement
{
    public partial class WatchOrPrintExamView : Form, IWatchOrPrintExamView
    {
        private WatchOrPrintExamPresenter presenter;
        public BindingSource bsWOPR;
        public ReportDataSource rdsWOPR;

        public WatchOrPrintExamView(int code)
        {
            InitializeComponent();
            bsWOPR = new BindingSource();
            rdsWOPR = new ReportDataSource();
            presenter = new WatchOrPrintExamPresenter(this, code);
            linkGoBackBefore.Click += (_, e) =>
            {
                GobackBefore?.Invoke(linkGoBackBefore, e);
            };
        }

        public string TeacherName { set => lbTeacher.Text = value; }
        public List<StudentOfExam> ExamList { set => bsWOPR.DataSource = value; }

        public event EventHandler GobackBefore;

        public event EventHandler Print;

        public void Message(string text)
        {
            MessageBox.Show(text);
        }

        public void ShowMainTeacher(int code)
        {
            this.Hide();
            MainTeacherView screen = new MainTeacherView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        private void WatchOrPrintExamView_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            rdsWOPR.Value = bsWOPR;
            rdsWOPR.Name = "MSEDataset";
            reportViewer1.LocalReport.DataSources.Add(rdsWOPR);
            this.reportViewer1.RefreshReport();
        }
    }
}