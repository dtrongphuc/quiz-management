using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class StudentOfExam
    {
        int _sTT;
        string _studentName;
        string _dOBExam; //tên kì thi: thi thử - thi chính thức
        public int STT { get => _sTT; set => _sTT = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public string DOBExam { get => _dOBExam; set => _dOBExam = value; }
    }
}
