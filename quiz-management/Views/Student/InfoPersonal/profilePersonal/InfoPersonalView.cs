using quiz_management.Presenters.Student.InfoPersonal;
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
        ProfilePersonalPresenter presenter;
        public InfoPersonalView(int code)
        {
            InitializeComponent();
            presenter = new ProfilePersonalPresenter(this, code);
            btnsubmit.Click += (_, e) =>
            {
                btnclose?.Invoke(Updatebtn, e);
            };
            btnclose.Click += (_, e) =>
            {
                btnclose?.Invoke(Closebtn, e);
            };
        }

        public string _maSo { set => txtIdStudent.Text = value; }
        public string _hoTen { get => txtNameStudent.Text; set => txtNameStudent.Text = value; }
        public string _ngaysinh { get => txtDOBStudent.Text; set => txtDOBStudent.Text = value; }
        public List<string> _lop { set => cbLop.DataSource = value; }

        public string _lopchon => (string)cbLop.SelectedValue;

        public event EventHandler Updatebtn;
        public event EventHandler Closebtn;
    }
}
