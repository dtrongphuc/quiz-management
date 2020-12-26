using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    internal class StudentStatistic
    {
        private thongTin _hocSinh;
        private monHoc _monHoc;
        private double _diem;
        private string _lop;

        public thongTin HocSinh { get => _hocSinh; set => _hocSinh = value; }
        public monHoc MonHoc { get => _monHoc; set => _monHoc = value; }
        public double Diem { get => _diem; set => _diem = value; }
        public string Lop { get => _lop; set => _lop = value; }
    }
}