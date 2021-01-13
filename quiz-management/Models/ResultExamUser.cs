using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class ResultExamUser
    {
        private int _maHocSinh;
        private string _tenHocSinh;
        private string _lop;
        private DateTime _ngaySinh;

        public int MaHocSinh { get => _maHocSinh; set => _maHocSinh = value; }
        public string TenHocSinh { get => _tenHocSinh; set => _tenHocSinh = value; }
        public string Lop { get => _lop; set => _lop = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
    }
}