using quiz_management.Models;
using quiz_management.Views.Teacher.QuestionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.QuestionManagement
{
    class QuestionApprovalPresenter
    {
        IQuestionApprovalView view;
        int currenUserCode;
        BindingList<ContributeQuestion> listQuestion;
        List<dongGop> listContribute = null;
        public QuestionApprovalPresenter(IQuestionApprovalView v, int code)
        {
            view = v;
            currenUserCode = code;
            LoadContributeQuestionList(code);
            view.Approval += Approval_View;
            view.GoBackBefore += GoBackBefore_View;
            view.QuestionList += QuestionList_view;
        }

        private void QuestionList_view(object sender, EventArgs e)
        {
            view.ShowQuestionList(currenUserCode, "", 0);
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowMainTeacher(currenUserCode);
        }

        private void LoadContributeQuestionList(int code)
        {
            listQuestion = new BindingList<ContributeQuestion>();
            using (var db = new QuizDataContext())
            {
                listContribute = db.dongGops.ToList();
                foreach (var contribute in listContribute)
                {
                    ContributeQuestion cq = new ContributeQuestion();
                    cq.MaDongGop = contribute.maDongGop.ToString();
                    cq.TenNguoiDung = contribute.nguoiDung.thongTin.tenNguoiDung.ToString();
                    cq.TenMonHoc = contribute.monHoc.tenMonHoc;
                    cq.TrangThai = (contribute.trangthai == 1) ? "Đã duyệt" : "Chưa duyệt";
                    cq.Ngay = contribute.ngay.ToString();
                    cq.CauHoi = contribute.cauHoi.ToString();
                    cq.KhoiLop = contribute.khoiLop.tenKhoiLop.ToString();

                    listQuestion.Add(cq);
                }
                view.contributed = listQuestion;
            }
        }

        private void Approval_View(object sender, EventArgs e)
        {
            using (var db = new QuizDataContext())
            {
                foreach (DataGridViewRow i in view.CQuestionSelected.SelectedRows)
                {
                    int CQid = int.Parse(i.Cells["maDongGop"].Value.ToString());
                    //cập nhật phê duyệt
                    var approval = db.dongGops.Single(x => x.maDongGop == CQid);
                    approval.trangthai = 1;
                    db.SubmitChanges();

                    //xóa câu hỏi đã phê duyệt ra khỏi dgv
                    var temp = listQuestion.Where(x => x.MaDongGop == CQid.ToString()).ToList();
                    listQuestion.Remove(temp[0]);

                    db.SubmitChanges();
                    //thêm đóng góp dô câu hỏi
                    AddToQuestion(CQid);
                }
                view.ShowMessage($"Phê duyệt thành công {view.CQuestionSelected.SelectedRows.Count} câu hỏi");
                view.contributed = listQuestion;
            }
        }

        private void AddToQuestion(int contributeID)
        {
            using (var db = new QuizDataContext())
            {
                var contribute = db.dongGops.Where(i => i.maDongGop == contributeID).ToList()[0];
                var answercontributes = db.cTDongGops.Where(i => i.maDongGop == contributeID).ToList();

                //thêm vào bảng câu hỏi
                db.cauHois.InsertOnSubmit(new cauHoi
                {
                    maMonHoc = contribute.maMonHoc,
                    cauHoi1 = contribute.cauHoi,
                    doKho = 1, // độ khó măc định
                    trangThai = 0, // 0 là câu hỏi đóng góp chỉ dc luyện tập 
                    maKhoiLop = contribute.maKhoiLop
                });
                db.SubmitChanges();

                //thêm vào bảng đáp án
                var QuestionID = db.cauHois.Max(i => i.maCauHoi);
                int run = answercontributes.Count;
                int AnswerID = 1;
                foreach (var answer in answercontributes)
                {
                    db.dapAns.InsertOnSubmit(new dapAn
                    {
                        maCauHoi = QuestionID,
                        maCauTraloi = AnswerID,
                        cauTraLoi = answer.cauTraLoi,
                        dapAn1 = answer.dapAn
                    });
                    db.SubmitChanges();
                    AnswerID++;
                } 
                //view.ShowMessage("Tạo câu hỏi thành công");
                //view.ShowQuestionList(currentUser, view.GradeId, int.Parse(view.SubjectId));

            }
        }
    }
}
