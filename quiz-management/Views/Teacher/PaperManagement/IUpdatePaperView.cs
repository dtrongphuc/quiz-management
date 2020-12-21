using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.PaperManagement
{
    interface IUpdatePaperView
    {
        string TeacherName { set; }
        string PaperID { get; set; }
        List<khoiLop> GradeList { set; }
        int Gradeselected { set; }
        string Grade { get; }
        List<monHoc> SubjectList { set; }
        string Subject { get; }
        int Subjectseleted { set; }
        BindingList<CreatePaperWithQuestion> listQuestion { set; }
        BindingList<CreatePaperWithQuestion> listQuestionselected { set; }
        DataGridView AllQuestion { get; }
        DataGridView AllQuestionSelect { get; }

        event EventHandler GoBackBefore;
        event EventHandler MoveToRight;
        //event EventHandler MoveAllToRight;
        event EventHandler MoveToLeft;
        //event EventHandler MoveAllToLeft;
        event EventHandler UpdatePaper;
        event EventHandler GradeChange;
        event EventHandler SubjectChange;

        void ShowMessage(string text);
        void ShowPaperListView(int code);
    }
}
