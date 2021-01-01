using quiz_management.Models;
using quiz_management.Views.Teacher.ExamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.ExamManagement
{
    class WatchOrPrintExamPresenter
    {
        IWatchOrPrintExamView view;
        int currentuser;
        public WatchOrPrintExamPresenter(IWatchOrPrintExamView v, int code)
        {
            view = v;
            currentuser = code;
            view.GobackBefore += GobackBefore_View;
            view.Print += Print_View;
            LoadPage();
        }

        private void LoadPage()
        {
            List<StudentOfExam> studentOfExams = new List<StudentOfExam>();
            using (var db = new QuizDataContext())
            {
                var teachername = db.thongTins.Where(i => i.maNguoidung == 1).Select(i => i.tenNguoiDung).ToList();
                view.TeacherName = teachername[0].ToString();

                var officalexamlist = db.lichThis.ToList();
                var mockexamlist = db.kyThiThus.ToList();
                int stt = 1;
                foreach (var i in officalexamlist)
                {
                    StudentOfExam se = new StudentOfExam();
                    se.STT = stt;
                    se.StudentName = i.nguoiDung.thongTin.tenNguoiDung;
                    se.ExamName = "Thi chính thức";

                    studentOfExams.Add(se);
                    stt++;
                }
                foreach (var i in mockexamlist)
                {
                    StudentOfExam se = new StudentOfExam();
                    se.STT = stt;
                    se.StudentName = i.nguoiDung.thongTin.tenNguoiDung;
                    se.ExamName = "Thi thử";

                    studentOfExams.Add(se);
                    stt++;
                }
                view.ExamList = studentOfExams;
            }
        }

        private void GobackBefore_View(object sender, EventArgs e)
        {
            view.ShowMainTeacher(currentuser);
        }

        private void Print_View(object sender, EventArgs e)
        {
            
        }
    }
}
