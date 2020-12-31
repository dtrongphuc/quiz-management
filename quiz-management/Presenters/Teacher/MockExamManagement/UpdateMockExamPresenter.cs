using quiz_management.Models;
using quiz_management.Views.Teacher.MockExamManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.MockExamManagement
{
    public class UpdateMockExamPresenter
    {
        IUpdateMockExamView view;
        int currentcode;
        BindingList<thongTin> lstHocSinh;
        BindingList<thongTin> lstThiSinh;
        DateTime ngayBD;
        DateTime ngayKT;
        BindingList<boDe> lstBode;
        BindingList<boDe> lstDethi;
        monHoc MonHocChon;
        khoiLop KhoiLopChon;
        public UpdateMockExamPresenter(IUpdateMockExamView v, int code)
        {
            view = v;
            currentcode = code;
            Initialize();
        }
        private void Initialize()
        {
            view.MoveLeft += View_MoveLeft;
            view.MoveRight += View_MoveRight;
            view.Submit += View_Submit;
            view.GoBackBefore += View_GoBackBefore;
            view.MoveLeftBoDe += View_MoveLeftBoDe;
            view.MoveRightBoDe += View_MoveRightBoDe;

            lstThiSinh = new BindingList<thongTin>();
            lstHocSinh = new BindingList<thongTin>();
            lstBode = new BindingList<boDe>();
            lstDethi = new BindingList<boDe>();

            using (var db = new QuizDataContext())
            {
                var temp = db.kyThiThus.Where(l => l.maKyThiThu == currentcode)
                    .GroupBy(x => x.maKyThiThu).Select(xs => new { lt = xs.Select(d => d) }).ToList();
                var lstkyThi = temp[0].lt.ToList();
                KhoiLopChon = lstkyThi[0].boDe.khoiLop;
                MonHocChon = lstkyThi[0].monHoc;
                ngayBD = lstkyThi[0].ngayThi.Value;
                ngayKT = lstkyThi[0].ngayKT.Value;

                lstHocSinh = FindByBoDeId(KhoiLopChon.maKhoiLop);
                lstBode = FindBymonHocIdVaLopId(MonHocChon.maMonHoc, KhoiLopChon.maKhoiLop);

                foreach (var i in temp)
                {
                    var ct = i.lt.ToList();
                    for (int k = 0; k < ct.Count; k++)
                    {
                        thongTin tt = new thongTin();
                        boDe de = new boDe();
                        tt = lstHocSinh.Where(x => x.maNguoidung == ct[k].maNguoiDung).SingleOrDefault();
                        de = lstBode.Where(x => x.maBoDe == ct[k].maBoDe).SingleOrDefault();
                        if (tt != null) lstThiSinh.Add(tt);
                        lstHocSinh.Remove(tt);
                        if(de != null)lstDethi.Add(de);
                        lstBode.Remove(de);
                    }
                }
            }
            Fill();

        }

        private void View_MoveRightBoDe(object sender, EventArgs e)
        {
            if (lstDethi == null)
                lstDethi = new BindingList<boDe>();
            foreach (DataGridViewRow i in view.lstBoDeChon.SelectedRows)
            {
                var id = i.Cells["maBoDe"].Value.ToString();

                var temp = lstBode.Where(x => x.maBoDe == int.Parse(id)).ToList();
                boDe tt = new boDe();
                tt = temp[0];
                lstDethi.Add(tt);
                lstBode.Remove(tt);
                if (lstBode.Count == 0)
                    lstBode = null;
            }
            view.lstBoDe = lstBode;
            view.lstDeThi = lstDethi;
        }

        private void View_MoveLeftBoDe(object sender, EventArgs e)
        {
            if (lstBode == null)
                lstBode = new BindingList<boDe>();
            foreach (DataGridViewRow i in view.lstDeThiChon.SelectedRows)
            {
                var id = i.Cells["maDeThi"].Value.ToString();

                var temp = lstDethi.Where(x => x.maBoDe == int.Parse(id)).ToList();
                boDe tt = new boDe();
                tt = temp[0];
                lstBode.Add(tt);
                lstDethi.Remove(tt);
                if (lstDethi.Count == 0)
                    lstDethi = null;
            }
            view.lstBoDe = lstBode;
            view.lstDeThi = lstDethi;
        }

        private void Fill()
        {
            view.ngayBD = ngayBD;
            view.ngayKT = ngayKT;
            view.khoiLopChon = KhoiLopChon.tenKhoiLop;
            view.monHoc = MonHocChon.tenMonHoc;
            view.lstHocSinh = lstHocSinh;
            view.lstThiSinh = lstThiSinh;
            view.lstDeThi = lstDethi;
            view.lstBoDe = lstBode;
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

        private BindingList<thongTin> FindByBoDeId(string maKhoiLop)
        {
            BindingList<thongTin> lsttt = new BindingList<thongTin>();
            using (var db = new QuizDataContext())
            {
                var temp = db.Lops.Where(l => l.maKhoiLop == maKhoiLop).Join(db.thongTins,
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

        private void View_GoBackBefore(object sender, EventArgs e)
        {
            view.ShowExamListView(currentcode);
        }

        private void View_Submit(object sender, EventArgs e)
        {
            if (lstDethi == null || lstThiSinh == null)
            {
                view.ShowMessage("Cần có thi Sinh Thi.");
                return;
            }
            using (var db = new QuizDataContext())
            {
                var ktdelete = db.kyThiThus.Where(p => p.maKyThiThu == currentcode).ToList();
                for (int d = 0; d < ktdelete.Count; d++)
                    db.kyThiThus.DeleteOnSubmit(ktdelete[d]);
                db.SubmitChanges();


                foreach (thongTin i in lstThiSinh)
                {
                    foreach (var k in lstDethi)
                    {
                        
                        db.kyThiThus.InsertOnSubmit(new kyThiThu
                        {
                            maKyThiThu = currentcode,
                            maNguoiDung = i.maNguoidung,
                            maMonHoc = MonHocChon.maMonHoc,
                            ngayThi = view.ngayBD,
                            ngayKT = view.ngayKT,
                            maKhoiLop = KhoiLopChon.maKhoiLop,
                            maBoDe = k.maBoDe
                        });
                    }
                }
                db.SubmitChanges();
            }
            view.ShowMessage("Thành Công.");
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

        
    }
}
