using Microsoft.Reporting.WinForms;
using quiz_management.Models;
using quiz_management.Presenters.Teacher.StudentManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.StudentManagement
{
    public partial class QuestionStatisticView : Form, IQuestionStatisticView
    {
        private QuestionStatisticPresenter presenter;
        private BindingSource bsQR;
        private ReportDataSource rdsQR;
        public List<QuestionStatistic> StatisticData { set => bsQR.DataSource = value; }

        public QuestionStatisticView()
        {
            InitializeComponent();
            bsQR = new BindingSource();
            rdsQR = new ReportDataSource();
            presenter = new QuestionStatisticPresenter(this);
        }

        private void QuestionStatisticView_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            rdsQR.Value = bsQR;
            rdsQR.Name = "QSDataset";
            reportViewer1.LocalReport.DataSources.Add(rdsQR);
            this.reportViewer1.RefreshReport();
        }
    }
}