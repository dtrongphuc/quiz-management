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
        }

        private void View_DateTimeChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb.SelectedIndex < 0 || cb.SelectedItem == null) return;

            var selected = (DateTime)cb.SelectedValue;
            BindingWithDateSelected(selected);
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

        public void BindingWithDateSelected(DateTime dt)
        {
            using (var db = new QuizDataContext())
            {
                GetCourses(db, dt);
                var result = db.ketQuas.Where(s => (s.ngayLam == dt) && (s.trangThai == 1))
                                        .Select(s => new
                                        {
                                            HocSinh = s.nguoiDung.thongTin,
                                            MonHoc = s.boDe.monHoc,
                                            Diem = s.diem,
                                            Lop = s.nguoiDung.thongTin.Lop.tenLopHoc
                                        }).ToList();
                ListBinding.Clear();
                foreach (var row in result)
                {
                    StudentStatistic temp = new StudentStatistic
                    {
                        HocSinh = row.HocSinh,
                        MonHoc = row.MonHoc,
                        Diem = (Double)row.Diem,
                        Lop = row.Lop
                    };

                    ListBinding.Add(temp);
                }
            }
        }

        public void GetCourses(QuizDataContext db, DateTime dt)
        {
            List<monHoc> result = db.lichThis.Where(l => l.ngayThi == dt)
                    .Join(db.boDes,
                        l => l.maBoDe,
                        b => b.maBoDe,
                        (l, b) => b.monHoc
                    ).ToList();
        }
    }
}