using quiz_management.Models;
using quiz_management.Views.Teacher.MockExamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.MockExamManagement
{
    class ListMockExamPresenter
    {
        IListMockExamView view;
        int currentcode;
        List<MockExam> MockExamList;
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
            MockExamList = new List<MockExam>();
            using (var db = new QuizDataContext())
            {
                //ten giáo viên
                view.TeacherName = db.thongTins.Where(i => i.maNguoidung == currentcode).Select(i => i.tenNguoiDung).ToList()[0];
                //dgv
                var exams = db.kyThiThus.ToList();
                int stt = 1;
                foreach(var exam in exams)
                {
                    var mockexam = new MockExam();
                    mockexam.STT = stt;
                    mockexam.ExamID = exam.maKyThiThu.ToString();
                    mockexam.Grade = exam.khoiLop.tenKhoiLop;
                    mockexam.Subject = exam.monHoc.tenMonHoc;
                    mockexam.StartDay = exam.ngayThi.Value.Date.ToString("d");
                    mockexam.EndDay = exam.ngayKT.Value.Date.ToString("d");
                    mockexam.UserID = exam.maNguoiDung;
                    mockexam.PaperID = exam.maBoDe;
                    mockexam.QuantityStudent = db.kyThiThus.Where(i => i.maKyThiThu == exam.maKyThiThu).Select(i =>i.maNguoiDung).Count();

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
            using(var db = new QuizDataContext())
            {
                kyThiThu exammock = db.kyThiThus.SingleOrDefault(i => i.maKyThiThu == int.Parse(view.ExamID) && i.maBoDe == int.Parse(view.PaperID) && i.maNguoiDung == int.Parse(view.PaperID));
                db.kyThiThus.DeleteOnSubmit(exammock);
                db.SubmitChanges();
            }
            view.ShowMessage("Xóa thành công!");
            LoadPage();
        }
        private void Create_View(object sender, EventArgs e)
        {
            view.ShowCreateMockExamView(currentcode);
        }
    }
}
