using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class CreatePaperWithQuestion
    {
        string _quesionID;
        string _question;
        
        public string Question { get => _question; set => _question = value; }
        public string QuestionID { get => _quesionID; set => _quesionID = value; }
    }
}
