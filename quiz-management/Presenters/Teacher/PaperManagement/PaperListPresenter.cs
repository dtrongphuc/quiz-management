using quiz_management.Models;
using quiz_management.Views.Teacher.PaperManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.PaperManagement
{

    class PaperListPresenter
    {
        IPaperListView view;
        int currenuser = 0;
        public PaperListPresenter(IPaperListView v, int code)
        {
            view = v;
            currenuser = code;
            view.GobackBefore += GobackBefore_View;
            view.UpdatePaper += UpdatePaper_View;
            view.Delete += Delete_View;
            using (var db = new QuizDataContext())
            {
                //binding tên giáo viên
                var teachername = db.thongTins.Where(i => i.maNguoidung == 1).Select(i => i.tenNguoiDung).ToList();
                view.Teachername = teachername[0].ToString();
            }
            LoadPage(code);
        }

        private void Delete_View(object sender, EventArgs e)
        {
            using (var db = new QuizDataContext())
            {
                //đối tưỡng cần xóa
                boDe itemdelete = db.boDes.SingleOrDefault(i => i.maBoDe == int.Parse(view.PaperID));
                //xóa nó
                db.boDes.DeleteOnSubmit(itemdelete);
                db.SubmitChanges();

            }
            LoadPage(currenuser);
        }

        private void UpdatePaper_View(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GobackBefore_View(object sender, EventArgs e)
        {
            view.ShowCreatePaperView(currenuser);
        }

        private void LoadPage(int code)
        {
            List<Papers> paperList = new List<Papers>();
            using (var db = new QuizDataContext())
            {
                //binding datagriview
                var list = db.boDes.ToList();
                foreach (var i in list)
                {
                    Papers p = new Papers();
                    p.PaperID = i.maBoDe.ToString();
                    p.Subject = i.monHoc.maMonHoc.ToString();
                    p.Grade = i.khoiLop.maKhoiLop.ToString();
                    p.QuestionNum = i.cTBoDes.Where(x => x.maBoDe == int.Parse(i.maBoDe.ToString())).Count();

                    paperList.Add(p);
                }
                view.papers = paperList;
            }
        }
    }
}
