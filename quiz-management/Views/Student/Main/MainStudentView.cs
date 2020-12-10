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

        public MainStudentView(string code)
        {
            InitializeComponent();
            presenter = new MainStudentPresenter(this, code);
        }
    }
}
