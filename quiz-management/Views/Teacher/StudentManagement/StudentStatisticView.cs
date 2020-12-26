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
    public partial class StudentStatisticView : Form, IStudentStatisticView
    {
        private StudentStatisticPresenter presenter;

        public List<DateTime> ExamDateTimes { set => cbDateTime.DataSource = value; }

        public event EventHandler DateTimeChanged;

        public StudentStatisticView()
        {
            InitializeComponent();
            presenter = new StudentStatisticPresenter(this);
            InitialControl();
        }

        public void InitialControl()
        {
            cbDateTime.SelectedIndexChanged += (_, e) =>
            {
                DateTimeChanged.Invoke(cbDateTime, e);
            };
        }

        private void cbDateTime_Format(object sender, ListControlConvertEventArgs e)
        {
            DateTime dt = (DateTime)e.Value;
            e.Value = dt.ToString("MM/dd/yyyy");
        }
    }
}