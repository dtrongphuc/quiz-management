using quiz_management.Models;
using quiz_management.Views.Teacher.PaperManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.PaperManagement
{
    class CreatePaperPresenter
    {
        ICreatePaperView view;
        int currenUserCode;
        public CreatePaperPresenter(ICreatePaperView v, int code)
        {
            view = v;
            currenUserCode = code;
            Loadpage(code);
            view.GoBackBefore += GoBackBefore_View;
            view.MoveToRight += MoveToRight_View;
            //view.MoveAllToRight += MoveAllToRight_View;
            view.MoveToLeft += MoveToLeft_View;
            //view.MoveAllToLeft += MoveAllToLeft_View;
            view.CreatePaper += CreatePaper_View;
            view.GoBackBefore += GoBackBFore_View;
            view.WatchPaperList += WatchPaperList_View;
        }

        private void WatchPaperList_View(object sender, EventArgs e)
        {
            view.ShowPaperListView(currenUserCode);
        }

        private void GoBackBFore_View(object sender, EventArgs e)
        {
            view.ShowMainTeacherView(currenUserCode);
        }

        private void Loadpage(int code)
        {
            List<CreatePaperWithQuestion> listQT = new List<CreatePaperWithQuestion>();
            using (var db = new QuizDataContext())
            {
                //string teachername = db.nguoiDungs.Select(i => i.maNguoiDung == code).ToString();
                //binding tên giáo viên
                var teachername = db.thongTins.Where(i => i.maNguoidung == 1).Select(i => i.tenNguoiDung).ToList();
                view.TeacherName = teachername[0].ToString();

                //binding khối lớp
                var listclass = db.khoiLops.ToList();
                view.GradeList = listclass;
                //binding môn học
                var listsubject = db.monHocs.ToList();
                view.SubjectList = listsubject;

                //binding câu hỏi
                var listQuestions = db.cauHois.Where(i => i.maKhoiLop == view.Grade && i.maMonHoc == int.Parse(view.Subject)).ToList();
                foreach (var i in listQuestions)
                {
                    CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                    pp.QuestionID = i.maCauHoi.ToString();
                    pp.Question = i.cauHoi1.ToString();
                    listQT.Add(pp);
                }
                view.listQuestion = listQT;
            }
        }
        private void CreatePaper_View(object sender, EventArgs e)
        {
            string paperID = view.PaperID;
            int questionnum = view.AllQuestionSelect.Rows.Count;
            if (view.PaperID == "")
            {
                if (questionnum >= 20)
                {
                    using (var db = new QuizDataContext())
                    {
                        foreach (DataGridViewRow i in view.AllQuestionSelect.Rows)
                        {
                            db.cTBoDes.InsertOnSubmit(new cTBoDe
                            {
                                maBoDe = int.Parse(paperID),
                                maCauHoi = int.Parse(i.Cells["MaCauHoiDaChon"].Value.ToString())
                            });
                            db.SubmitChanges();
                        }

                        db.boDes.InsertOnSubmit(new boDe
                        {
                            maBoDe = int.Parse(paperID),
                            tongSoCau = questionnum,
                            maKhoi = view.Grade,
                            maMon = null,
                            thoiGian = 20
                        });
                        db.SubmitChanges();
                    }
                }
                else
                    view.ShowMessage("Một đề ít nhất 20 câu hỏi!!");
            }
            else
                view.ShowMessage("Nhập mã đề!!");
        }

        private void MoveAllToLeft_View(object sender, EventArgs e)
        {
            
        }

        private void MoveToLeft_View(object sender, EventArgs e)
        {
            List<CreatePaperWithQuestion> ListQuestionselcted = new List<CreatePaperWithQuestion>();
            List<CreatePaperWithQuestion> ListQuestion = new List<CreatePaperWithQuestion>();
            List<int> indexs = new List<int>();
            //lấy tất cả các items bên danh sách câu ra list
            foreach (DataGridViewRow i in view.AllQuestionSelect.Rows)
            {
                CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                pp.QuestionID = i.Cells["MaCauHoiDaChon"].Value.ToString();
                pp.Question = i.Cells["CauHoiDaChon"].Value.ToString();

                ListQuestionselcted.Add(pp);
            }
            //lấy câu hỏi được chọn 
            //xóa những item dc chọn trong  danh sách question 
            //them item vao danh sách cau hỏi đã chọn
            foreach (DataGridViewRow i in view.AllQuestionSelect.SelectedRows)
            {
                CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                pp.QuestionID = i.Cells["MaCauHoiDaChon"].Value.ToString();
                pp.Question = i.Cells["CauHoiDaChon"].Value.ToString();

                ListQuestionselcted.RemoveAt(i.Index);
                ListQuestion.Add(pp);
            }
            view.listQuestionselected = ListQuestionselcted;

            foreach (DataGridViewRow i in view.AllQuestion.Rows)
            {
                CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                pp.QuestionID = i.Cells["MaCauHoi"].Value.ToString();
                pp.Question = i.Cells["CauHoi1"].Value.ToString();

                ListQuestion.Add(pp);
            }
            view.listQuestion = ListQuestion;

        }

        private void MoveAllToRight_View(object sender, EventArgs e)
        {
            
        }

        private void MoveToRight_View(object sender, EventArgs e)
        {
            List<CreatePaperWithQuestion> ListQuestionselcted = new List<CreatePaperWithQuestion>();
            List<CreatePaperWithQuestion> ListQuestion = new List<CreatePaperWithQuestion>();
            List<int> indexs = new List<int>();
            //lấy tất cả các items bên danh sách câu ra list
            foreach (DataGridViewRow i in view.AllQuestion.Rows)
            {
                CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                pp.QuestionID = i.Cells["MaCauHoi"].Value.ToString();
                pp.Question = i.Cells["CauHoi1"].Value.ToString();

                ListQuestion.Add(pp);
            }
            //lấy câu hỏi được chọn 
            //xóa những item dc chọn trong  danh sách question 
            //them item vao danh sách cau hỏi đã chọn
            foreach (DataGridViewRow i in view.AllQuestion.SelectedRows)
            {
                CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                pp.QuestionID = i.Cells["MaCauHoi"].Value.ToString();
                pp.Question = i.Cells["CauHoi1"].Value.ToString();

                ListQuestion.RemoveAt(i.Index);
                ListQuestionselcted.Add(pp);
            }            
            view.listQuestion = ListQuestion;

            foreach (DataGridViewRow i in view.AllQuestionSelect.Rows)
            {
                CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                pp.QuestionID = i.Cells["MaCauHoiDaChon"].Value.ToString();
                pp.Question = i.Cells["CauHoiDaChon"].Value.ToString();

                ListQuestionselcted.Add(pp);
            }
            view.listQuestionselected = ListQuestionselcted;
          
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
           
        }
    }
}
