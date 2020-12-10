using quiz_management.Models;
using quiz_management.Views.Student.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.Main
{
    class MainStudentPresenter
    {
        IMainStudentView view;
        thongTin info=null;
        string lop=null;
        public MainStudentPresenter(IMainStudentView v)
        {
            view = v;

            Initialize();
        }

        private void Initialize()
        {
            view.EditProfile += View_EditProfile;
            using (var user = new QuizDataContext())
            {
                info = (thongTin)user.nguoiDungs.Join(user.thongTins,
                p => p.maNguoiDung,
                c => c.maNguoidung,
                (p, c) => new { p = p, c = c }).Where(a => a.p.maNguoiDung == view.User.maNguoiDung)
                .Select(kq => kq.c);

                lop = user.thongTins.Join(user.Lops,
                p => p.maLopHoc,
                c => c.maLopHoc,
                (p, c) => new { p = p, c = c }).Where(a => a.p.maLopHoc == info.maLopHoc).Select(kq => kq.c.tenLopHoc).ToString();
            }
            FillLH();
        }

        private void FillLH()
        {
            if (info != null)
            {
                view.IdHS = info.maNguoidung.ToString();
                view.NameHS = info.tenNguoiDung;
                view.DOBHS = info.ngaySinh.ToString();
                view.LopHS = lop;
            }
        }

        private void View_EditProfile(object sender, EventArgs e)
        {
            
        }

    }
}
