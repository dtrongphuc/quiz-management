using quiz_management.Models;
using quiz_management.Views.Administrator.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Administrator.UserManagement
{
    internal class ImportUsersPresenter
    {
        private IImportUsersView view;

        public ImportUsersPresenter(IImportUsersView v)
        {
            view = v;
            view.Import += View_Import;
        }

        private void View_Import(object sender, EventArgs e)
        {
            try
            {
                List<User> users = view.ListUsers;
                if (users != null)
                {
                    using (var db = new QuizDataContext())
                    {
                        foreach (User user in users)
                        {
                            var check = db.nguoiDungs.Where(n => n.tenTaiKhoan == user.TenTaiKhoan);
                            if (check.Any())
                            {
                                MessageBox.Show("Tên tài khoản trùng!", "Message");
                                return;
                            }

                            var nd = new nguoiDung
                            {
                                tenTaiKhoan = user.TenTaiKhoan,
                                matKhau = HashPassword(user.MatKhau),
                                phanQuyen = user.PhanQuyen == "Quản trị" ? 0 : user.PhanQuyen == "Giáo viên" ? 2 : 1,
                                TrangThai = user.TrangThai == "Hoạt động" ? 1 : 0,
                            };

                            db.nguoiDungs.InsertOnSubmit(nd);

                            db.SubmitChanges();

                            db.thongTins.InsertOnSubmit(new thongTin
                            {
                                maNguoidung = nd.maNguoiDung,
                                tenNguoiDung = user.TenNguoiDung,
                                ngaySinh = user.NgaySinh,
                                maLopHoc = user.MaLopHoc
                            });
                            db.SubmitChanges();
                        }
                    }
                    MessageBox.Show("Thêm dữ liệu thành công!", "Message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        public string HashPassword(string pw)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(pw, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, salt.Length);
            Array.Copy(hash, 0, hashBytes, salt.Length, hash.Length);

            string pwHash = Convert.ToBase64String(hashBytes);
            return pwHash;
        }
    }
}