using quiz_management.Models;
using quiz_management.Views.Student.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.Exam
{
    class OfficialExamPresenter
    {
        IOfficialExamView view;
        private int currentUserCode;

        public OfficialExamPresenter(IOfficialExamView v, int userCode)
        {
            view = v;
            currentUserCode = userCode;

            GetData();

        }

        private void GetData()
        {
            using(var db = new QuizDataContext())
            {
                // Fetch user data
                var user = db.nguoiDungs.SingleOrDefault(u => u.maNguoiDung == currentUserCode);
                string name = user.thongTin.tenNguoiDung as string;
                string className = db.Lops.SingleOrDefault(l => l.maLopHoc == user.thongTin.maLopHoc).tenLopHoc as string;
                // Set user data
                SetUserDataView(name, className);

                // Fetch exam data
                var exam = db.boDes.SingleOrDefault(d => d.maBoDe == 1);
                SetExamDataView(exam);
            };
        }

        private void SetUserDataView(string name, string className)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(className)) return;
            view.StudentName = name;
            view.StudentClass = className;
        }

        private void SetExamDataView(boDe exam)
        {
            if (exam == null) return;
            view.ExamTime = (int)exam.thoiGian;
            view.ExamCode = exam.maBoDe.ToString();
        }
    }
}
