using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class InfoUser
    {
        string _sTT;
        string _userName;
        DateTime _dOB;
        string _desentralization;

        public string STT { get => _sTT; set => _sTT = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public DateTime DOB { get => _dOB; set => _dOB = value; }
        public string Desentralization { get => _desentralization; set => _desentralization = value; }
    }
}
