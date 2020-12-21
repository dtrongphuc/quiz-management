using quiz_management.Models;
using quiz_management.Views.Student.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.Exam
{
    internal class PracticStatisticPresenter
    {
        private IPracticStatistic view;
        private int currentUserCode;

        public PracticStatisticPresenter(IPracticStatistic v, int code)
        {
            view = v;
            currentUserCode = code;
            SetUserDataView();
            Init();
        }

        public void Init()
        {
            using (var db = new QuizDataContext())
            {
                var result = db.luyenTaps.FirstOrDefault(d => d.nguoiDung.maNguoiDung == currentUserCode);
                view.Total = 0;
                view.CorrectedCount = 0;
                view.WrongCount = 0;

                if (result == null) return;
                view.Total = result.soCauDung + result.soCauSai;
                view.CorrectedCount = result.soCauDung;
                view.WrongCount = result.soCauSai;
            }
        }

        private void SetUserDataView()
        {
            using (var db = new QuizDataContext())
            {
                // Fetch user data
                var user = db.nguoiDungs.SingleOrDefault(u => u.maNguoiDung == currentUserCode);
                string name = user.thongTin.tenNguoiDung as string;
                string className = db.Lops.SingleOrDefault(l => l.maLopHoc == user.thongTin.maLopHoc).tenLopHoc as string;
                // Set user data
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(className)) return;
                view.StudentName = name;
                view.StudentClass = className;
            }
        }
    }
}