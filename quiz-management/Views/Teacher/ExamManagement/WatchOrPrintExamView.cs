using quiz_management.Models;
using quiz_management.Presenters.Teacher.ExamManagement;
using quiz_management.Views.Teacher.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.ExamManagement
{
    public partial class WatchOrPrintExamView : Form, IWatchOrPrintExamView
    {
        WatchOrPrintExamPresenter presenter;
        public WatchOrPrintExamView(int code)
        {
            InitializeComponent();
            presenter = new WatchOrPrintExamPresenter(this, code);
            linkGoBackBefore.Click += (_, e) =>
            {
                GobackBefore?.Invoke(linkGoBackBefore, e);
            };
            btnPrint.Click += (_, e) =>
            {
                Print?.Invoke(btnPrint, e);
            };
        }

        public string TeacherName { set => lbTeacher.Text = value; }
        public List<StudentOfExam> ExamList { set => dgvExam.DataSource = value; }

        public event EventHandler GobackBefore;
        public event EventHandler Print;

        public void Message(string text)
        {
            MessageBox.Show(text);
        }

        public void ShowMainTeacher(int code)
        {
            this.Hide();
            MainTeacherView screen = new MainTeacherView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}
