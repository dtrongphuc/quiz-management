using quiz_management.Presenters.Student.Exam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Student.Exam
{
    public partial class PracticStatisticView : Form, IPracticStatistic
    {
        private PracticStatisticPresenter presenter;

        public string StudentName { set => txtStudentName.Text = value; }
        public string StudentClass { set => txtClass.Text = value; }
        public int Total { set => lbTotal.Text = value.ToString(); }
        public int CorrectedCount { set => lbCorrectedCount.Text = value.ToString(); }
        public int WrongCount { set => lbWrongCount.Text = value.ToString(); }

        public PracticStatisticView(int code)
        {
            InitializeComponent();

            presenter = new PracticStatisticPresenter(this, code);
        }
    }
}