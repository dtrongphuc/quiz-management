using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.Interface
{
    interface IInfoPersonalView
    {
        string _maSo { set; }
        string _hoTen { get; set; }
        string _ngaysinh { get; set; }
        List<string> _lop { set; }
        string _lopchon { get; }
        event EventHandler Updatebtn;
        event EventHandler Closebtn;
    }
}
