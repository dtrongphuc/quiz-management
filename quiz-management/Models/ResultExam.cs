using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class ResultExam
    {

        string _tenNguoiDung;
        string _maBoDe;
        string _cauSai;
        string _cauDung;
        string _chuaLam;
        string _ngayLam;
        string _thoiGian;
        string _diem;
        string _monHoc;

        public string TenNguoiDung { get => _tenNguoiDung; set => _tenNguoiDung = value; }
        public string MaBoDe { get => _maBoDe; set => _maBoDe = value; }
        public string CauSai { get => _cauSai; set => _cauSai = value; }
        public string CauDung { get => _cauDung; set => _cauDung = value; }
        public string ChuaLam { get => _chuaLam; set => _chuaLam = value; }
        public string NgayLam { get => _ngayLam; set => _ngayLam = value; }
        public string ThoiGian { get => _thoiGian; set => _thoiGian = value; }
        public string Diem { get => _diem; set => _diem = value; }
        public string MonHoc { get => _monHoc; set => _monHoc = value; }
    }
}
