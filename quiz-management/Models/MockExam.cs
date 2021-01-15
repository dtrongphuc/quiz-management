using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class MockExam
    {
        string _ExamID;
        string _subject;
        string _grade;
        string _startDay;
        string _endDay;
        int _userID;
        int _paperID;
        int _quantityStudent;

        public string Subject { get => _subject; set => _subject = value; }
        public string Grade { get => _grade; set => _grade = value; }
        public string StartDay { get => _startDay; set => _startDay = value; }
        public string EndDay { get => _endDay; set => _endDay = value; }
        public string ExamID { get => _ExamID; set => _ExamID = value; }
        public int UserID { get => _userID; set => _userID = value; }
        public int PaperID { get => _paperID; set => _paperID = value; }
        public int QuantityStudent { get => _quantityStudent; set => _quantityStudent = value; }
    }
}
