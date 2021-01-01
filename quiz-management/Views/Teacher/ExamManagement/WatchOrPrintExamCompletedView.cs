using quiz_management.Models;
using quiz_management.Views.Teacher.ExamManagement;
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

namespace quiz_management.Presenters.Teacher.ExamManagement
{
    public partial class WatchOrPrintExamCompletedView : Form, IWatchOrPrintExamCompletedView
    {
        WatchOrPrintExamCompletedPresneter presenter;
        public WatchOrPrintExamCompletedView(int code)
        {
            InitializeComponent();
            dgvExam.AutoGenerateColumns = false;
            presenter = new WatchOrPrintExamCompletedPresneter(this, code);
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
        public BindingList<TrainScript> ExamList { set => dgvExam.DataSource = value; }

        public event EventHandler GobackBefore;
        public event EventHandler Print;

        public void Home(int code)
        {
            this.Hide();
            MainTeacherView screen = new MainTeacherView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void Message(string text)
        {
            MessageBox.Show(text);
        }
    }
}
