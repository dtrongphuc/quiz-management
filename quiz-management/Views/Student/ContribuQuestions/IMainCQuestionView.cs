using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.ContribuQuestions
{
    interface IMainCQuestionView
    {
        BindingList<string> classes { get; set; }
        string Subject { get;}
        string Question { get; set; }
        string AnswerA { get; }
        string AnswerB { get; }
        string AnswerC { get; }
        string AnswerD { get; }
        string AnswerE { get; }
        string AnswerF { get; }
        event EventHandler Send;
        event EventHandler Pre;
    }
}
