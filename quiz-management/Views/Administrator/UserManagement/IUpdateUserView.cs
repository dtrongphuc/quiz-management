using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Administrator.UserManagement
{
    interface IUpdateUserView
    {
        string AdminName { set; }
        string UserName { get; set; }
        string AcountName { set; }
        string Datenow { set;}
        string classselected { get; set; }
        string Desentralization { get; }
        DateTime DOB { get; set; }
        List<Lop> ClassList { set; }
        bool cbbAllClass { set; }
        event EventHandler SaveUpdate;
        event EventHandler GoBackBefore;
        event EventHandler ChangeCbbDesentralization;

        void ShowMessages(string text);
        void ShowListUser(int userCode);
    }
}
