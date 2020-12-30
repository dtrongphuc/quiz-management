using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class MockExam
    {
        int _sTT;
        string _subject;
        string _grade;
        string _startDay;
        string _endDay;
        int _totalStudent;

        public int STT { get => _sTT; set => _sTT = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public string Grade { get => _grade; set => _grade = value; }
        public string StartDay { get => _startDay; set => _startDay = value; }
        public string EndDay { get => _endDay; set => _endDay = value; }
        public int TotalStudent { get => _totalStudent; set => _totalStudent = value; }
    }
}
