using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Register
{
    interface IRegisterView
    {
        string Username { get; set; }
        string Password { get; set; }
        string FullName { get; set; }
        string Birthday { get; set; }
        
        event EventHandler Submit;
        void ShowMessage(string text);
    }
}
