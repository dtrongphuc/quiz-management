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
    interface ICreatePaperView
    {
        string TeacherName { set; }
        //string PaperID { get; set; }
        List<khoiLop> GradeList {set; }
        string Grade { get; }
        string ExamChoose { get; } //chon thi thử / thi chính thức
        List<monHoc> SubjectList { set; }
        string Subject { get; }
        BindingList<CreatePaperWithQuestion> listQuestion { set; }
        BindingList<CreatePaperWithQuestion> listQuestionselected { set; }
        string QuestionID { get; }
        string Question { get;}
        DataGridView AllQuestion { get; }
        DataGridView AllQuestionSelect { get; }

        event EventHandler GoBackBefore;
        event EventHandler MoveToRight;
        //event EventHandler MoveAllToRight;
        event EventHandler MoveToLeft;
        //event EventHandler MoveAllToLeft;
        event EventHandler CreatePaper;
        event EventHandler WatchPaperList;
        event EventHandler GradeChange;
        event EventHandler SubjectChange;
        event EventHandler ExamChange;

        void ShowMessage(string text);
        void ShowMainTeacherView(int code);
        void ShowPaperListView(int code);
    }
}
