using quiz_management.Models;
using quiz_management.Views.Teacher.ExamManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.ExamManagement
{
    internal class WatchOrPrintExamCompletedPresenter
    {
        private IWatchOrPrintExamCompletedView view;
        private int currentcode;
        private thongTin TenGV;
        private BindingList<TrainScript> lstkq;

        public WatchOrPrintExamCompletedPresenter(IWatchOrPrintExamCompletedView v, int code)
        {
            view = v;
            currentcode = code;
            Initialize();
        }

        private void Initialize()
        {
            view.GobackBefore += View_GoBackBefore;
            lstkq = new BindingList<TrainScript>();
            using (var db = new QuizDataContext())
            {
                TenGV = db.thongTins.Where(p => p.maNguoidung == currentcode).SingleOrDefault();
                var temp = db.ketQuas.Where(p => p.trangThai == 1)
                            .Join(db.thongTins,
                            c => c.maNguoiDung,
                            d => d.maNguoidung,
                            (c, d) => new { kq = c, tt = d }).Join(db.boDes, v => v.kq.maBoDe,
                            z => z.maBoDe,
                            (v, z) => new { id = v.kq.maKetQua, ten = v.tt.tenNguoiDung, monhoc = z.maMon, de = z.maBoDe, ngaythi = v.kq.ngayLam, diem = v.kq.diem })
                            .Join(db.monHocs,
                            t => t.monhoc,
                            mh => mh.maMonHoc,
                            (t, mh) => new { id = t.id, tennguoidung = t.ten, tenmonhoc = mh.tenMonHoc, mabode = t.de, ngaylam = t.ngaythi, diem = t.diem }).ToList();
                for (int i = 0; i < temp.Count; i++)
                {
                    TrainScript ts = new TrainScript();
                    ts.STT = i + 1;
                    ts.StudentName = temp[i].tennguoidung;
                    ts.MaKQ = temp[i].id;
                    ts.PaperID = temp[i].mabode;
                    ts.SubjectName = temp[i].tenmonhoc;
                    ts.Date = temp[i].ngaylam.Value;
                    ts.Score = (float)temp[i].diem;
                    lstkq.Add(ts);
                }
            }
            FILL();
        }

        private void FILL()
        {
            view.TeacherName = TenGV.tenNguoiDung;
            view.ExamList = lstkq;
        }

        private void View_GoBackBefore(object sender, EventArgs e)
        {
            view.Home(currentcode);
        }
    }
}