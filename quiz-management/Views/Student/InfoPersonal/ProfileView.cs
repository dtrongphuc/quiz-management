using quiz_management.Presenters.Student.InfoPersonal;
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
    public partial class ProfileView : Form, IProfileView
    {
        ProfilePresenter presenter;
        public ProfileView(int code)
        {
            InitializeComponent();
            presenter = new ProfilePresenter(this, code);
            
            btnSubmit.Click += (_, e) =>
            {
                Updatebtn?.Invoke(btnSubmit, e);
            };

            btnClose.Click += (_, e) =>
            {
                Closebtn?.Invoke(btnSubmit, e);
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
