using quiz_management.Models;
using quiz_management.Views.Administrator.MainAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Administrator.MainAdmin
{
    class MainAdminPresenter
    {
        IMainAdminView view;
        int currentCode;
        public MainAdminPresenter(IMainAdminView v, int code)
        {
            view = v;
            currentCode = code;
            LoadPage();
            view.AddUser += AddUser_View;
            view.WatchUserList += WatchUserList_View;
            view.Desentralization += Desentralization_View;
        }

        private void Desentralization_View(object sender, EventArgs e)
        {
            view.ShowDesentralization(currentCode);
        }

        private void WatchUserList_View(object sender, EventArgs e)
        {
            view.ShowWatchUserList(currentCode);
        }

        private void AddUser_View(object sender, EventArgs e)
        {
            view.ShowAddUser(currentCode);
        }

        private void LoadPage()
        {
            using (var db = new QuizDataContext())
            {
                view.AdminName = db.thongTins.Where(i => i.maNguoidung == currentCode).Select(i => i.tenNguoiDung).ToList()[0];
                view.DOB = DateTime.Now.Date.ToString("d");
            }
        }
    }
}
