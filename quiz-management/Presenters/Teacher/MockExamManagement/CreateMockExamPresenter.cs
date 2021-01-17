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
    public class CreateMockExamPresenter
    {
        private ICreateMockExamView view;
        private int currentcode;
        private BindingList<thongTin> lstHocSinh;
        private BindingList<monHoc> lstMonHoc;
        private BindingList<khoiLop> lstLop;
        private BindingList<boDe> lstbode;
        private BindingList<thongTin> lstThiSinh;

        public CreateMockExamPresenter(ICreateMockExamView v, int code)
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

        private void Fill()
        {
            view.lstMonHoc = lstMonHoc;
            view.lstDeThi = lstbode;
            view.lstHocSinh = lstHocSinh;
            view.lstKhoiLop = lstLop;
        }

        private BindingList<thongTin> FindByBoDeId(string mak)
        {
            BindingList<thongTin> lsttt = new BindingList<thongTin>();
            using (var db = new QuizDataContext())
            {
                var temp = db.Lops.Where(l => l.maKhoiLop == mak).Join(db.thongTins,
                                            lh => lh.maLopHoc,
                                            tt => tt.maLopHoc,
                                            (lh, tt) => new { tt = tt }).Where(p => p.tt.maNguoidung != 3).ToList();
                lsttt = new BindingList<thongTin>(db.thongTins.Where(p => p.maNguoidung == 2).ToList());
                foreach (var i in temp)
                {
                    thongTin t = new thongTin();
                    t = i.tt;
                    lsttt.Add(t);
                }
            }
            return lsttt;
        }

        private BindingList<boDe> FindBymonHocIdVaLopId(int maMH, string makhoi)
        {
            BindingList<boDe> lstbd;
            using (var db = new QuizDataContext())
            {
                lstbd = new BindingList<boDe>(db.boDes.Where(p => p.maMon == maMH).Where(k => k.maKhoi == makhoi)
                                            .Where(c => c.trangThai == 0).ToList());
            }
            return lstbd;
        }

        private void View_ClassChange(object sender, EventArgs e)
        {
            string idkhoilop = view.KhoiLopChon;
            int idmonhoc = int.Parse(view.monHocChon);
            lstbode = FindBymonHocIdVaLopId(idmonhoc, idkhoilop);
            view.lstDeThi = lstbode;

            lstHocSinh = FindByBoDeId(idkhoilop);
            lstThiSinh = null;
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

        private void View_MoveRight(object sender, EventArgs e)
        {
            if (lstThiSinh == null)
                lstThiSinh = new BindingList<thongTin>();
            DataGridView a = view.lstHocSinhChon;
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

        private void View_SubjectChange(object sender, EventArgs e)
        {
            string idkhoilop = view.KhoiLopChon;
            int idmonhoc = int.Parse(view.monHocChon);
            lstbode = FindBymonHocIdVaLopId(idmonhoc, idkhoilop);
            view.lstDeThi = lstbode;
        }

        private void View_Submit(object sender, EventArgs e)
        {
            if (view.NgayBD.Date > view.NgayKT.Date)
            {
                view.ShowMessage("Ngày Không Tồn Tại");
                return;
            }
            if (lstThiSinh == null || view.lstBoDeChon.SelectedRows.Count == 0)
            {
                view.ShowMessage("Thiết thông tin để tạo lịch thi");
                return;
            }
            using (var db = new QuizDataContext())
            {
                int malt = db.kyThiThus.ToList().Count == 0 ? 0 : db.kyThiThus.Max(i => i.maKyThiThu);

                foreach (thongTin i in lstThiSinh)
                {
                    foreach (DataGridViewRow k in view.lstBoDeChon.SelectedRows)
                    {
                        var x = k.Cells["maBoDe"].Value;
                        db.kyThiThus.InsertOnSubmit(new kyThiThu
                        {
                            maKyThiThu = (malt + 1),
                            maNguoiDung = i.maNguoidung,
                            maMonHoc = int.Parse(view.monHocChon),
                            ngayThi = view.NgayBD,
                            ngayKT = view.NgayKT,
                            maKhoiLop = view.KhoiLopChon,
                            maBoDe = int.Parse(k.Cells["maBoDe"].Value.ToString())
                        });
                    }
                    db.SubmitChanges();
                }
            }
            view.ShowMessage("Thành Công.");
        }

        private void View_Back(object sender, EventArgs e)
        {
            view.ShowExamListView(currentcode);
        }
    }
}