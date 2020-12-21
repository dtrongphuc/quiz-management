using quiz_management.Models;
using quiz_management.Views.Teacher.PaperManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.PaperManagement
{
    class UpdatePaperPresenter
    {
        IUpdatePaperView view;
        int currenUserCode;
        int PaperId;
        BindingList<CreatePaperWithQuestion> ListQuestionselcted = null;
        BindingList<CreatePaperWithQuestion> ListQuestion = null;
        public UpdatePaperPresenter(IUpdatePaperView v, int code, int paperid)
        {
            view = v;
            currenUserCode = code;
            PaperId = paperid;
            Loadpage(code, paperid);
            view.GoBackBefore += GoBackBefore_View;
            view.MoveToRight += MoveToRight_View;
            //view.MoveAllToRight += MoveAllToRight_View;
            view.MoveToLeft += MoveToLeft_View;
            //view.MoveAllToLeft += MoveAllToLeft_View;
            view.GradeChange += GradeChange_View;
            view.SubjectChange += SubjectChange_View;
            view.UpdatePaper += UpdatePaper_View;
            LoaddgvFromPaper();
            //--lỡ
        }

        private void UpdatePaper_View(object sender, EventArgs e)
        {
            view.ShowMessage("Cập nhật thành cộng");
            view.ShowPaperListView(currenUserCode);
        }

        private void SubjectChange_View(object sender, EventArgs e)
        {
            view.listQuestion = null;
            view.listQuestionselected = null;
            FillAll();
        }

        private void GradeChange_View(object sender, EventArgs e)
        {
            view.listQuestion = null;
            view.listQuestionselected = null;
            FillAll();
        }

        private void Loadpage(int code, int papercode)
        {
            ListQuestion = new BindingList<CreatePaperWithQuestion>();
            using (var db = new QuizDataContext())
            {
                //string teachername = db.nguoiDungs.Select(i => i.maNguoiDung == code).ToString();
                //binding tên giáo viên
                var teachername = db.thongTins.Where(i => i.maNguoidung == currenUserCode).Select(i => i.tenNguoiDung).ToList();
                view.TeacherName = teachername[0].ToString();

                //mã đề
                view.PaperID = papercode.ToString();

                //binding khối lớp
                var listclass = db.khoiLops.ToList();
                view.GradeList = listclass;
                //binding khối lớp trong đề thi 
                foreach (var i in db.boDes.Where(i => i.maBoDe == papercode))
                {
                    view.Gradeselected = listclass.FindIndex(a => a.maKhoiLop == i.maKhoi);
                }

                //binding môn học
                var listsubject = db.monHocs.ToList();
                view.SubjectList = listsubject;
                //binding môn học trong đề thi 
                foreach (var i in db.boDes.Where(i => i.maBoDe == papercode))
                {
                    view.Subjectseleted = listsubject.FindIndex(a => a.maMonHoc == i.maMon);
                }
            }
            //FillAll();
        }
        private void LoaddgvFromPaper()
        {
            if (ListQuestionselcted == null)
                ListQuestionselcted = new BindingList<CreatePaperWithQuestion>();
            using (var db = new QuizDataContext())
            {
                var questionselected = db.cTBoDes.Where(i => i.maBoDe == PaperId).ToList();
                foreach (var i in questionselected)
                {
                    CreatePaperWithQuestion p = new CreatePaperWithQuestion();
                    p.QuestionID = i.maCauHoi.ToString();
                    p.Question = i.cauHoi.cauHoi1.ToString();

                    ListQuestionselcted.Add(p);
                }
                view.listQuestionselected = ListQuestionselcted;

                var listQuestions = db.cauHois.Where(i => i.maKhoiLop == view.Grade && i.maMonHoc == int.Parse(view.Subject)).ToList();
                foreach (var i in listQuestions)
                {
                    CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                    pp.QuestionID = i.maCauHoi.ToString();
                    pp.Question = i.cauHoi1.ToString();

                    if (ListQuestionselcted.Where(x => x.QuestionID == i.maCauHoi.ToString()).Count() == 0)
                        ListQuestion.Add(pp);
                }
                view.listQuestion = ListQuestion;
            }
        }
        private void FillAll()
        {
            using (var db = new QuizDataContext())
            {
                //binding câu hỏi
                var listQuestions = db.cauHois.Where(i => i.maKhoiLop == view.Grade && i.maMonHoc == int.Parse(view.Subject)).ToList();
                foreach (var i in listQuestions)
                {
                    CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                    pp.QuestionID = i.maCauHoi.ToString();
                    pp.Question = i.cauHoi1.ToString();
                    ListQuestion.Add(pp);
                }
            }
            view.listQuestion = ListQuestion;
        }

        //private void CreatePaper_View(object sender, EventArgs e)
        //{
        //    string paperID = view.PaperID;
        //    int questionnum = view.AllQuestionSelect.Rows.Count;
        //    if (view.PaperID != "")
        //    {
        //        //if (questionnum >= 20)
        //        //{
        //        using (var db = new QuizDataContext())
        //        {
        //            db.boDes.InsertOnSubmit(new boDe
        //            {
        //                maBoDe = int.Parse(paperID), //-- tự tan
        //                tongSoCau = questionnum,
        //                maKhoi = view.Grade,
        //                maMon = int.Parse(view.Subject),
        //                thoiGian = 20
        //            });
        //            db.SubmitChanges();

        //            foreach (DataGridViewRow i in view.AllQuestionSelect.Rows)
        //            {
        //                db.cTBoDes.InsertOnSubmit(new cTBoDe
        //                {
        //                    maBoDe = int.Parse(paperID),
        //                    maCauHoi = int.Parse(i.Cells["MaCauHoiDaChon"].Value.ToString())
        //                });
        //                db.SubmitChanges();
        //            }
        //        }
        //        //}
        //        //else
        //        //    view.ShowMessage("Một đề ít nhất 20 câu hỏi!!");
        //    }
        //    else
        //        view.ShowMessage("Nhập mã đề!!");
        //}
        private void MoveToLeft_View(object sender, EventArgs e)
        {

            //lấy câu hỏi được chọn 
            //xóa những item dc chọn trong  danh sách question 
            //them item vao danh sách cau hỏi đã chọn
            if (ListQuestionselcted == null)
                ListQuestionselcted = new BindingList<CreatePaperWithQuestion>();
            foreach (DataGridViewRow i in view.AllQuestionSelect.SelectedRows)
            {
                CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                pp.QuestionID = i.Cells["MaCauHoiDaChon"].Value.ToString();
                pp.Question = i.Cells["CauHoiDaChon"].Value.ToString();

                var temp = ListQuestionselcted.Where(x => x.QuestionID == i.Cells["MaCauHoiDaChon"].Value.ToString()).ToList();
                ListQuestionselcted.Remove(temp[0]);
                ListQuestion.Add(pp);
            }
            view.listQuestionselected = ListQuestionselcted;
            view.listQuestion = ListQuestion;

            using (var db = new QuizDataContext())
            {
                List<cTBoDe> listdeail = new List<cTBoDe>();
                foreach (DataGridViewRow i in view.AllQuestionSelect.SelectedRows)
                {
                    var list = db.cTBoDes.Where(x => x.maBoDe == int.Parse(view.PaperID) && x.maCauHoi == int.Parse(i.Cells["MaCauHoiDaChon"].Value.ToString())).ToList();
                    listdeail.Add(list[0]);
                }
                db.cTBoDes.DeleteAllOnSubmit(listdeail);
                db.SubmitChanges();
            }
        }

        private void MoveToRight_View(object sender, EventArgs e)
        {
            //lấy câu hỏi được chọn 
            //xóa những item dc chọn trong  danh sách question 
            //them item vao danh sách cau hỏi đã chọn
            if (ListQuestionselcted == null)
                ListQuestionselcted = new BindingList<CreatePaperWithQuestion>();
            foreach (DataGridViewRow i in view.AllQuestion.SelectedRows)
            {
                CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                pp.QuestionID = i.Cells["MaCauHoi"].Value.ToString();
                pp.Question = i.Cells["CauHoi1"].Value.ToString();

                var temp = ListQuestionselcted.Where(x => x.QuestionID == i.Cells["MaCauHoi"].Value.ToString()).ToList();
                ListQuestion.Remove(temp[0]);
                ListQuestionselcted.Add(pp);
            }
            view.listQuestion = ListQuestion;
            view.listQuestionselected = ListQuestionselcted;

            //update thay đổi dô db
            using (var db = new QuizDataContext())
            {
                List<cTBoDe> listdeail = new List<cTBoDe>();
                foreach (DataGridViewRow i in view.AllQuestionSelect.SelectedRows)
                {
                    cTBoDe bd = new cTBoDe();
                    bd.maBoDe = int.Parse(view.PaperID);
                    bd.maCauHoi = int.Parse(i.Cells["MaCauHoiDaChon"].Value.ToString());
                    listdeail.Add(bd);
                }
                db.cTBoDes.InsertAllOnSubmit(listdeail);
                db.SubmitChanges();
            }
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowPaperListView(currenUserCode);
        }
    }
}
