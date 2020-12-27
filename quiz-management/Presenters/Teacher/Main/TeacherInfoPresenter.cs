using quiz_management.Models;
using quiz_management.Views.Teacher.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.Main
{
    class TeacherInfoPresenter
    {
        ITeacherInfoView view;
        int currentUser = 0;
        public TeacherInfoPresenter(ITeacherInfoView v, int code)
        {
            view = v;
            currentUser = code;
            LoadPage();
            view.UpdateInfo += UpdateInfo_View;
            view.ClosePage += ClosePage_View;
        }

        private void UpdateInfo_View(object sender, EventArgs e)
        {
            using (var db = new QuizDataContext())
            {
                var user = db.thongTins.Single(i => i.maNguoidung == currentUser);
                user.tenNguoiDung = view.TeacherName;
                user.ngaySinh = DateTime.Parse(view.DOB);
                db.SubmitChanges();

                view.ShowMessage("Cập nhật thành công");
                view.ShowMainTeacher(currentUser);
            }
        }

        private void ClosePage_View(object sender, EventArgs e)
        {
            view.ShowMainTeacher(currentUser);
        }

        private void LoadPage()
        {
            using (var db = new QuizDataContext())
            {
                var user = db.thongTins.Where(i => i.maNguoidung == currentUser).ToList()[0];
                view.TeacherName = user.tenNguoiDung;
                view.TeacherID = currentUser.ToString();
                view.DOB = user.ngaySinh.Value.Date.ToString("d");
            }
        }
    }
}
