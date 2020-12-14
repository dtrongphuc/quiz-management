using quiz_management.Models;
using quiz_management.Presenters.Student.InfoPersonal;
using quiz_management.Views.Student.Main;
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

        public string _maSo { set => txtIdStudent.Text = value; get => txtIdStudent.Text; }
        public string _hoTen { get => txtNameStudent.Text; set => txtNameStudent.Text = value; }
        public string _ngaysinh { get => txtDOBStudent.Text; set => txtDOBStudent.Text = value; }
        public List<Lop> _lop { set => cbLop.DataSource = value; }

       
        public Lop _lopChon
        {
            get
            {
                return (Lop)cbLop.SelectedItem;
            }
            set => cbLop.SelectedItem = value;
        }

       
        public event EventHandler Updatebtn;
        public event EventHandler Closebtn;

        public void swichMainStudent(int code)
        {
            this.Hide();
            MainStudentView screen = new MainStudentView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}
