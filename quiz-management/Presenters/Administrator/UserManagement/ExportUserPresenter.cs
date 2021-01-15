using quiz_management.Models;
using quiz_management.Views.Administrator.UserManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Administrator.UserManagement
{
    internal class ExportUserPresenter
    {
        private IExportUserView view;
        private int currentuser = 0;
        private BindingList<InfoUser> infoUsers = null;

        public ExportUserPresenter(IExportUserView v, int code)
        {
            view = v;
            currentuser = code;
            LoadPage();
        }

        private void LoadPage()
        {
            infoUsers = new BindingList<InfoUser>();
            using (var db = new QuizDataContext())
            {
                view.AdminName = db.thongTins.Where(i => i.maNguoidung == currentuser).Select(i => i.tenNguoiDung).ToList()[0];

                //binding dgv
                var users = db.thongTins.ToList();
                int stt = 1;
                foreach (var user in users)
                {
                    InfoUser info = new InfoUser();
                    info.UserID = user.maNguoidung;
                    info.STT = stt.ToString();
                    info.UserName = user.tenNguoiDung;
                    info.DOB = user.ngaySinh.Value;
                    info.Desentralization = user.nguoiDung.phanQuyen == 1 ? "Học Sinh" : "Giáo Viên";

                    infoUsers.Add(info);
                    stt++;
                }
                view.UserList = infoUsers;
            }
        }
    }
}