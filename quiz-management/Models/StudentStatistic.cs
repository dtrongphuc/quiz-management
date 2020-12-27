using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class StudentStatistic
    {
        private string _maHocSinh;
        private string _tenHocSinh;
        private string _ngaySinh;
        private string _monHoc;
        private double _diem;
        private string _lop;

        public string MaHocSinh { get => _maHocSinh; set => _maHocSinh = value; }
        public string TenHocSinh { get => _tenHocSinh; set => _tenHocSinh = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string Lop { get => _lop; set => _lop = value; }
        public string MonHoc { get => _monHoc; set => _monHoc = value; }
        public double Diem { get => _diem; set => _diem = value; }
    }
}