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
        int paperidpresent = 0;//ma bộ đề hiện tại
        public PaperListPresenter(IPaperListView v, int code)
        {
            view = v;
            currenuser = code;
            view.GobackBefore += GobackBefore_View;
            view.UpdatePaper += UpdatePaper_View;
            view.Delete += Delete_View;
            //view.dgvSelectChange += dgvSelectChange_View;
            using (var db = new QuizDataContext())
            {
                //binding tên giáo viên
                var teachername = db.thongTins.Where(i => i.maNguoidung == 1).Select(i => i.tenNguoiDung).ToList();
                view.Teachername = teachername[0].ToString();
            }
            LoadPage(code);
        }

        //private void dgvSelectChange_View(object sender, EventArgs e)
        //{
        //    paperidpresent = int.Parse(view.PaperID);
        //}

        private void Delete_View(object sender, EventArgs e)
        {
            using (var db = new QuizDataContext())
            {
                //item trong chi tiết bộ đề
                var itemsDetailpaper = db.cTBoDes.Where(i => i.maBoDe == int.Parse(view.PaperID)).ToList();
                foreach (var i in itemsDetailpaper)
                {
                    db.cTBoDes.DeleteOnSubmit(i);
                    db.SubmitChanges();
                }

                //item trong bộ đề
                boDe itemspaper = db.boDes.SingleOrDefault(i => i.maBoDe == int.Parse(view.PaperID));
                db.boDes.DeleteOnSubmit(itemspaper);
                db.SubmitChanges();
            }
            view.ShowMessage("Xóa thành công.");
            LoadPage(currenuser);
        }

        private void UpdatePaper_View(object sender, EventArgs e)
        {
            view.ShowUpdatePaperView(currenuser, int.Parse(view.PaperID));
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
                //paperid = db.boDes.
                //var it = db.ketQuas.Where(x => x.maBoDe == 1).Count();
                //binding datagriview
                var list = db.boDes.ToList();
                foreach (var i in list)
                {
                    Papers p = new Papers();
                    p.PaperCode = i.maBoDe.ToString();
                    p.Subject = i.monHoc.tenMonHoc.ToString();
                    p.Grade = i.khoiLop.tenKhoiLop.ToString();
                    p.QuestionNum = i.cTBoDes.Where(x => x.maBoDe == int.Parse(i.maBoDe.ToString())).Count();
                    p.Status = (i.ketQuas.Where(x => x.maBoDe == i.maBoDe).Count()) > 0 ? "Đã có trong kì thi" : "Chưa có trong kì thi";
                    paperList.Add(p);
                }
                view.papers = paperList;
            }
        }
    }
}
