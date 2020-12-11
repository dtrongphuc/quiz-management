using quiz_management.Views.Student.Interface;
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
    public partial class InfoPersonalView : Form,IInfoPersonalView
    {
        public InfoPersonalView()
        {
            InitializeComponent();
        }

        public string _maSo { set => throw new NotImplementedException(); }
        public string _hoTen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string _ngaysinh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> _lop { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        event EventHandler IInfoPersonalView.Update
        event EventHandler IInfoPersonalView.Close
        
    }
}
