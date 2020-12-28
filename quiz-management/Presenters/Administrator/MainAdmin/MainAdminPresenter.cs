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
            view.AddUser += UpdateUser_View;
            view.WatchUserList += WatchUserList_View;
            view.Desentralization += Desentralization_View;
        }

        private void Desentralization_View(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void WatchUserList_View(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateUser_View(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
