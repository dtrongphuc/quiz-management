using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class User
    {
        private string _tenTaiKhoan;
        private string _matKhau;
        private string _phanQuyen;
        private string _trangThai;
        private string _tenNguoiDung;
        private DateTime _ngaySinh;
        private int _maLopHoc;

        public string TenTaiKhoan { get => _tenTaiKhoan; set => _tenTaiKhoan = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string PhanQuyen { get => _phanQuyen; set => _phanQuyen = value; }
        public string TrangThai { get => _trangThai; set => _trangThai = value; }
        public string TenNguoiDung { get => _tenNguoiDung; set => _tenNguoiDung = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public int MaLopHoc { get => _maLopHoc; set => _maLopHoc = value; }
    }
}