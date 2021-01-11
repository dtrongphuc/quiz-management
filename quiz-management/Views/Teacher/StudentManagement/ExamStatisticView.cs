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
    public partial class ExamStatisticView : Form, IExamStatisticView
    {
        private ExamStatisticPresenter presenter;
        private BindingSource bsER;
        private ReportDataSource rdsER;
        private DateTime _currentSelected;
        public List<DateTime> ExamDateTimes { set => cbDateTime.DataSource = value; }

        public ExamStatisticView()
        {
            InitializeComponent();
            bsER = new BindingSource();
            rdsER = new ReportDataSource();
            presenter = new ExamStatisticPresenter(this);
        }

        private void Form_Loaded(object sender, EventArgs e)
        {
            if (cbDateTime.Items.Count > 0)
            {
                cbDateTime.SelectedIndex = 0;
            };
        }

        public void Binding()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            using (var db = new QuizDataContext())
            {
                var result = db.ketQuas.Where(k => (k.trangThai == 1) && (k.ngayLam == _currentSelected)).ToList();
                ExamStatistic ex = new ExamStatistic
                {
                    Total = result.Count(),
                    ExamDay = _currentSelected,
                    TotalStudentAboveAverage = result.Where(r => r.diem >= 5).Count(),
                    TotalStudentBelowAverage = result.Where(r => r.diem < 5).Count(),
                    TotalMaxScore = result.Where(r => r.diem == 10).Count(),
                };

                bsER.DataSource = ex;
            }
            rdsER.Value = bsER;
            rdsER.Name = "EXDataset";
            reportViewer1.LocalReport.DataSources.Add(rdsER);
            this.reportViewer1.RefreshReport();
        }

        private void cbDateTime_Format(object sender, ListControlConvertEventArgs e)
        {
            DateTime dt = (DateTime)e.Value;
            e.Value = dt.ToString("dd/MM/yyyy");
        }

        private void cbDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb.SelectedIndex < 0 || cb.SelectedItem == null) return;

            _currentSelected = (DateTime)cb.SelectedValue;
            if (cbDateTime.Items.Count > 0 && cbDateTime.SelectedIndex >= 0)
            {
                Binding();
            };
        }
    }
}