using quiz_management.Models;
using quiz_management.Views.Student.ContribuQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.ContribuQuestions
{
    class CQuestionListPresenter
    {
        ICQuestionListView view;
        int currenUserCode;
        List<ContributeQuestion> listQuestion;
        public CQuestionListPresenter(ICQuestionListView v, int code)
        {
            view = v;
            currenUserCode = code;
            LoadContributeQuestionList(code);
            view.Closepage += Closepage_View;
            view.GoBackBefore += GoBackBefore_View;
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
            view.ShowMainCQuestionView(currenUserCode);

            
        }

        private void LoadContributeQuestionList(int code)
        {
            listQuestion = new List<ContributeQuestion>();
            List<dongGop> listContribute = null;
            using (var db = new QuizDataContext())
            {
                listContribute = db.dongGops.Where(i => i.maNguoiDung == currenUserCode).ToList();
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

        private void Closepage_View(object sender, EventArgs e)
        {
            view.ShowMainCQuestionView(currenUserCode);
        }
    }
}
