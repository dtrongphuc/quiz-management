using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class ResultExam
    {
        private string _tenNguoiDung;
        private string _lop;
        private DateTime _ngaySinh;
        private string _maBoDe;
        private string _cauSai;
        private string _cauDung;
        private string _chuaLam;
        private string _ngayLam;
        private string _thoiGian;
        private string _diem;
        private string _monHoc;

        public string TenNguoiDung { get => _tenNguoiDung; set => _tenNguoiDung = value; }
        public string MaBoDe { get => _maBoDe; set => _maBoDe = value; }
        public string CauSai { get => _cauSai; set => _cauSai = value; }
        public string CauDung { get => _cauDung; set => _cauDung = value; }
        public string ChuaLam { get => _chuaLam; set => _chuaLam = value; }
        public string NgayLam { get => _ngayLam; set => _ngayLam = value; }
        public string ThoiGian { get => _thoiGian; set => _thoiGian = value; }
        public string Diem { get => _diem; set => _diem = value; }
        public string MonHoc { get => _monHoc; set => _monHoc = value; }
        public string Lop { get => _lop; set => _lop = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
    }
}