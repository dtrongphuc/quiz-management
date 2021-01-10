using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class PracticStatistic
    {
        public int Total { get; set; }
        public int CorrectedCount { get; set; }
        public int WrongCount { get; set; }
    }
}