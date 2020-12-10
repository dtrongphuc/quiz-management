using quiz_management.Models;
using quiz_management.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Login
{
    class LoginPresenter
    {
        ILoginView view;

        public LoginPresenter(ILoginView v)
        {
            view = v;
            view.Submit += View_Submit;
            view.SwitchToRegisterView += View_SwitchToRegisterView;
        }

        private void View_SwitchToRegisterView(object sender, EventArgs e)
        {
            view.ShowRegisterView();
        }

        private void View_Submit(object sender, EventArgs e)
        {
            string username = view.Username;
            string password = view.Password;

            using (var db = new QuizDataContext())
            {
                var user = db.nguoiDungs.SingleOrDefault(u => u.tenTaiKhoan == username);
                if (user != null)
                {
                    byte[] hashBytes = Convert.FromBase64String(user.matKhau);
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, salt.Length);
                    var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                    byte[] hash = pbkdf2.GetBytes(20);
                    for (int i = 0; i < 20; i++)
                    {
                        if (hashBytes[i + 16] != hash[i])
                        {
                            view.ShowMessage("Mật khẩu không chính xác");
                            return;
                        }
                    }
                    int role = user.phanQuyen.GetValueOrDefault();
                    int userCode = user.maNguoiDung;
                    RoleToView(userCode, role);
                }
                else
                {
                    view.ShowMessage("Không tồn tại tài khoản");
                }
            }
        }

        private void RoleToView(int userCode, int role)
        {

            switch (role)
            {
                case 1:
                    view.ShowStudentView(userCode);
                    break;
                case 2:
                    view.ShowTeacherView(userCode);
                    break;
                case 3:
                    view.ShowAdminView(userCode);
                    break;
                default:
                    view.ShowMessage("Không xác định được quyền hạn của tài khoản");
                    break;
            }
        }
    }
}
