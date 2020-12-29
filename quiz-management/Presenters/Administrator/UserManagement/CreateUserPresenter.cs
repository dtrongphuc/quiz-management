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
    class CreateUserPresenter
    {
        ICreateUserView view;
        int currentuser;
        bool status = true;
        public CreateUserPresenter(ICreateUserView v, int code)
        {
            view = v;
            currentuser = code;
            LoadPage();
            view.GoBackBefore += GoBackBefore_View;
            view.CreateUser += CreateUser_View;
            view.ChangeCbbDesentralization += ChangeCbbDesentralization_view;
        }

        private void ChangeCbbDesentralization_view(object sender, EventArgs e)
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

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowMainAdmin(currentuser);
        }

        private void CreateUser_View(object sender, EventArgs e)
        {
            string username = view.UserName;
            string password = view.Pass;
            //dynamic selected = view.SelectedClass;

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
                        view.ShowMessages("Tên tài khoản đã tồn tại");
                        return;
                    }

                    var user = new nguoiDung
                    {
                        tenTaiKhoan = username,
                        matKhau = pwHash,
                        phanQuyen = view.Desentralization == "Học Sinh" ? 1 : 0,
                        TrangThai = 1
                    };
                    db.nguoiDungs.InsertOnSubmit(user);
                    db.SubmitChanges();

                    //tạo thông tin
                    var userId = user.maNguoiDung;
                    thongTin userInfor = null;
                    if (status == false)
                    {
                        userInfor = new thongTin
                        {
                            maNguoidung = userId,
                            tenNguoiDung = view.AcountName,
                            ngaySinh = view.DOB
                        };
                    }
                    else
                    {
                        userInfor = new thongTin
                        {
                            maNguoidung = userId,
                            tenNguoiDung = view.AcountName,
                            ngaySinh = view.DOB,
                            maLopHoc = int.Parse(view.classID)
                        };
                    }
                    db.thongTins.InsertOnSubmit(userInfor);
                    db.SubmitChanges();

                    view.ShowMessages("Tạo tài khoản thành công");
                }
                catch (Exception)
                {
                    view.ShowMessages("Đã xảy ra lỗi");
                }

            }
        }

        private void LoadPage()
        {
            using (var db = new QuizDataContext())
            {
                view.AdminName = db.thongTins.Where(i => i.maNguoidung == currentuser).Select(i => i.tenNguoiDung).ToList()[0];
                view.Datenow = DateTime.Now.Date.ToString("d");
                //lop hoc
                view.ClassList = db.Lops.ToList();
            }
        }
    }
}
