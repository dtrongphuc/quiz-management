using quiz_management.Models;
using quiz_management.Views.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Register
{
    class RegisterPresenter
    {
        IRegisterView view;

        public RegisterPresenter(IRegisterView v)
        {
            view = v;
            view.Submit += View_Submit;
        }

        private void View_Submit(object sender, EventArgs e)
        {
            string username = view.Username;
            string password = view.Password;

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
                if (db.nguoiDungs.SingleOrDefault(u => u.tenTaiKhoan == username) != null)
                {
                    view.ShowMessage("Tên tài khoản đã tồn tại");
                    return;
                }

                var user = new nguoiDung
                {
                    tenTaiKhoan = username,
                    matKhau = pwHash,
                    phanQuyen = 0,
                    TrangThai = 1
                };

                db.nguoiDungs.InsertOnSubmit(user);

                db.SubmitChanges();
                var userId = user.maNguoiDung;

                db.thongTins.InsertOnSubmit(new thongTin
                {
                    maNguoidung = userId,
                    tenNguoiDung = view.FullName,
                    ngaySinh = DateTime.ParseExact(view.Birthday, "dd/MM/yyyy", null)
                });
                db.SubmitChanges();
            }
        }
    }
}
