using quiz_management.Models;
using quiz_management.Presenters.Teacher.PaperManagement;
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

namespace quiz_management.Views.Teacher.PaperManagement
{
    public partial class CreatePaperView : Form, ICreatePaperView
    {
        CreatePaperPresenter presenter;
        public CreatePaperView(int code)
        {
            InitializeComponent();
            dgvQuestionList.AutoGenerateColumns = false;
            presenter = new CreatePaperPresenter(this, code);
            linkGoBackBefore.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGoBackBefore, e);
            };
            btnMoveToSeleted.Click += (_, e) =>
            {
                MoveToRight?.Invoke(btnMoveToSeleted, e);
            };
            //btnMoveAllToSeleted.Click += (_, e) =>
            //{
            //    MoveAllToRight?.Invoke(btnMoveAllToSeleted, e);
            //};
            btnMoveToQuestionList.Click += (_, e) =>
            {
                MoveToLeft?.Invoke(btnMoveToQuestionList, e);
            };
            //btnMoveAllToQuestionList.Click += (_, e) =>
            //{
            //    MoveAllToLeft?.Invoke(btnMoveAllToQuestionList, e);
            //};
            btnCreatePaper.Click += (_, e) =>
            {
                CreatePaper?.Invoke(btnCreatePaper, e);
            };
            btnWatchPaperList.Click += (_, e) =>
            {
                WatchPaperList?.Invoke(btnWatchPaperList, e);
            };
            cbbGrade.SelectedIndexChanged += (_, e) =>
            {
                 GradeChange?.Invoke(cbbGrade, e);
            };
            cbbSubject.SelectedIndexChanged += (_, e) =>
            {
                SubjectChange?.Invoke(cbbSubject, e);
            };
        }

        public string TeacherName { set => lbTeacher.Text = value; }

        public List<khoiLop> GradeList { set => cbbGrade.DataSource = value; }

        public DataGridView AllQuestion => dgvQuestionList;

        public string QuestionID { get => dgvQuestionList.SelectedRows[0].Cells["MaCauHoi"].Value.ToString(); }
        public string Question { get => dgvQuestionList.SelectedRows[0].Cells["CauHoi1"].Value.ToString(); }

        public DataGridView AllQuestionSelect => dgvQuestionSelectedList;

        public BindingList<CreatePaperWithQuestion> listQuestionselected { set => dgvQuestionSelectedList.DataSource = value; }
        public BindingList<CreatePaperWithQuestion> listQuestion { set => dgvQuestionList.DataSource = value; }

        public string Grade => cbbGrade.SelectedValue.ToString();

        public List<monHoc> SubjectList { set => cbbSubject.DataSource = value; }

        public string Subject => cbbSubject.SelectedValue.ToString();

        public event EventHandler MoveToRight;
        //public event EventHandler MoveAllToRight;
        public event EventHandler MoveToLeft;
        //public event EventHandler MoveAllToLeft;
        public event EventHandler CreatePaper;
        public event EventHandler GoBackBefore;
        public event EventHandler WatchPaperList;
        public event EventHandler GradeChange;
        public event EventHandler SubjectChange;

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

        public void ShowPaperListView(int code)
        {
            this.Hide();
            PaperListView screen = new PaperListView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}
