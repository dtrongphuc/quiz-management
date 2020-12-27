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
        string gradeId;
        int subjectId;
        BindingList<QuestionCreated> questionbinding = null;
        public QuestionListPresenter(IQuestionListView v, int code, string gradeID, int subjectID)
        {
            view = v;
            currenUser = code;
            gradeId = gradeID;
            subjectId = subjectID;
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
                    var paperid = question.cTBoDes.Where(i => i.maCauHoi == question.maCauHoi).Select(i => i.maBoDe).ToList();
                    //liệt kê các đề có câu hỏi đang xét
                    string paperids = "";
                    for (var i = 0; i < paperid.Count(); i++)
                    {
                        if (i == 0)
                            paperids += paperid[i].ToString();
                        else
                            paperids += ", " + paperid[i].ToString();
                    }

                    QuestionCreated q = new QuestionCreated();
                    q.Question = question.cauHoi1;
                    q.PaperName = paperid.Count() > 0 ? paperids : "Chưa có trong đề thi";
                    q.QuestionID = question.maCauHoi.ToString();

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

                if (gradeId != "")
                    view.GradeSelected = db.khoiLops.Where(i => i.maKhoiLop == gradeId.ToString()).Select(i => i.tenKhoiLop).ToList()[0].ToString();
                if (subjectId > 0)
                    view.SubjectSelected = db.monHocs.Where(i => i.maMonHoc == subjectId).Select(i => i.tenMonHoc).ToList()[0].ToString();
                LoadDGV();
            }
        }
    }
}
