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
    internal class ExamStatisticPresenter
    {
        private IExamStatisticView view;
        public DateTime CurrentSelected;

        public ExamStatisticPresenter(IExamStatisticView v)
        {
            view = v;
            GetExamDateTime();
            view.DateTimeChanged += View_DateTimeChanged;
        }

        private void View_DateTimeChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb.SelectedIndex < 0 || cb.SelectedItem == null) return;

            CurrentSelected = (DateTime)cb.SelectedValue;
            CalcData(CurrentSelected);
        }

        public void CalcData(DateTime dt)
        {
            if (dt == null) return;
            using (var db = new QuizDataContext())
            {
                var result = db.ketQuas.Where(k => (k.ngayLam == dt) && (k.trangThai == 1)).ToList();
                view.TotalStudent = result.Count();
                view.TotalStudentAboveAverage = result.Where(r => r.diem >= 5).Count();
                view.TotalStudentBelowAverage = result.Where(r => r.diem < 5).Count();
                view.TotalMaxScoring = result.Where(r => r.diem == 10).Count();
            }
        }

        public void GetExamDateTime()
        {
            using (var db = new QuizDataContext())
            {
                var result = db.lichThis.Select(s => s.ngayThi).ToList();
                view.ExamDateTimes = result;
            }
        }
    }
}