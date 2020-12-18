using quiz_management.Models;
using quiz_management.Views.Teacher.ExamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.ExamManagement
{
    public class CreateExamPresenter
    {
        ICreateExamView view;
        int currentcode;
        List<thongTin> lstThongTin;
        List<monHoc> lstMonHoc;
        List<boDe> lstbode;
        List<thongTin> lstHocSinhDuocChon;
        public CreateExamPresenter(ICreateExamView v, int code)
        {
            view = v;
            currentcode = code;
            Initialize();
        }

        private void Initialize()
        {
            lstbode = new List<boDe>();
            lstHocSinhDuocChon = new List<thongTin>();
            view.GoBackBefore += View_Back;
            view.Submit += View_Submit;
            view.subjectChange += View_SubjectChange;
            view.MoveRight += View_MoveRight;
            
            using(var db = new QuizDataContext())
            {
                lstThongTin = db.thongTins.ToList();
                lstMonHoc = db.monHocs.ToList();
            }
            lstbode = FindBymonHocId(lstMonHoc[0].maMonHoc);
            Fill();
        }

        private void View_MoveRight(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow i in view.lstHocSinhChon.SelectedRows)
            {
                
                var id = i.Cells["MSV"].Value.ToString();
                var temp =  lstThongTin.Where(x => x.maNguoidung == int.Parse(id));
                thongTin tt = new thongTin();
                
               
            }
        }

        private void Fill()
        {
            view.lstMonHoc = lstMonHoc;
            view.lstDeThi = lstbode;
            view.lstHocSinh = lstThongTin;
        }

        private void View_SubjectChange(object sender, EventArgs e)
        {
                
        }

        private void View_Submit(object sender, EventArgs e)
        {
            view.ShowMessage("Thành Công.");
        }

        private void View_Back(object sender, EventArgs e)
        {
            view.MainTeacherView(currentcode);
        }

        private List<boDe> FindBymonHocId(int maMH)
        {
            List<boDe> lstbd;
            using (var db = new QuizDataContext())
            {
                lstbd = db.boDes.Where(p => p.maMon == maMH).ToList();
            }
            return lstbd;
        }
    }
}
