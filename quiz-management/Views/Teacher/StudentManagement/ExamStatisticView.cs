using quiz_management.Presenters.Teacher.StudentManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.StudentManagement
{
    public partial class ExamStatisticView : Form, IExamStatisticView
    {
        private ExamStatisticPresenter presenter;

        public List<DateTime> ExamDateTimes { set => cbDateTime.DataSource = value; }

        public int TotalStudent { set => tbTotalStudent.Text = value.ToString(); }
        public int TotalStudentAboveAverage { set => tbAbove.Text = value.ToString(); }
        public int TotalStudentBelowAverage { set => tbBelow.Text = value.ToString(); }
        public int TotalMaxScoring { set => tbMax.Text = value.ToString(); }

        public event EventHandler DateTimeChanged;

        public ExamStatisticView()
        {
            InitializeComponent();
            presenter = new ExamStatisticPresenter(this);

            cbDateTime.SelectedIndexChanged += (_, e) =>
            {
                DateTimeChanged.Invoke(cbDateTime, e);
            };
        }

        private void Form_Loaded(object sender, EventArgs e)
        {
            cbDateTime.SelectedIndex = -1;
        }

        private void cbDateTime_Format(object sender, ListControlConvertEventArgs e)
        {
            DateTime dt = (DateTime)e.Value;
            e.Value = dt.ToString("MM/dd/yyyy");
        }
    }
}