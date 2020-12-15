using quiz_management.Models;
using quiz_management.Presenters.Student.InfoPersonal;
using quiz_management.Views.Student.ContribuQuestions;
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
    public partial class ResultExamView : Form,IResultExamView
    {
        ResultExamPresenter presenter;
        public ResultExamView(int code)
        {
            InitializeComponent();
            presenter = new ResultExamPresenter(this, code);

            linkLabel1.Click += (_, e) =>
            {
                BackMain?.Invoke(linkLabel1, e);
            };

        }

        public List<ResultExam> ResultExam { set => dgvKetQua.DataSource = value; }
        
        public event EventHandler BackMain;

        public void swichMainStudent(int code)
        {
            this.Hide();
            MainStudentView screen = new MainStudentView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}
