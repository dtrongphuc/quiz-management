using quiz_management.Models;
using quiz_management.Views.Administrator.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Administrator.UserManagement
{
    class UpdateUserPresenter
    {
        IUpdateUserView view;
        int currentcode = 0;
        int userid = 0;
        bool status;
        public UpdateUserPresenter(IUpdateUserView v, int code, int userid)
        {
            view = v;
            this.currentcode = code;
            this.userid = userid;
            LoadPage();
            view.GoBackBefore += GoBackBefore_View;
            view.SaveUpdate += SaveUpdate_View;
            view.ChangeCbbDesentralization += ChangeCbbDesentralization_Change;
        }

        private void ChangeCbbDesentralization_Change(object sender, EventArgs e)
        {
            if (view.Desentralization == "Giáo Viên")
            {
                view.cbbAllClass = false;
                status = false;
            }
            else
            {
                view.cbbAllClass = true;
                status = true;
            }
        }

        private void SaveUpdate_View(object sender, EventArgs e)
        {
            using (var db = new QuizDataContext())
            {
                var user = db.thongTins.Single(i => i.maNguoidung == userid);
                user.tenNguoiDung = view.UserName;
                user.ngaySinh = view.DOB;
                if (status == true)
                {
                    user.maLopHoc = int.Parse(view.classselected);
                }
                db.SubmitChanges();
                view.ShowMessages("Cập nhật thành công");
                view.ShowListUser(currentcode);
            }
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowListUser(currentcode);
        }

        private void LoadPage()
        {
            using (var db = new QuizDataContext())
            {
                view.AdminName = db.thongTins.Where(i => i.maNguoidung == currentcode).Select(i => i.tenNguoiDung).ToList()[0];
                view.Datenow = DateTime.Now.Date.ToString("d");
                
                //người dùng
                var user = db.nguoiDungs.Where(i => i.maNguoiDung == userid).ToList();
                view.AcountName = user[0].tenTaiKhoan;
                view.UserName = user[0].thongTin.tenNguoiDung;
                view.DOB = user[0].thongTin.ngaySinh.Value;
                //lop hoc
                view.ClassList = db.Lops.ToList();
                if (db.nguoiDungs.Where(i => i.maNguoiDung == userid).Select(i => i.phanQuyen).ToList()[0] == 2)
                {
                    view.cbbAllClass = false;
                }
                else
                    view.classselected = db.Lops.Where(i => i.maLopHoc == user[0].thongTin.maLopHoc.Value).Select(i => i.tenLopHoc).ToList()[0].ToString();
            }
        }
    }
}
