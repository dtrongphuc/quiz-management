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
                var exams = db.kyThiThus.GroupBy(x => x.maKyThiThu).Select(xs => new { ktt = xs.Select(d => d) }).ToList();
                int stt = 1;
                foreach (var i in exams)
                {
                    var mockexam = new MockExam();
                    mockexam.STT = stt++;
                    var lstlichthi = i.ktt.ToList();
                    mockexam.ExamID = lstlichthi[0].maKyThiThu.ToString();
                    mockexam.Grade = lstlichthi[0].khoiLop.tenKhoiLop;
                    mockexam.Subject = lstlichthi[0].monHoc.tenMonHoc;
                    mockexam.StartDay = lstlichthi[0].ngayThi.Value.Date.ToString("d");
                    mockexam.EndDay = lstlichthi[0].ngayKT.Value.Date.ToString("d");
                    mockexam.QuantityStudent = db.kyThiThus.Where(p => p.maKyThiThu == lstlichthi[0].maKyThiThu).Count();
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
           /* using(var db = new QuizDataContext())
            {
                kyThiThu exammock = db.kyThiThus.SingleOrDefault(i => i.maKyThiThu == int.Parse(view.ExamID) && i.maBoDe == int.Parse(view.PaperID) && i.maNguoiDung == int.Parse(view.PaperID));
                db.kyThiThus.DeleteOnSubmit(exammock);
                db.SubmitChanges();
            }
            view.ShowMessage("Xóa thành công!");
            LoadPage();

            var x = view.lichthichon.SelectedRows[0];
            var id = x.Cells["maLichThi"].Value.ToString();
            using (var db = new QuizDataContext())
            {
                var lt = db.lichThis.Where(p => p.maLichThi == int.Parse(id)).ToList();
                db.lichThis.DeleteOnSubmit(lt[0]);
                db.SubmitChanges();
                var itemdelete = lst.Where(i => i.MaLichThi == int.Parse(id)).ToList();
                lst.Remove(itemdelete[0]);
            }
            Fill();*/
        }
        private void Create_View(object sender, EventArgs e)
        {
            view.ShowCreateMockExamView(currentcode);
        }
    }
}
