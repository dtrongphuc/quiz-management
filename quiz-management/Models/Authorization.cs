using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    class Authorization
    {
        private int _sTT;
        private string _hoTen;
        private string _ngaySinh;
        private string _quyen;

        public int STT { get => _sTT; set => _sTT = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string Quyen { get => _quyen; set => _quyen = value; }
    }
}
