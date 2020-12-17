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
            btnMoveAllToSeleted.Click += (_, e) =>
            {
                MoveAllToRight?.Invoke(btnMoveAllToSeleted, e);
            };
            btnMoveToQuestionList.Click += (_, e) =>
            {
                MoveToLeft?.Invoke(btnMoveToQuestionList, e);
            };
            btnMoveAllToQuestionList.Click += (_, e) =>
            {
                MoveAllToLeft?.Invoke(btnMoveAllToQuestionList, e);
            };
            btnCreatePaper.Click += (_, e) =>
            {
                CreatePaper?.Invoke(btnCreatePaper, e);
            };
        }

        public string TeacherName { set => lbTeacher.Text = value; }

        public string PaperID => tbPaperID.Text;

        public List<khoiLop> GradeList { set => cbbGrade.DataSource = value; }
        public List<cauHoi> cauHois { set => dgvQuestionList.DataSource = value; }

        public DataGridView macauhoi => dgvQuestionList;

        public event EventHandler MoveToRight;
        public event EventHandler MoveAllToRight;
        public event EventHandler MoveToLeft;
        public event EventHandler MoveAllToLeft;
        public event EventHandler CreatePaper;
        public event EventHandler GoBackBefore;

        public void MainTeacherView(int code)
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
    }
}
