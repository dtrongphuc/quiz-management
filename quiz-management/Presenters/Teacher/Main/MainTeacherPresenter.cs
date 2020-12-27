using quiz_management.Models;
using quiz_management.Views.Teacher.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.Main
{
    class MainTeacherPresenter
    {
        IMainTeacherView view;
        int currentUser;
        public MainTeacherPresenter(IMainTeacherView v, int code)
        {
            view = v;
            currentUser = code;
            LoadPage();
            view.UpdateInfo += UpdateInfo_View;
            view.CreateQuestion += CreateQuestion_View;
            view.QuestionApproval += QuestionApproval_View;
        }

        private void QuestionApproval_View(object sender, EventArgs e)
        {
            view.ShowQuestionApproval(currentUser);
        }

        private void CreateQuestion_View(object sender, EventArgs e)
        {
            view.ShowCreateQuestion(currentUser);
        }

        private void UpdateInfo_View(object sender, EventArgs e)
        {
            view.ShowUpdateInfo(currentUser);
        }

        private void LoadPage()
        {
            using(var db = new QuizDataContext())
            {
                var user = db.thongTins.Where(i => i.maNguoidung == currentUser).ToList()[0];
                view.TeacherName = user.tenNguoiDung;
                view.TeacherID = currentUser.ToString();
                view.DOB = user.ngaySinh.ToString();
            }
        }
    }
}
