using quiz_management.Models;
using quiz_management.Views.Teacher.QuestionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.QuestionManagement
{
    class QuestionListPresenter
    {
        IQuestionListView view;
        int currenUser;
        BindingList<QuestionCreated> questionbinding = null;
        public QuestionListPresenter(IQuestionListView v, int code)
        {
            view = v;
            currenUser = code;
            LoadPage(code);
            view.ShowUpdate += ShowUpdate_View;
            view.GoBackBefore += GoBackBefore_View;
            view.SelectedCBB += SelectedCBB_View;
        }

        private void ShowUpdate_View(object sender, EventArgs e)
        {
            view.ShowUpdateQuestion(currenUser, int.Parse(view.QuestionId));
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowCreateQuestion(currenUser);
        }

        private void SelectedCBB_View(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void LoadDGV()
        {
            questionbinding = new BindingList<QuestionCreated>();
            List<cauHoi> questions = null;
            using (var db = new QuizDataContext())
            {
                questions = db.cauHois.Where(i => i.maKhoiLop == view.GradeId && i.maMonHoc == int.Parse(view.SubjectId)).ToList();
                foreach (var question in questions)
                {
                    QuestionCreated q = new QuestionCreated();
                    q.Question = question.cauHoi1;
                    q.PaperName = "12";
                    questionbinding.Add(q);
                }
                view.QuestionList = questionbinding;
            }
        }

        private void LoadPage(int code)
        {
            using (var db = new QuizDataContext())
            {
                //ten gv
                view.TeacherName = db.thongTins.Where(i => i.maNguoidung == 1).Select(i => i.tenNguoiDung).ToList()[0].ToString();
                //monhoc
                view.GradeList = db.khoiLops.ToList();
                //monhoc
                view.SubjectList = db.monHocs.ToList();

                LoadDGV();
            }
        }
    }
}
