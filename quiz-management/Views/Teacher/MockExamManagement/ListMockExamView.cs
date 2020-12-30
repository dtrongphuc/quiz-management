using quiz_management.Models;
using quiz_management.Presenters.Teacher.MockExamManagement;
using quiz_management.Views.Teacher.PaperManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.MockExamManagement
{
    public partial class ListMockExamView : Form, IListMockExamView
    {
        ListMockExamPresenter presenter;
        public ListMockExamView(int code)
        {
            InitializeComponent();
            presenter = new ListMockExamPresenter(this, code);
            linkGoBackBefore.Click += (_, e) =>
            {
                GoBackBeFore?.Invoke(linkGoBackBefore, e);
            };
            btnUpdate.Click += (_, e) =>
            {
                UpdateExam?.Invoke(btnUpdate, e);
            };
            btnDelete.Click += (_, e) =>
            {
                DeleteExam?.Invoke(btnDelete, e);
            };
        }

        public string TeacherName { set => lbTeacher.Text = value; }
        public List<MockExam> MockExamList { set => dgvMockExam.DataSource = value; }

        public event EventHandler GoBackBeFore;
        public event EventHandler UpdateExam;
        public event EventHandler DeleteExam;

        public void ShowCreateMockExamView(int code)
        {
            //this.Hide();
            //CreateMockExamView screen = new CreateMockExamView(code);
            //screen.FormClosed += (_, e) => this.Close();
            //screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }

        public void ShowUpdateMockExamView(int code)
        {
            //this.Hide();
            //PaperListView screen = new PaperListView(code);
            //screen.FormClosed += (_, e) => this.Close();
            //screen.Show();
        }
    }
}
