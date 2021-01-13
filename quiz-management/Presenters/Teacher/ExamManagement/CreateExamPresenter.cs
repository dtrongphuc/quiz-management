using quiz_management.Models;
using quiz_management.Views.Teacher.ExamManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        IList<thongTin> lstHocSinh;
        IList<monHoc> lstMonHoc;
        IList<khoiLop> lstLop;
        IList<boDe> lstbode;
        IList<thongTin> lstThiSinh;
        BindingSource  lstHocSinhsource;
        BindingSource lstMonHocsource;
        BindingSource  lstLopsource;
        BindingSource lstbodesource;
        BindingSource  lstThiSinhsource;



        public CreateExamPresenter(ICreateExamView v, int code)
        {
            view = v;
            currentcode = code;
            Initialize();
        }

        private void Initialize()
        {
            lstbode = new BindingList<boDe>();
            view.GoBackBefore += View_Back;
            view.Submit += View_Submit;
            view.subjectChange += View_SubjectChange;
            view.MoveRight += View_MoveRight;
            view.MoveLeft += View_MoveLeft;
            view.ClassChange += View_ClassChange;

            using (var db = new QuizDataContext())
            {
                lstMonHoc = new BindingList<monHoc>(db.monHocs.ToList());
                lstLop = new BindingList<khoiLop>(db.khoiLops.ToList());
            }
            if (lstMonHoc.Count != 0) lstbode = FindBymonHocIdVaLopId(lstMonHoc[0].maMonHoc, lstLop[0].maKhoiLop);
            lstHocSinh = FindByBoDeId(lstLop[0].maKhoiLop);
            Fill();
        }

        private void View_ClassChange(object sender, EventArgs e)
        {
            string idkhoilop = view.KhoiLopChon;
            int idmonhoc = int.Parse(view.monHocChon);
            lstbode = FindBymonHocIdVaLopId(idmonhoc, idkhoilop);
            lstbodesource.DataSource = lstbode;
            view.lstDeThi.DataSource = lstbodesource;

            lstHocSinh = FindByBoDeId(idkhoilop);
            lstThiSinh = null;
            lstHocSinhsource.DataSource = lstHocSinh;
            view.lstHocSinh.DataSource = lstHocSinhsource;

            lstThiSinhsource.DataSource = lstThiSinh;
            view.lstThiSinh.DataSource = lstThiSinhsource;
        }
        private void Fill()
        {
            FillSource();
            view.lstMonHoc.DataSource = lstMonHocsource;
            view.lstDeThi.DataSource = lstbodesource;
            view.lstHocSinh.DataSource = lstHocSinhsource;
            view.lstKhoiLop.DataSource = lstLopsource;
        }

        private void FillSource()
        {
            lstMonHocsource = new BindingSource();
            lstbodesource = new BindingSource();
            lstHocSinhsource = new BindingSource();
            lstLopsource = new BindingSource();
            lstThiSinhsource = new BindingSource();

            lstMonHocsource.DataSource = lstMonHoc;
            lstbodesource.DataSource = lstbode;
            lstHocSinhsource.DataSource = lstHocSinh;
            lstLopsource.DataSource = lstLop;
        }

        private void View_SubjectChange(object sender, EventArgs e)
        {
            string idkhoilop = view.KhoiLopChon;
            int idmonhoc = int.Parse(view.monHocChon);
            lstbode = FindBymonHocIdVaLopId(idmonhoc, idkhoilop);

            lstbodesource.DataSource = lstbode;
            view.lstDeThi.DataSource = lstbodesource;
        }

        private void View_MoveLeft(object sender, EventArgs e)
        {
            if (lstHocSinh == null)
                lstHocSinh = new BindingList<thongTin>();
            foreach (DataGridViewRow i in view.lstThiSinh.SelectedRows)
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
            FillStudent();
            
        }

        private void FillStudent()
        {
            lstThiSinhsource.DataSource = lstThiSinh;
            lstHocSinhsource.DataSource = lstHocSinh;
            view.lstHocSinh.DataSource = lstHocSinhsource;
            view.lstThiSinh.DataSource = lstThiSinhsource;
        }

        private void View_MoveRight(object sender, EventArgs e)
        {
            if (lstThiSinh == null)
                lstThiSinh = new BindingList<thongTin>();
            foreach (DataGridViewRow i in view.lstHocSinh.SelectedRows)
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
            FillStudent();
        }





        private void View_Submit(object sender, EventArgs e)
        {
            if (lstThiSinh == null || view.DeThiChon == null)
            {
                view.ShowMessage("Thiết thông tin để tạo lịch thi");
                return;
            }
            using (var db = new QuizDataContext())
            {
                int malt = db.lichThis.DefaultIfEmpty().Max(p => p == null ? 0 : p.maLichThi);
                foreach (thongTin i in lstThiSinh)
                {
                    db.lichThis.InsertOnSubmit(new lichThi
                    {
                        maLichThi = (malt + 1),
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

        private BindingList<boDe> FindBymonHocIdVaLopId(int maMH, string makhoi)
        {
            BindingList<boDe> lstbd;
            using (var db = new QuizDataContext())
            {
                lstbd = new BindingList<boDe>(db.boDes.Where(p => p.maMon == maMH).Where(k => k.maKhoi == makhoi).ToList());
            }
            return lstbd;
        }

        private BindingList<thongTin> FindByBoDeId(string mak)
        {
            BindingList<thongTin> lsttt = new BindingList<thongTin>();
            using (var db = new QuizDataContext())
            {
                var temp = db.Lops.Where(l => l.maKhoiLop == mak).Join(db.thongTins,
                                            lh => lh.maLopHoc,
                                            tt => tt.maLopHoc,
                                            (lh, tt) => new { tt = tt }).ToList();

                foreach (var i in temp)
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
