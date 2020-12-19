using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class TestSchedule
    {
        private int _maLichThi;
        private int _maDe;
        List<thongTin> _thiSinh;
        private int _sLThiSinh;
        private int _maMonHoc;
        private string _tenMonHoc;
        private DateTime _ngayThi;

        public int MaLichThi { get => _maLichThi; set => _maLichThi = value; }
        public int MaDe { get => _maDe; set => _maDe = value; }
    
        public int MaMonHoc { get => _maMonHoc; set => _maMonHoc = value; }
        public string TenMonHoc { get => _tenMonHoc; set => _tenMonHoc = value; }
        public DateTime NgayThi { get => _ngayThi; set => _ngayThi = value; }
        public List<thongTin> ThiSinh { get => _thiSinh; set => _thiSinh = value; }
        public int SLThiSinh { get => _sLThiSinh; set => _sLThiSinh = value; }
    }
}
