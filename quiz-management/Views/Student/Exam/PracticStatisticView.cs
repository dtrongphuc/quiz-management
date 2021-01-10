using Microsoft.Reporting.WinForms;
using quiz_management.Models;
using quiz_management.Presenters.Student.Exam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Student.Exam
{
    public partial class PracticStatisticView : Form
    {
        private PracticStatisticPresenter presenter;
        private BindingSource bsPR;
        private ReportDataSource rdsPR;
        private int _currentUserCode;

        public PracticStatisticView(int code)
        {
            InitializeComponent();
            _currentUserCode = code;
            bsPR = new BindingSource();
            rdsPR = new ReportDataSource();
        }

        private void PracticStatisticView_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();

            using (var db = new QuizDataContext())
            {
                var result = db.luyenTaps.Where(d => d.nguoiDung.maNguoiDung == _currentUserCode)
                                        .Select(s => new PracticStatistic
                                        {
                                            CorrectedCount = s.soCauDung,
                                            WrongCount = s.soCauSai,
                                            Total = s.soCauDung + s.soCauSai
                                        });
                bsPR.DataSource = result;
            }
            rdsPR.Value = bsPR;
            rdsPR.Name = "PracticeDataset";
            reportViewer1.LocalReport.DataSources.Add(rdsPR);
            this.reportViewer1.RefreshReport();
        }
    }
}