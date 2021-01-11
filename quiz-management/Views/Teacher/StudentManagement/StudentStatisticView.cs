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
    public partial class StudentStatisticView : Form
    {
        //private StudentStatisticPresenter presenter;
        private BindingSource bsSR;

        private ReportDataSource rdsSR;
        //public List<DateTime> ExamDateTimes { set => cbDateTime.DataSource = value; }

        //public List<StudentStatistic> StatisticData
        //{
        //    set
        //    {
        //        dgvHS.DataSource = null;
        //        dgvHS.DataSource = value;
        //    }
        //}

        //public event EventHandler DateTimeChanged;

        //public event EventHandler SearchTextChanged;

        public StudentStatisticView()
        {
            InitializeComponent();
            bsSR = new BindingSource();
            rdsSR = new ReportDataSource();
            //presenter = new StudentStatisticPresenter(this);
            //InitialControl();
        }

        //public void InitialControl()
        //{
        //    dgvHS.AutoGenerateColumns = false;
        //    cbDateTime.SelectedIndex = -1;

        //    cbDateTime.SelectedIndexChanged += (_, e) =>
        //    {
        //        DateTimeChanged.Invoke(cbDateTime, e);
        //    };

        //    tbSearch.TextChanged += (_, e) =>
        //    {
        //        SearchTextChanged.Invoke(tbSearch, e);
        //    };
        //}

        private void Form_Loaded(object sender, EventArgs e)
        {
            //cbDateTime.SelectedIndex = -1;
            reportViewer1.LocalReport.DataSources.Clear();

            using (var db = new QuizDataContext())
            {
                var result = db.ketQuas.Where(s => (s.trangThai == 1))
                                        .Select(s => new
                                        {
                                            MaHocSinh = s.nguoiDung.thongTin.maNguoidung.ToString(),
                                            TenHocSinh = s.nguoiDung.thongTin.tenNguoiDung,
                                            NgaySinh = s.nguoiDung.thongTin.ngaySinh.ToString(),
                                            Lop = s.nguoiDung.thongTin.Lop.tenLopHoc,
                                            MonHoc = s.boDe.monHoc.tenMonHoc.ToString(),
                                            Diem = s.diem
                                        }).ToList();
                bsSR.DataSource = result;
            }
            rdsSR.Value = bsSR;
            rdsSR.Name = "tbStudentStatistic";
            reportViewer1.LocalReport.DataSources.Add(rdsSR);
            this.reportViewer1.RefreshReport();
        }

        private void cbDateTime_Format(object sender, ListControlConvertEventArgs e)
        {
            DateTime dt = (DateTime)e.Value;
            e.Value = dt.ToString("MM/dd/yyyy");
        }
    }
}