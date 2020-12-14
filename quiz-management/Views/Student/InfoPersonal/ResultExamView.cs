using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Student.InfoPersonal
{
    public partial class ResultExamView : Form,IResultExamView
    {
        public ResultExamView()
        {
            InitializeComponent();
        }

        public string _hoTen { get => throw new NotImplementedException(); set => TenNguoiDung.DataPropertyName=value; }
        public int _maBoDe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int _soCauSai { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int _soCauDung { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int _soChuaLam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string _ngayLam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string _thoiGian { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float _diem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string _monHoc { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler BackMain;

        public void swichMainStudent(int code)
        {
            throw new NotImplementedException();
        }
    }
}
