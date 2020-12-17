using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.PaperManagement
{
    interface ICreatePaperView
    {
        string TeacherName { set; }
        string PaperID { get; }
        List<khoiLop> GradeList {set; }
        List<CreatePaperWithQuestion> listQuestion { set; }
        List<CreatePaperWithQuestion> listQuestionselected { set; }
        string QuestionID { get; }
        string Question { get;}
        DataGridView AllQuestion { get; }
        DataGridView AllQuestionSelect { get; }

        event EventHandler GoBackBefore;
        event EventHandler MoveToRight;
        event EventHandler MoveAllToRight;
        event EventHandler MoveToLeft;
        event EventHandler MoveAllToLeft;
        event EventHandler CreatePaper;

        void ShowMessage(string text);
        void MainTeacherView(int code);
    }
}
