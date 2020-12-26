using quiz_management.Models;
using quiz_management.Presenters.Teacher.QuestionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.QuestionManagement
{
    public partial class QuestionListView : Form, IQuestionListView
    {
        QuestionListPresenter presenter;
        public QuestionListView(int code)
        {
            InitializeComponent();
            presenter = new QuestionListPresenter(this, code);
            linkGoBackBefore.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGoBackBefore, e);
            };
            btnUpdate.Click += (_, e) =>
            {
                ShowUpdate?.Invoke(btnUpdate, e);
            };
            cbbGrade.SelectedIndexChanged += (_, e) =>
            {
                SelectedCBB?.Invoke(cbbGrade, e);
            };
            cbbSubject.SelectedIndexChanged += (_, e) =>
            {
                SelectedCBB?.Invoke(cbbSubject, e);
            };
        }

        public string TeacherName { set => lbTeacher.Text = value; }

        public string GradeId => cbbGrade.SelectedValue.ToString();

        public string SubjectId => cbbSubject.SelectedValue.ToString();

        public List<khoiLop> GradeList { set => cbbGrade.DataSource = value; }
        public List<monHoc> SubjectList { set => cbbSubject.DataSource = value; }
        public BindingList<QuestionCreated> QuestionList { set => dgvQuestions.DataSource = value; }
        public string QuestionId { get => dgvQuestions.SelectedRows[0].Cells["QuestionID"].Value.ToString(); }

        public event EventHandler ShowUpdate;
        public event EventHandler GoBackBefore;
        public event EventHandler SelectedCBB;

        public void ShowCreateQuestion(int code)
        {
            this.Hide();
            CreateQuestionView screen = new CreateQuestionView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }

        public void ShowUpdateQuestion(int code, int questionID)
        {
            //this.Hide();
            //MainTeacherView screen = new MainTeacherView(code);
            //screen.FormClosed += (_, e) => this.Close();
            //screen.Show();
        }
    }
}
