using quiz_management.Models;
using quiz_management.Views.Student.InfoPersonal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.InfoPersonal
{
    internal class ResultExamPresenter
    {
        private IResultExamView view;
        private int currentcode;
        private List<ketQua> lstKQ = null;
        private List<ResultExam> lstkq = null;

        public ResultExamPresenter(IResultExamView v, int code)
        {
            view = v;
            currentcode = code;
            Initialize();
        }

        private void Initialize()
        {
            view.BackMain += View_BackMain;
            lstkq = new List<ResultExam>();
            DateTime dt;
            using (var db = new QuizDataContext())
            {
                lstKQ = db.ketQuas.Where(p => p.maNguoiDung == currentcode)
                                .Where(c => c.trangThai == 1).ToList();

                var dbUser = db.nguoiDungs.SingleOrDefault(n => n.maNguoiDung == currentcode);

                ResultExamUser user = new ResultExamUser
                {
                    MaHocSinh = dbUser.maNguoiDung,
                    TenHocSinh = dbUser.thongTin.tenNguoiDung,
                    Lop = dbUser.thongTin.Lop != null ? dbUser.thongTin.Lop.tenLopHoc : " ",
                    NgaySinh = (DateTime)dbUser.thongTin.ngaySinh
                };

                view.User = user;

                foreach (ketQua kq in lstKQ)
                {
                    dt = kq.ngayLam.Value;
                    ResultExam rs = new ResultExam();
                    rs.MonHoc = kq.boDe.monHoc.tenMonHoc;
                    rs.TenNguoiDung = kq.nguoiDung.thongTin.tenNguoiDung;
                    rs.MaBoDe = kq.maBoDe.ToString();
                    rs.CauSai = kq.cauSai.ToString();
                    rs.CauDung = kq.cauDung.ToString();
                    rs.ChuaLam = kq.chuaLam.ToString();
                    rs.NgayLam = dt.Day + "/" + dt.Month + "/" + dt.Year;
                    rs.ThoiGian = kq.thoiGian.ToString();
                    rs.Diem = kq.diem.ToString();
                    lstkq.Add(rs);
                }
            }

            Fill();
        }

        private void View_BackMain(object sender, EventArgs e)
        {
            using (var db = new QuizDataContext())
            {
                var user = db.nguoiDungs.SingleOrDefault(n => n.maNguoiDung == currentcode);
                if (user.phanQuyen == 1)
                {
                    view.swichMainStudent(currentcode);
                }
                else
                {
                    view.ShowMainTeacherView(currentcode);
                }
            }
        }

        private void Fill()
        {
            view.ResultExam = lstkq;
        }
    }
}