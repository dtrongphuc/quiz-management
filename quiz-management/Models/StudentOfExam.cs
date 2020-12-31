using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class StudentOfExam
    {
        int STT;
        string StudentName;
        string ExamName; //tên kì thi: thi thử - thi chính thức

        public int STT1 { get => STT; set => STT = value; }
        public string StudentName1 { get => StudentName; set => StudentName = value; }
        public string ExamName1 { get => ExamName; set => ExamName = value; }
    }
}
