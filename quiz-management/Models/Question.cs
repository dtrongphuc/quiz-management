using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class Question
    {
        private int _maCauHoi;
        private string _cauHoi;
        private bool _checked;
        private List<Answer> _cauTraLoi;

        public int MaCauHoi { get => _maCauHoi; set => _maCauHoi = value; }
        public string CauHoi { get => _cauHoi; set => _cauHoi = value; }
        public bool Checked { get => _checked; set => _checked = value; }
        public List<Answer> CauTraLoi { get => _cauTraLoi; set => _cauTraLoi = value; }
    }
}