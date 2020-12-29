using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Administrator.UserManagement
{
    interface ICreateUserView
    {
        string AdminName { set; }
        string UserName { get; }
        string AcountName { get; }
        string Pass { get; }
        string Datenow { set; }
        string Desentralization { get; }
        string classID { get; }
        DateTime DOB { get; }
        List<Lop> ClassList { set; }
        bool cbbAllClass { set; }
        event EventHandler CreateUser;
        event EventHandler GoBackBefore;
        event EventHandler ChangeCbbDesentralization;

        void ShowMessages(string text);
        void ShowMainAdmin(int userCode);
    }
}
