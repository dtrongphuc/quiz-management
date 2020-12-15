using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class TestSchedule
    {
        private string _tenMonHoc;
        private string _ngayThi;

        public string TenMonHoc { get => _tenMonHoc; set => _tenMonHoc = value; }
        public string NgayThi { get => _ngayThi; set => _ngayThi = value; }
    }
}
