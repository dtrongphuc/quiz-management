using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class Answer
    {
        private int _maCauTraLoi;
        private string _cauTraLoi;
        private bool _checked;

        public int MaCauTraLoi { get => _maCauTraLoi; set => _maCauTraLoi = value; }
        public string CauTraLoi { get => _cauTraLoi; set => _cauTraLoi = value; }
        public bool Checked { get => _checked; set => _checked = value; }
    }
}