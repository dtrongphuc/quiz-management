using quiz_management.Models;
using quiz_management.Presenters.Student.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Student.Main
{
    public partial class MainStudentView : Form, IMainStudentView
    {
        MainStudentPresenter presenter;
        nguoiDung user;
        public MainStudentView(nguoiDung u)
        {
            InitializeComponent();
            user = u;
            presenter = new MainStudentPresenter(this);
            btnInfoStudent.Click += (_, e) =>
            {
                EditProfile?.Invoke(btnInfoStudent, e);
            };
        }

        public nguoiDung User{ get => user; }
        public string DOBHS { set => txtStudentDOBview.Text = value;}
        public string IdHS { set => txtStudentIDview.Text = value; }
        public string NameHS { set => lbStudentNameview.Text = value; }
        public string LopHS { set => txtclassview.Text = value; }

        public event EventHandler EditProfile;
    }
}
