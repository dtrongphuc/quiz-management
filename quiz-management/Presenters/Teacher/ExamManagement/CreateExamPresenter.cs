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
        List<thongTin> lstHocSinh;
        List<monHoc> lstMonHoc;
        List<boDe> lstbode;
        List<thongTin> lstThiSinh;
        public CreateExamPresenter(ICreateExamView v, int code)
        {
            view = v;
            currentcode = code;
            Initialize();
        }

        private void Initialize()
        {
            lstbode = new List<boDe>();
            view.GoBackBefore += View_Back;
            view.Submit += View_Submit;
            view.subjectChange += View_SubjectChange;
            view.MoveRight += View_MoveRight;
            view.MoveLeft += View_MoveLeft;
            view.examChange += View_ExamChange;

            using (var db = new QuizDataContext())
            {
                lstMonHoc = db.monHocs.ToList();
            }
            if (lstMonHoc.Count != 0) lstbode = FindBymonHocId(lstMonHoc[0].maMonHoc);
            if (lstbode.Count != 0) lstHocSinh = FindByBoDeId(lstbode[0].maKhoi);
            Fill();
        }

        private void View_ExamChange(object sender, EventArgs e)
        {
            string id = view.DeThiChon;
            lstHocSinh = FindByBoDeId(lstbode[0].maKhoi);
            lstThiSinh = null;
            view.lstThiSinh = lstThiSinh;
            view.lstHocSinh = lstHocSinh;
        }

        private void View_MoveLeft(object sender, EventArgs e)
        {
            if (lstHocSinh == null)
                lstHocSinh = new List<thongTin>();
            foreach (DataGridViewRow i in view.lstThiSinhChon.SelectedRows)
            {
                var id = i.Cells["ThiSinhDuocChon"].Value.ToString();
                var temp = lstThiSinh.Where(x => x.maNguoidung == int.Parse(id)).ToList();
                thongTin tt = new thongTin();
                tt = temp[0];
                lstHocSinh.Add(tt);
                lstThiSinh.Remove(tt);
                if (lstThiSinh.Count == 0)
                    lstThiSinh = null;
            }
            view.lstHocSinh = lstHocSinh;
            view.lstThiSinh = lstThiSinh;
        }

        private void View_MoveRight(object sender, EventArgs e)
        {
            if (lstThiSinh == null)
                lstThiSinh = new List<thongTin>();
            foreach (DataGridViewRow i in view.lstHocSinhChon.SelectedRows)
            {
                var id = i.Cells["HocSinhDuocChon"].Value.ToString();
                var temp = lstHocSinh.Where(x => x.maNguoidung == int.Parse(id)).ToList();
                thongTin tt = new thongTin();
                tt = temp[0];
                lstThiSinh.Add(tt);
                lstHocSinh.Remove(tt);
                if (lstHocSinh.Count == 0)
                    lstHocSinh = null;
            }
            view.lstHocSinh = lstHocSinh;
            view.lstThiSinh = lstThiSinh;
        }

        private void Fill()
        {
            view.lstMonHoc = lstMonHoc;
            view.lstDeThi = lstbode;
            view.lstHocSinh = lstHocSinh;
        }

        private void View_SubjectChange(object sender, EventArgs e)
        {
            string id = view.monHocChon;
            lstbode = FindBymonHocId(lstMonHoc[0].maMonHoc);
            view.lstDeThi = lstbode;
        }

        private void View_Submit(object sender, EventArgs e)
        {
            if(lstThiSinh.Count == 0)
            {
                view.ShowMessage("Cần có thi Sinh Thi.");
                return;
            }    
            using (var db = new QuizDataContext())
            {
                foreach (thongTin i in lstThiSinh)
                {
                    db.lichThis.InsertOnSubmit(new lichThi
                    {
                        maNguoiDung = i.maNguoidung,
                        maMonHoc = int.Parse(view.monHocChon),
                        ngayThi = view.NgayThi,
                        maBoDe = int.Parse(view.DeThiChon)
                    });
                    db.SubmitChanges();
                }
            }
                view.ShowMessage("Thành Công.");
        }

        private void View_Back(object sender, EventArgs e)
        {
            view.ShowExamListView(currentcode);
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

        private List<thongTin> FindByBoDeId(string mak)
        {
            List<thongTin> lsttt = new List<thongTin>();
            using (var db = new QuizDataContext())
            {
                var temp = db.Lops.Where(l => l.maKhoiLop == mak).Join(db.thongTins,
                                            lh => lh.maLopHoc,
                                            tt => tt.maLopHoc,
                                            (lh, tt) => new { tt = tt }).ToList();
                
                 foreach(var i in temp)
                {
                    thongTin t = new thongTin();
                    t = i.tt;
                    lsttt.Add(t);
                }
            }
            return lsttt;
        }
    }
}
