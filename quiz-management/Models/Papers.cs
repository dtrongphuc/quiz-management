using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class Papers
    {
        string _paperID;
        string _subject;
        string _grade;
        int _questionNum;
        string _status;

        public string PaperCode { get => _paperID; set => _paperID = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public string Grade { get => _grade; set => _grade = value; }
        public int QuestionNum { get => _questionNum; set => _questionNum = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
