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
        string gradeID;
        int subjectID;
        int status;
        public UpdatePaperPresenter(IUpdatePaperView v, int code, int paperid)
        {
            view = v;
            currenUserCode = code;
            PaperId = paperid;
            Loadpage(code, paperid);
            view.GoBackBefore += GoBackBefore_View;
            view.MoveToRight += MoveToRight_View;
            view.MoveToLeft += MoveToLeft_View;
            view.GradeChange += GradeChange_View;
            view.SubjectChange += SubjectChange_View;
            view.UpdatePaper += UpdatePaper_View;
            LoaddgvFromPaper();
        }

        private void UpdatePaper_View(object sender, EventArgs e)
        {
            try
            {
                if(view.AllQuestionSelect.Rows.Count < 1)
                {
                    view.ShowMessage("Đề thi phải có câu hỏi!");
                    return;
                }
                using (var db = new QuizDataContext())
                {
                    //item trong chi tiết bộ đề
                    var itemsDetailpaper = db.cTBoDes.Where(i => i.maBoDe == int.Parse(view.PaperID)).ToList();
                    foreach (var i in itemsDetailpaper)
                    {
                        db.cTBoDes.DeleteOnSubmit(i);
                        db.SubmitChanges();
                    }
                    //tạo lại cho chi tiết bộ đề
                    foreach (DataGridViewRow i in view.AllQuestionSelect.Rows)
                    {
                        db.cTBoDes.InsertOnSubmit(new cTBoDe
                        {
                            maBoDe = int.Parse(view.PaperID),
                            maCauHoi = int.Parse(i.Cells["MaCauHoiDaChon"].Value.ToString())
                        });
                        db.SubmitChanges();
                    }
                }
                //hiển thị thông báo thành công và quay lại trang danh sách đề thi 
                view.ShowMessage("Cập nhật thành cộng");
                view.ShowPaperListView(currenUserCode);
            }
            catch(Exception)
            {
                view.ShowMessage("có lỗi xảy ra, xin cập nhật lại!");
            }
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

                //khối lớp
                var grade_subject = db.boDes.Where(i => i.maBoDe == papercode);
                view.GradeList = grade_subject.Select(i => i.khoiLop.tenKhoiLop).ToList()[0];
                gradeID = grade_subject.Select(i => i.khoiLop.maKhoiLop).ToList()[0];
                //môn học
                view.SubjectList = grade_subject.Select(i => i.monHoc.tenMonHoc).ToList()[0];
                subjectID = grade_subject.Select(i => i.monHoc.maMonHoc).ToList()[0];
                //ten6 kì thi -- 1 là chính thức - 0 là thi thử
                view.Exam = grade_subject.Select(i => i.trangThai).ToList()[0] == 1 ? "Đề thi: Chính thức" : "Đề thi: Thử";
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

                //db.cauHois.Where(i => i.maKhoiLop == view.Grade && i.maMonHoc == int.Parse(view.Subject) && i.trangThai == status).ToList();

                var statusExam = db.boDes.Where(i => i.maBoDe == PaperId).Select(i => i.trangThai).ToList()[0];
                //var listQuestions = db.cauHois.Where(i => i.maKhoiLop == gradeID && i.maMonHoc == subjectID).ToList();
                var listQuestions = db.cauHois.Where(i => i.maKhoiLop == gradeID && i.maMonHoc == subjectID && i.trangThai == statusExam).ToList();
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
                var listQuestions = db.cauHois.Where(i => i.maKhoiLop == gradeID && i.maMonHoc == subjectID).ToList();
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

                var temp = ListQuestion.Where(x => x.QuestionID == i.Cells["MaCauHoi"].Value.ToString()).ToList();
                ListQuestion.Remove(temp[0]);
                ListQuestionselcted.Add(pp);
            }
           
            view.listQuestion = ListQuestion;
            view.listQuestionselected = ListQuestionselcted;
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowPaperListView(currenUserCode);
        }
    }
}
