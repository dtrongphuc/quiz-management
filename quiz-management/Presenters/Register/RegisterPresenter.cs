using quiz_management.Models;
using quiz_management.Views.Register;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Register
{
    internal class RegisterPresenter
    {
        private IRegisterView view;

        public RegisterPresenter(IRegisterView v)
        {
            view = v;
            SetClassesDataSource();
            view.Submit += View_Submit;
            view.SwitchToLoginView += View_SwitchToLoginView;
        }

        private void View_SwitchToLoginView(object sender, EventArgs e)
        {
            view.ShowLoginView();
        }

        private void View_Submit(object sender, EventArgs e)
        {
            string username = view.Username;
            string password = view.Password;
            dynamic selected = view.SelectedClass;

            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, salt.Length);
            Array.Copy(hash, 0, hashBytes, salt.Length, hash.Length);

            string pwHash = Convert.ToBase64String(hashBytes);

            using (var db = new QuizDataContext())
            {
                try
                {
                    if (db.nguoiDungs.SingleOrDefault(u => u.tenTaiKhoan == username) != null)
                    {
                        view.ShowMessage("Tên tài khoản đã tồn tại");
                        return;
                    }

                    var user = new nguoiDung
                    {
                        tenTaiKhoan = username,
                        matKhau = pwHash,
                        phanQuyen = view.isStudent ? 1 : 2,
                        TrangThai = 1
                    };

                    db.nguoiDungs.InsertOnSubmit(user);

                    db.SubmitChanges();
                    var userId = user.maNguoiDung;

                    var userInfor = new thongTin();
                    userInfor.maNguoidung = userId;
                    userInfor.tenNguoiDung = view.FullName;
                    userInfor.ngaySinh = Convert.ToDateTime(view.Birthday);
                    if (selected != null)
                        userInfor.maLopHoc = selected?.maLopHoc;

                    db.thongTins.InsertOnSubmit(userInfor);
                    db.SubmitChanges();
                    view.ShowMessage("Tạo tài khoản thành công");
                }
                catch (Exception)
                {
                    view.ShowMessage("Đã xảy ra lỗi");
                }
            }
        }

        private void SetClassesDataSource()
        {
            using (var db = new QuizDataContext())
            {
                var classes = db.Lops.Select(c => new { c.maLopHoc, c.tenLopHoc });
                if (classes != null)
                {
                    view.ComboboxDataSource = classes;
                }
            };
        }
    }
}