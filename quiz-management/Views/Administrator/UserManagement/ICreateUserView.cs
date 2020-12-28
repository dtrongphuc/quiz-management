using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Administrator.UserManagement
{
    interface ICreateUserView
    {
        string AdminName { set; }
        string UserName { get; }
        string Pass { get; }
        string DOB { set; }
        string Desentralization { get; }
        event EventHandler CreateUser;
        event EventHandler GoBackBefore;

        void ShowMessages(string text);
        void ShowMainAdmin(int userCode);
    }
}
