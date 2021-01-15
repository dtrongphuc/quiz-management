using quiz_management.Models;
using quiz_management.Views.Teacher.MockExamManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.MockExamManagement
{
    class ListMockExamPresenter
    {
        IListMockExamView view;
        int currentcode;
        BindingList<MockExam> MockExamList;

        public ListMockExamPresenter(IListMockExamView v, int code)
        {
            view = v;
            currentcode = code;
            LoadPage();
            view.GoBackBeFore += GoBackBeFore_View;
            view.UpdateExam += UpdateExam_View;
            view.DeleteExam += DeleteExam_View;
            view.CreateExam += Create_View;
        }

        

        private void LoadPage()
        {
            MockExamList = new BindingList<MockExam>();
            using (var db = new QuizDataContext())
            {
                //ten giáo viên
                view.TeacherName = db.thongTins.Where(i => i.maNguoidung == currentcode).Select(i => i.tenNguoiDung).ToList()[0];
                //dgv
                var exams = db.kyThiThus.GroupBy(x => x.maKyThiThu).Select(xs => new { ktt = xs.Select(d => d) }).ToList();
                foreach (var i in exams)
                {
                    var mockexam = new MockExam();
                    var lstlichthi = i.ktt.ToList();
                    mockexam.ExamID = lstlichthi[0].maKyThiThu.ToString();
                    mockexam.Grade = lstlichthi[0].khoiLop.tenKhoiLop;
                    mockexam.Subject = lstlichthi[0].monHoc.tenMonHoc;
                    mockexam.StartDay = lstlichthi[0].ngayThi.Value.Date.ToString("d");
                    mockexam.EndDay = lstlichthi[0].ngayKT.Value.Date.ToString("d");
                    mockexam.QuantityStudent = lstlichthi.Select(p => p.maNguoiDung).Distinct().Count();
                    mockexam.PaperID = lstlichthi[0].maBoDe;
                    MockExamList.Add(mockexam);
                }
                view.MockExamList = MockExamList;
            }
        }

        private void GoBackBeFore_View(object sender, EventArgs e)
        {
            view.ShowMainTeacherView(currentcode);
        }

        private void UpdateExam_View(object sender, EventArgs e)
        {
            view.ShowUpdateMockExamView(int.Parse(view.ExamID), currentcode);
        }

        private void DeleteExam_View(object sender, EventArgs e)
        {
            if (MockExamList.Count == 0)
                return;
            var id = view.ExamID;
            using (var db = new QuizDataContext())
            {
                var lt = db.kyThiThus.Where(p => p.maKyThiThu == int.Parse(id)).ToList();
                var itemdelete = MockExamList.Where(i => i.ExamID == id).ToList();

                for (int i = 0; i < lt.Count(); i++)
                {
                    db.kyThiThus.DeleteOnSubmit(lt[i]);

                }
                MockExamList.Remove(itemdelete[0]);
                db.SubmitChanges();
            }
           
        }
        private void Create_View(object sender, EventArgs e)
        {
            view.ShowCreateMockExamView(currentcode);
        }
    }
}
