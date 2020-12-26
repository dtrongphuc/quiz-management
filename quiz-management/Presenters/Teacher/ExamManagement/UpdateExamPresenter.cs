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
        BindingList<thongTin> lstHocSinh;
        List<monHoc> lstMonHoc;
        List<boDe> lstbode;
        BindingList<thongTin> lstThiSinh;
        DateTime ngaythi;
        boDe DeThiChon;
        monHoc MonHocChon;

        public UpdateExamPresenter(IUpdateExamView v, int code)
        {
            view = v;
            currentcode = code;
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
                lstMonHoc = db.monHocs.ToList();
                var lstlichthi = temp[0].lt.ToList();
                var makhoi = lstlichthi[0].boDe.maKhoi;
                DeThiChon = lstlichthi[0].boDe;
                MonHocChon = lstlichthi[0].monHoc;
                ngaythi = lstlichthi[0].ngayThi;
                
                if (lstMonHoc.Count != 0) lstbode = FindBymonHocId(int.Parse(MonHocChon.maMonHoc.ToString()));
                if (lstbode.Count != 0) lstHocSinh = FindByBoDeId(makhoi);

                foreach (var i in temp)
                {
                    var thisinh = i.lt.ToList();
                    for (int k = 0; k < thisinh.Count; k++)
                    {
                        thongTin tt = new thongTin();
                        tt = lstHocSinh.Where(x => x.maNguoidung == thisinh[k].maNguoiDung).Single();
                        lstThiSinh.Add(tt);
                        lstHocSinh.Remove(tt);
                    }
                }
            }
            Fill();
        }


        private void Fill()
        {
            view.lstDeThi = lstbode;
            view.NgayThi = ngaythi;
            view.lstMonHoc = lstMonHoc;
            view.lstHocSinh = lstHocSinh;
            view.lstThiSinh = lstThiSinh;
            view.monHocChon = MonHocChon;
            view.DeThiChon = DeThiChon;
        }

        

        private void View_MoveLeft(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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

       
        private List<boDe> FindBymonHocId(int maMonHoc)
        {
            List<boDe> lstbd;
            using (var db = new QuizDataContext())
            {
                lstbd = db.boDes.Where(p => p.maMon == maMonHoc).ToList();
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

        private void View_Submit(object sender, EventArgs e)
        {
           /* if (lstThiSinh.Count == 0)
            {
                view.ShowMessage("Cần có thi Sinh Thi.");
                return;
            }
            using (var db = new QuizDataContext())
            {
                int malt = db.lichThis.Max(p => p.maLichThi);
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
            view.ShowMessage("Thành Công.");*/
        }

        private void View_Back(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
