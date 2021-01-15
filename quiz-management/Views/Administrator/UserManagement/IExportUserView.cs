using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Administrator.UserManagement
{
    internal interface IExportUserView
    {
        string AdminName { set; }
        BindingList<InfoUser> UserList { set; }
    }
}