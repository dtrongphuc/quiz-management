using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.InfoPersonal
{
    interface IProfileView
    {
        string _maSo { set; get; }
        string _hoTen { get; set; }
        string _ngaysinh { get; set; }
        List<Lop> _lop { set; }
        Lop _lopChon { get; set; }
        event EventHandler Updatebtn;
        event EventHandler Closebtn;

        void swichMainStudent(int code);
    }
}
