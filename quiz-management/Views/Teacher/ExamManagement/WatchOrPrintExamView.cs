using quiz_management.Models;
using quiz_management.Presenters.Teacher.ExamManagement;
using quiz_management.Views.Teacher.Main;
using quiz_management.Views.Teacher.MockExamManagement;
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
        private WatchOrPrintExamPresenter presenter;

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dgvExam.Width, dgvExam.Height);

            // draw the form image to the bitmap
            dgvExam.DrawToBitmap(bmp, new Rectangle(0, 0, dgvExam.Width, dgvExam.Height));

            // draw the bitmap image of the form onto the graphics surface
            e.Graphics.DrawImage(bmp, new Point(0, 0));
        }

        public static implicit operator WatchOrPrintExamView(ListMockExamView v)
        {
            throw new NotImplementedException();
        }
    }
}