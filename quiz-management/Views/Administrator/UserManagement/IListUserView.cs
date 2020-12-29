using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Administrator.UserManagement
{
    interface IListUserView
    {
        string AdminName { set; }
        string Datenow { set; }
        string UserID { get; }
        BindingList<InfoUser> UserList { set; }
        event EventHandler UpdateUser;
        event EventHandler GoBackBefore;

        void ShowMessages(string text);
        void ShowMainAdmin(int userCode);
        void ShowUpdate(int userCode, int userid);
    }
}
