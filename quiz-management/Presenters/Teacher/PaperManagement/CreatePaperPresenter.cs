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
    class CreatePaperPresenter
    {
        ICreatePaperView view;
        int currenUserCode;
        BindingList<CreatePaperWithQuestion> ListQuestionselcted = null;
        BindingList<CreatePaperWithQuestion> listQT = null;
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
            view.GradeChange += GradeChange_View;
            view.SubjectChange += SubjectChange_View;
            view.ExamChange += ExamChange_Change;
        }

        private void ExamChange_Change(object sender, EventArgs e)
        {
            view.listQuestion = null;
            view.listQuestionselected = null;
            FillAllMock();
        }

        private void FillAllMock()
        {
            //List<CreatePaperWithQuestion> listQT = new List<CreatePaperWithQuestion>();
            listQT = new BindingList<CreatePaperWithQuestion>();
            using (var db = new QuizDataContext())
            {
                //binding câu hỏi
                var listQuestions = db.dongGops.Where(i => i.maKhoiLop == view.Grade && i.maMonHoc == int.Parse(view.Subject)).ToList();
                foreach (var i in listQuestions)
                {
                    CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                    pp.QuestionID = i.maCauHoi.ToString();
                    pp.Question = i.cauHoi1.ToString();
                    listQT.Add(pp);
                }
            }
            view.listQuestion = listQT;
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
            }
            FillAll();
        }

        private void FillAll()
        {
            //List<CreatePaperWithQuestion> listQT = new List<CreatePaperWithQuestion>();
            listQT = new BindingList<CreatePaperWithQuestion>();
            using (var db = new QuizDataContext())
            {
                //binding câu hỏi
                var listQuestions = db.cauHois.Where(i => i.maKhoiLop == view.Grade && i.maMonHoc == int.Parse(view.Subject)).ToList();
                foreach (var i in listQuestions)
                {
                    CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                    pp.QuestionID = i.maCauHoi.ToString();
                    pp.Question = i.cauHoi1.ToString();
                    listQT.Add(pp);
                }
            }
            view.listQuestion = listQT;
        }

        private void CreatePaper_View(object sender, EventArgs e)
        {
            //string paperID = view.PaperID;
            int questionnum = view.AllQuestionSelect.Rows.Count;

            using (var db = new QuizDataContext())
            {
                db.boDes.InsertOnSubmit(new boDe
                {
                    //maBoDe = int.Parse(paperID), //-- tự tan
                    tongSoCau = questionnum,
                    maKhoi = view.Grade,
                    maMon = int.Parse(view.Subject),
                    thoiGian = 20
                });
                db.SubmitChanges();

                var paperidMax = db.boDes.Max(i => i.maBoDe);

                foreach (DataGridViewRow i in view.AllQuestionSelect.Rows)
                {
                    db.cTBoDes.InsertOnSubmit(new cTBoDe
                    {
                        maBoDe = paperidMax,
                        maCauHoi = int.Parse(i.Cells["MaCauHoiDaChon"].Value.ToString())
                    });
                    db.SubmitChanges();
                }
                view.ShowMessage($"Thêm thành công bộ đề với mã là: {paperidMax}");
                view.ShowPaperListView(currenUserCode);
            }
        }
        private void MoveToLeft_View(object sender, EventArgs e)
        {
            if (ListQuestionselcted == null)
                ListQuestionselcted = new BindingList<CreatePaperWithQuestion>();
            foreach (DataGridViewRow i in view.AllQuestionSelect.SelectedRows)
            {
                CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                pp.QuestionID = i.Cells["MaCauHoiDaChon"].Value.ToString();
                pp.Question = i.Cells["CauHoiDaChon"].Value.ToString();

                var temp = ListQuestionselcted.Where(x => x.QuestionID == i.Cells["MaCauHoiDaChon"].Value.ToString()).ToList();
                ListQuestionselcted.Remove(temp[0]);
                listQT.Add(pp);
            }
            view.listQuestionselected = ListQuestionselcted;
            view.listQuestion = listQT;
        }


        private void MoveToRight_View(object sender, EventArgs e)
        {
            if (ListQuestionselcted == null)
                ListQuestionselcted = new BindingList<CreatePaperWithQuestion>();
            foreach (DataGridViewRow i in view.AllQuestion.SelectedRows)
            {
                CreatePaperWithQuestion pp = new CreatePaperWithQuestion();
                pp.QuestionID = i.Cells["MaCauHoi"].Value.ToString();
                pp.Question = i.Cells["CauHoi1"].Value.ToString();

                var temp = listQT.Where(x => x.QuestionID == i.Cells["MaCauHoi"].Value.ToString()).ToList();
                listQT.Remove(temp[0]);
                ListQuestionselcted.Add(pp);
            }
            view.listQuestion = listQT;
            view.listQuestionselected = ListQuestionselcted;

        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowMainTeacherView(currenUserCode);
        }
    }
}
