using quiz_management.Models;
using quiz_management.Views.Teacher.PaperManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            view.MoveAllToRight += MoveAllToRight_View;
            view.MoveToLeft += MoveToLeft_View;
            view.MoveAllToLeft += MoveAllToLeft_View;
            view.CreatePaper += CreatePaper_View;
        }
        private void Loadpage(int code)
        {
            using (var db = new QuizDataContext())
            {
                //string teachername = db.nguoiDungs.Select(i => i.maNguoiDung == code).ToString();

                var teachername = db.thongTins.Where(i => i.maNguoidung == 1).Select(i => i.tenNguoiDung).ToList();
                view.TeacherName = teachername[0].ToString();

                var listclass = db.khoiLops.ToList();
                view.GradeList = listclass;

                var listQuestions = db.cauHois.ToList();
                view.cauHois = listQuestions;
            }
        }
        private void CreatePaper_View(object sender, EventArgs e)
        {
            
        }

        private void MoveAllToLeft_View(object sender, EventArgs e)
        {
            
        }

        private void MoveToLeft_View(object sender, EventArgs e)
        {
            
        }

        private void MoveAllToRight_View(object sender, EventArgs e)
        {
            
        }

        private void MoveToRight_View(object sender, EventArgs e)
        {
            var kh = view.macauhoi;
            
            var ty = 1;
        }

        private void GoBackBefore_View(object sender, EventArgs e)
        {
           
        }

        
    }
}
