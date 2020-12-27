using quiz_management.Models;
using quiz_management.Presenters.Teacher.QuestionManagement;
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

namespace quiz_management.Views.Teacher.QuestionManagement
{
    public partial class QuestionApprovalView : Form, IQuestionApprovalView
    {
        QuestionApprovalPresenter presenter;
        public QuestionApprovalView(int code)
        {
            InitializeComponent();
            presenter = new QuestionApprovalPresenter(this, code);
            linkGobackMain.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGobackMain, e);
            };
            btnApproval.Click += (_, e) =>
            {
                Approval?.Invoke(btnApproval, e);
            };
            btnShowQuestionList.Click += (_, e) =>
            {
                QuestionList?.Invoke(btnShowQuestionList, e);
            };
        }

        public BindingList<ContributeQuestion> contributed { set => dgvCQuestionList.DataSource = value; }
        public string TeacherName { set => lbTeacher.Text = value; }

        public DataGridView CQuestionSelected => dgvCQuestionList;

        public event EventHandler GoBackBefore;
        public event EventHandler Approval;
        public event EventHandler QuestionList;

        public void ShowMainTeacher(int code)
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

        public void ShowQuestionList(int code, string gradeId, int subjectId)
        {
            this.Hide();
            QuestionListView screen = new QuestionListView(code, gradeId, subjectId);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}
