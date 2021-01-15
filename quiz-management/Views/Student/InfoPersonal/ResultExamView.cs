using Microsoft.Reporting.WinForms;
using quiz_management.Models;
using quiz_management.Presenters.Student.InfoPersonal;
using quiz_management.Views.Student.ContribuQuestions;
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

namespace quiz_management.Views.Student.InfoPersonal
{
    public partial class ResultExamView : Form, IResultExamView
    {
        private ResultExamPresenter presenter;
        public BindingSource bsRR;
        public ReportDataSource rdsRR;
        public ResultExamUser rsUser;

        public ResultExamUser User { set => rsUser = value; }

        public ResultExamView(int code)
        {
            InitializeComponent();
            bsRR = new BindingSource();
            rdsRR = new ReportDataSource();
            presenter = new ResultExamPresenter(this, code);

            linkLabel1.Click += (_, e) =>
            {
                BackMain?.Invoke(linkLabel1, e);
            };
        }

        public List<ResultExam> ResultExam { set => bsRR.DataSource = value; }

        public event EventHandler BackMain;

        public void swichMainStudent(int code)
        {
            this.Hide();
            MainStudentView screen = new MainStudentView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        private void ResultExamView_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();

            if (rsUser != null)
            {
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                rdsRR.Value = bsRR;
                rdsRR.Name = "RSDataset";
                reportParameters.Add(new ReportParameter("Ms", rsUser.MaHocSinh.ToString()));
                reportParameters.Add(new ReportParameter("Name", rsUser.TenHocSinh));
                reportParameters.Add(new ReportParameter("Lop", rsUser.Lop));
                reportParameters.Add(new ReportParameter("NgaySinh", rsUser.NgaySinh.ToString("dd/MM/yyyy")));
                reportViewer1.LocalReport.SetParameters(reportParameters);
                reportViewer1.LocalReport.DataSources.Add(rdsRR);
            }

            this.reportViewer1.RefreshReport();
        }
    }
}