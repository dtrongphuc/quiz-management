using quiz_management.Models;
using quiz_management.Presenters.Teacher.MockExamManagement;
using quiz_management.Views.Teacher.Main;
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
            btnAdd.Click += (_, e) =>
            {
                CreateExam?.Invoke(btnAdd, e);
            };
        }

        public string TeacherName { set => lbTeacher.DataBindings.Add("Text", value, ""); }
        public DataGridView MockExamList { get => dgvMockExam; }

        string IListMockExamView.ExamID => dgvMockExam.SelectedRows[0].Cells["ExamID"].Value.ToString();



        public event EventHandler GoBackBeFore;
        public event EventHandler UpdateExam;
        public event EventHandler DeleteExam;
        public event EventHandler CreateExam;

        public void ShowCreateMockExamView(int code)
        {
            this.Hide();
            CreateMockExamView screen = new CreateMockExamView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMainTeacherView(int code)
        {
            this.Hide();
            MainTeacherView screen = new MainTeacherView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }

        public void ShowUpdateMockExamView(int code, int userid)
        {
            this.Hide();
            UpdateMockExamView screen = new UpdateMockExamView(code,userid);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        private void dgvMockExam_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex == this.dgvMockExam.NewRowIndex)
            {
                return;
            }
            if (e.ColumnIndex == this.dgvMockExam.Columns["STT"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }
    }
}
