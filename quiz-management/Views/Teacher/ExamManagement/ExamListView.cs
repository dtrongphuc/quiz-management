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
    public partial class ExamListView : Form,IExamListView
    {
        ExamListPresenter presenter;
        public ExamListView(int code)
        {
            InitializeComponent();
            dgvLichThi.AutoGenerateColumns = false;
            presenter = new ExamListPresenter(this,code);
            linkGoBackBefore.Click += (_, e) =>
            {
                GobackBefore?.Invoke(linkGoBackBefore, e);
            };
            btnUpdate.Click += (_, e) =>
            {
                UpdateExam?.Invoke(btnUpdate, e);
            };
            btnDelete.Click += (_, e) =>
            {
                Delete?.Invoke(btnDelete, e);
            };
            btnThem.Click += (_, e) =>
            {
                AddExam?.Invoke(btnThem, e);
            };
            
        }



        public BindingList<TestSchedule> dtgv { set => dgvLichThi.DataSource = value; }
        public DataGridView lichthichon
        {
            get
            {
                return dgvLichThi;
            }
        }

        public event EventHandler GobackBefore;
        public event EventHandler Delete;
        public event EventHandler UpdateExam;
        public event EventHandler AddExam;

       

        public void ShowCreateExamView(int code)
        {
            this.Hide();
            CreateExamView screen = new CreateExamView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMainTeachView(int code)
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

        public void ShowUpdateExamView(int code, int userid)
        {
            this.Hide();
            UpdateExamView screen = new UpdateExamView(code,userid);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        private void dgvLichThi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex == this.dgvLichThi.NewRowIndex)
            {
                return;
            }
            if (e.ColumnIndex == this.dgvLichThi.Columns["STT"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }
    }
}
