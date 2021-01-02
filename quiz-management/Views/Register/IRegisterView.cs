using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Register
{
    internal interface IRegisterView
    {
        string Username { get; set; }
        string Password { get; set; }
        string FullName { get; set; }
        string Birthday { get; set; }
        object ComboboxDataSource { set; }
        object SelectedClass { get; }
        bool isStudent { get; }

        event EventHandler Submit;

        event EventHandler SwitchToLoginView;

        void ShowMessage(string text);

        void ShowLoginView();
    }
}