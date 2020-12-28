using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.Main
{
    interface ITeacherInfoView
    {
        string TeacherName { get; set; }
        string TeacherID { set; }
        string DOB { get; set; }

        event EventHandler ClosePage;
        event EventHandler UpdateInfo;

        void ShowMainTeacher(int code);
        void ShowMessage(string text);
    }
}
