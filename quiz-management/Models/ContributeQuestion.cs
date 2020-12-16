using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class ContributeQuestion
    {
        string _maDongGop;
        string _tenNguoiDung;
        string _tenMonHoc;
        string _trangThai;
        string _ngay;
        string _cauHoi;
        string _khoiLop;

        public string MaDongGop { get => _maDongGop; set => _maDongGop = value; }
        public string TenNguoiDung { get => _tenNguoiDung; set => _tenNguoiDung = value; }
        public string TenMonHoc { get => _tenMonHoc; set => _tenMonHoc = value; }
        public string TrangThai { get => _trangThai; set => _trangThai = value; }
        public string Ngay { get => _ngay; set => _ngay = value; }
        public string CauHoi { get => _cauHoi; set => _cauHoi = value; }
        public string KhoiLop { get => _khoiLop; set => _khoiLop = value; }
    }
}
