using quiz_management.Models;
using quiz_management.Views.Teacher.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.StudentManagement
{
    internal class StudentStatisticPresenter
    {
        private IStudentStatisticView view;
        public DateTime CurrentSelected;
        public List<StudentStatistic> ListBinding = new List<StudentStatistic>();

        public StudentStatisticPresenter(IStudentStatisticView v)
        {
            view = v;
            GetData();
            HandleEvent();
        }

        public void HandleEvent()
        {
            view.DateTimeChanged += View_DateTimeChanged;
            view.SearchTextChanged += View_SearchTextChanged;
        }

        private void View_SearchTextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb.Text != string.Empty)
            {
                BindingWithDateSelected(CurrentSelected, tb.Text);
                return;
            }

            BindingWithDateSelected(CurrentSelected, string.Empty);
        }

        private void View_DateTimeChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb.SelectedIndex < 0 || cb.SelectedItem == null) return;

            CurrentSelected = (DateTime)cb.SelectedValue;
            BindingWithDateSelected(CurrentSelected, string.Empty);
        }

        // Call Models
        public void GetData()
        {
            using (var db = new QuizDataContext())
            {
                GetExamDateTime(db);
            }
        }

        public void GetExamDateTime(QuizDataContext db)
        {
            var result = db.lichThis.Select(s => s.ngayThi).ToList();
            view.ExamDateTimes = result;
        }

        public void BindingWithDateSelected(DateTime dt, string searchName)
        {
            using (var db = new QuizDataContext())
            {
                //GetCourses(db, dt);
                var result = db.ketQuas.Where(s => (s.ngayLam == dt) && (s.trangThai == 1)
                && ((searchName != string.Empty ? (s.nguoiDung.thongTin.tenNguoiDung.IndexOf(searchName) >= 0) : true)))
                                        .Select(s => new
                                        {
                                            MaHocSinh = s.nguoiDung.thongTin.maNguoidung.ToString(),
                                            TenHocSinh = s.nguoiDung.thongTin.tenNguoiDung,
                                            NgaySinh = s.nguoiDung.thongTin.ngaySinh.ToString(),
                                            Lop = s.nguoiDung.thongTin.Lop.tenLopHoc,
                                            MonHoc = s.boDe.monHoc.tenMonHoc.ToString(),
                                            Diem = s.diem
                                        }).ToList();
                ListBinding.Clear();
                foreach (var row in result)
                {
                    StudentStatistic temp = new StudentStatistic
                    {
                        MaHocSinh = row.MaHocSinh,
                        TenHocSinh = row.TenHocSinh,
                        NgaySinh = row.NgaySinh,
                        MonHoc = row.MonHoc,
                        Diem = (double)row.Diem,
                        Lop = row.Lop
                    };

                    ListBinding.Add(temp);
                }
                view.StatisticData = ListBinding;
            }
        }

        //public void GetCourses(QuizDataContext db, DateTime dt)
        //{
        //    List<monHoc> result = db.lichThis.Where(l => l.ngayThi == dt)
        //            .Join(db.boDes,
        //                l => l.maBoDe,
        //                b => b.maBoDe,
        //                (l, b) => b.monHoc
        //            ).ToList();
        //    view.Courses = result;
        //}
    }
}