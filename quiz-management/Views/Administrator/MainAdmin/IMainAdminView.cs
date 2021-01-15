using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Administrator.MainAdmin
{
    interface IMainAdminView
    {
        string DOB { set; }
        string AdminName { set; }
        event EventHandler AddUser;
        event EventHandler WatchUserList;
        event EventHandler Desentralization;
        event EventHandler Logout;

        void ShowAddUser(int userCode);
        void ShowWatchUserList(int userCode);
        void ShowDesentralization(int userCode);
        void ShowMessages(string text);
        void ShowLogin();
    }
}
