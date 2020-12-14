using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.InfoPersonal
{
    interface IResultExamView
    {
        string _hoTen { get; set; }
        int _maBoDe { get; set; }
        int _soCauSai { get; set; }
        int _soCauDung { get; set; }
        int _soChuaLam { get; set; }
        string _ngayLam { get; set; }
        string _thoiGian { get; set; }
        float _diem { get; set; }
        string _monHoc { get; set; }
        event EventHandler BackMain;
        void swichMainStudent(int code);


    }
}
