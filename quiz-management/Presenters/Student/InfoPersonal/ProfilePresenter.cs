using quiz_management.Models;
using quiz_management.Views.Student.InfoPersonal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Student.InfoPersonal
{
    internal class ProfilePresenter
    {
        private IProfileView view;
        private int currentUserCode;
        private thongTin info = null;
        private Lop lop = null;
        private BindingList<Lop> lstLop = null;

        public ProfilePresenter(IProfileView v, int code)
        {
            view = v;
            currentUserCode = code;
            Initialize();
        }

        private void Initialize()
        {
            view.Updatebtn += View_Updatebtn;
            view.Closebtn += View_Closebtn;
            using (var db = new QuizDataContext())
            {
                var i = db.nguoiDungs.Join(db.thongTins,
                p => p.maNguoiDung,
                c => c.maNguoidung,
                (p, c) => new { p = p, c = c }).Where(a => a.p.maNguoiDung == currentUserCode)
                .Select(kq => kq.c).ToList();

                if (i.Count > 0)
                {
                    info = i[0];

                    var x = db.thongTins.Join(db.Lops,
                        p => p.maLopHoc,
                        c => c.maLopHoc,
                        (p, c) => new { p = p, c = c }).Where(a => a.p.maLopHoc == info.maLopHoc).Select(kq => kq.c);
                    var temp2 = x.ToList();

                    if (temp2.Count > 0) lop = temp2[0];
                }

                lstLop = new BindingList<Lop>( db.Lops.ToList());
            }
            FillHS();
        }

        private void FillHS()
        {
            view._hoTen = info.tenNguoiDung;
            view._maSo = info.maNguoidung.ToString();
            view._ngaysinh = info.ngaySinh.Value.Date.ToString("d/M/yyyy");
            //view._ngaysinh = info.ngaySinh.Value.Day + "/" + info.ngaySinh.Value.Month + "/" + info.ngaySinh.Value.Year;
            view._lop = lstLop;
            view._lopChon = lop;
        }

        private void View_Closebtn(object sender, EventArgs e)
        {
            view.swichMainStudent(int.Parse(view._maSo));
        }

        private void View_Updatebtn(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.ParseExact(view._ngaysinh, "d/M/yyyy", CultureInfo.InvariantCulture);
                using (var db = new QuizDataContext())
                {
                    var temp = db.thongTins.SingleOrDefault(d => d.maNguoidung == int.Parse(view._maSo));
                    temp.tenNguoiDung = view._hoTen;
                   /* var x = DateTime.Parse(view._ngaysinh);*/
                    temp.ngaySinh = dt;
                    temp.maLopHoc = view._lopChon.maLopHoc;

                    db.SubmitChanges();
                }
                view.swichMainStudent(int.Parse(view._maSo));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!!");
            }
        }
    }
}