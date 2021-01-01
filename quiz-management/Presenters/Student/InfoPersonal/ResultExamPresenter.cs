using quiz_management.Models;
using quiz_management.Views.Student.InfoPersonal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.InfoPersonal
{
    class ResultExamPresenter
    {
        IResultExamView view;
        int currentcode;
        List<ketQua> lstKQ =null;
        List<ResultExam> lstkq =null;
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
            view.swichMainStudent(currentcode);
        }

        private void Fill()
        {
           
            view.ResultExam = lstkq;
           
        }


    }
}
