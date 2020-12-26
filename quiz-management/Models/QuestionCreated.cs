using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class QuestionCreated
    {
        string _question;
        string _paperName;
        string _questionID;

        public string Question { get => _question; set => _question = value; }
        public string PaperName { get => _paperName; set => _paperName = value; }
        public string QuestionID { get => _questionID; set => _questionID = value; }
    }
}
