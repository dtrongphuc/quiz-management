using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Login
{
    interface ILoginView
    {
        string Username { get; set; }
        string Password { get; set; }

        event EventHandler Submit;
        event EventHandler SwitchToRegisterView;

        void ShowMessage(string text);
        void ShowRegisterView();
        void ShowStudentView(int userCode);
        void ShowTeacherView(int userCode);
        void ShowAdminView(int userCode);
    }
}
