using quiz_management.Models;
using quiz_management.Views.Teacher.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.Main
{
    internal class MainTeacherPresenter
    {
        private IMainTeacherView view;
        private int currentUser;

        public MainTeacherPresenter(IMainTeacherView v, int code)
        {
            view = v;
            currentUser = code;
            LoadPage();
            view.UpdateInfo += UpdateInfo_View;
            view.CreateQuestion += CreateQuestion_View;
            view.QuestionApproval += QuestionApproval_View;
            view.OfficialExamClick += View_OfficialExamClick;
            view.PracticExamClick += View_PracticExamClick;
            view.ExamListClick += View_ExmaListClick;
            view.WatchOrPrintExamCompletedClick += View_WatchOrPrintExamCompletedClick;
            view.ListMockExamClick += View_ListMockExamClick;
            view.WatchOrPrintExamClick += View_WatchOrPrintClick;
        }

        private void View_WatchOrPrintClick(object sender, EventArgs e)
        {
            view.ShowWatchOrPrintExamView(currentUser);
        }

        private void View_ListMockExamClick(object sender, EventArgs e)
        {
            view.ShowListMockExamView(currentUser);
        }

        private void View_WatchOrPrintExamCompletedClick(object sender, EventArgs e)
        {
            view.ShowWatchOrPrintExamCompletedView(currentUser);
        }

        private void View_ExmaListClick(object sender, EventArgs e)
        {
            view.ShowExamListView(currentUser);
        }

        private void View_PracticExamClick(object sender, EventArgs e)
        {
            using (var db = new QuizDataContext())
            {
                var lt = db.kyThiThus.Where(l => (l.ngayThi == DateTime.Now) && (l.maNguoiDung == currentUser))
                                    .Select(s => s.maBoDe);
                if (!lt.Any())
                {
                    MessageBox.Show("Bạn không có lịch thi thử hôm nay");
                    return;
                }
            }
            view.ShowPracticExamView(currentUser);
        }

        private void View_OfficialExamClick(object sender, EventArgs e)
        {
            using (var db = new QuizDataContext())
            {
                var lt = db.lichThis.Where(l => (l.ngayThi == DateTime.Now) && (l.maNguoiDung == currentUser))
                                    .Select(s => s.maBoDe);
                if (!lt.Any())
                {
                    MessageBox.Show("Bạn không có lịch thi hôm nay");
                    return;
                }
            }
            view.ShowOfficialExamView(currentUser);
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
            using (var db = new QuizDataContext())
            {
                var user = db.thongTins.Where(i => i.maNguoidung == currentUser).ToList()[0];
                view.TeacherName = user.tenNguoiDung;
                view.TeacherID = currentUser.ToString();
                view.DOB = user.ngaySinh.Value.Date.ToString("d");
            }
        }
    }
}