using quiz_management.Models;
using quiz_management.Views.Teacher.ExamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.ExamManagement
{
    internal class WatchOrPrintExamPresenter
    {
        private IWatchOrPrintExamView view;
        private int currentuser;

        public WatchOrPrintExamPresenter(IWatchOrPrintExamView v, int code)
        {
            view = v;
            currentuser = code;
            view.GobackBefore += GobackBefore_View;
            LoadPage();
        }

        private void LoadPage()
        {
            List<StudentOfExam> studentOfExams = new List<StudentOfExam>();
            using (var db = new QuizDataContext())
            {
                var officalexamlist = db.lichThis.ToList();
                int stt = 1;
                foreach (var i in officalexamlist)
                {
                    StudentOfExam se = new StudentOfExam();
                    se.STT = stt;
                    se.StudentName = i.nguoiDung.thongTin.tenNguoiDung;
                    se.DOBExam = i.ngayThi.Date.Date.ToString("d");

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
    }
}