using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class QuestionStatistic
    {
        private int _maCauHoi;
        private string _cauHoi;
        private double _tiLeRaDe;
        private double _tiLeChonDung;
        private double _tiLeChonSai;

        public int MaCauHoi { get => _maCauHoi; set => _maCauHoi = value; }
        public string CauHoi { get => _cauHoi; set => _cauHoi = value; }
        public double TiLeRaDe { get => _tiLeRaDe; set => _tiLeRaDe = value; }
        public double TiLeChonDung { get => _tiLeChonDung; set => _tiLeChonDung = value; }
        public double TiLeChonSai { get => _tiLeChonSai; set => _tiLeChonSai = value; }
    }
}