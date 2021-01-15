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
    class UpdateExamPresenter
    {
        IUpdateExamView view;
        int currentcode;
        int currentuser;
        BindingList<thongTin> lstHocSinh;
        BindingList<thongTin> lstThiSinh;
        DateTime ngaythi;
        boDe DeThiChon;
        monHoc MonHocChon;
        khoiLop KhoiLopChon;



        public UpdateExamPresenter(IUpdateExamView v, int code, int userid)
        {
            view = v;
            currentcode = code;
            currentuser = userid;
            Initialize();
        }

        private void Initialize()
        {
            view.GoBackBefore += View_Back;
            view.Submit += View_Submit;
            view.MoveRight += View_MoveRight;
            view.MoveLeft += View_MoveLeft;

            lstThiSinh = new BindingList<thongTin>();
            lstHocSinh = new BindingList<thongTin>();


            using (var db = new QuizDataContext())
            {
                var temp = db.lichThis.Where(l => l.maLichThi == currentcode)
                    .GroupBy(x => x.maLichThi).Select(xs => new { lt = xs.Select(d => d) }).ToList();

                var lstlichthi = temp[0].lt.ToList();
                KhoiLopChon = lstlichthi[0].boDe.khoiLop;
                DeThiChon = lstlichthi[0].boDe;
                MonHocChon = lstlichthi[0].monHoc;
                ngaythi = lstlichthi[0].ngayThi;

                lstHocSinh = FindByBoDeId(KhoiLopChon.maKhoiLop);

                foreach (var i in temp)
                {
                    var thisinh = i.lt.ToList();
                    for (int k = 0; k < thisinh.Count; k++)
                    {
                        thongTin tt = new thongTin();
                        tt = lstHocSinh.Where(x => x.maNguoidung == thisinh[k].maNguoiDung).SingleOrDefault();
                        lstThiSinh.Add(tt);
                        lstHocSinh.Remove(tt);
                    }
                }
            }
            Fill();
        }


        private void Fill()
        {
            view.NgayThi = ngaythi.Day + "/" + ngaythi.Month + "/" + ngaythi.Year;
            view.lstHocSinh = lstHocSinh;
            view.lstThiSinh = lstThiSinh;
            view.monHocChon = MonHocChon.tenMonHoc;
            view.DeThiChon = DeThiChon.maBoDe.ToString();
            view.KhoiLopChon = KhoiLopChon.tenKhoiLop;


        }

       

        private void View_MoveLeft(object sender, EventArgs e)
        {
            if (lstHocSinh == null)
                lstHocSinh = new BindingList<thongTin>();
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
                lstThiSinh = new BindingList<thongTin>();
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

        private void View_Submit(object sender, EventArgs e)
        {
            if (lstThiSinh == null)
            {
                view.ShowMessage("Cần có thi Sinh Thi.");
                return;
            }
            using (var db = new QuizDataContext())
            {
                var ltdelete = db.lichThis.Where(p => p.maLichThi == currentcode).ToList();
                for (int d = 0; d < ltdelete.Count; d++)
                    db.lichThis.DeleteOnSubmit(ltdelete[d]);
                db.SubmitChanges();

                foreach (thongTin i in lstThiSinh)
                {
                    db.lichThis.InsertOnSubmit(new lichThi
                    {
                        maLichThi = currentcode,
                        maNguoiDung = i.maNguoidung,
                        maMonHoc = MonHocChon.maMonHoc,
                        ngayThi = ngaythi,
                        maBoDe = DeThiChon.maBoDe
                    });
                }
                db.SubmitChanges();
            }
            view.ShowMessage("Thành Công.");
        }

        private void View_Back(object sender, EventArgs e)
        {
            view.ShowExamListView(currentuser);
        }
    }
}
