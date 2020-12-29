﻿using quiz_management.Models;
using quiz_management.Views.Administrator.UserManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Administrator.UserManagement
{
    class ListUserPresenter
    {
        IListUserView view;
        int currentuser = 0;
        BindingList<InfoUser> infoUsers = null;
        public ListUserPresenter(IListUserView v, int code)
        {
            view = v;
            currentuser = code;
            LoadPage();
            view.GoBackBefore += GoBackBefore_View;
            view.UpdateUser += UpdateUser_View;
        }

        private void LoadPage()
        {
            infoUsers = new BindingList<InfoUser>();
            using (var db = new QuizDataContext())
            {
                view.AdminName = db.thongTins.Where(i => i.maNguoidung == currentuser).Select(i => i.tenNguoiDung).ToList()[0];
                view.Datenow = DateTime.Now.Date.ToString("d");

                //binding dgv
                var users = db.thongTins.ToList();
                int stt = 1;
                foreach(var user in users)
                {
                    InfoUser info = new InfoUser();
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

        private void UpdateUser_View(object sender, EventArgs e)
        {
            view.ShowUpdate(currentuser);
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowMainAdmin(currentuser);
        }
    }
}
