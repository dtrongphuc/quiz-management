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
    public partial class UpdateQuestionView : Form, IUpdateQuestionView
    {
        UpdateQuestionPresenter presenter;
        public UpdateQuestionView(int code, int questionid)
        {
            InitializeComponent();
            presenter = new UpdateQuestionPresenter(this, code, questionid);
            btnSend.Click += (_, e) =>
            {
                UpdateQuestion?.Invoke(btnSend, e);
            };
            linkGobackMain.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGobackMain, e);
            };
        }

        public string TeacherName { set => lbTeacher.Text = value; }


        public string GradeId => cbbGrade.SelectedValue.ToString();

        public string SubjectId => cbbSubject.SelectedValue.ToString();

        public string AnswerA => tbAnswerA.Text;

        public string AnswerB => tbAnswerB.Text;

        public string AnswerC => tbAnswerC.Text;

        public string AnswerD => tbAnswerD.Text;

        public string AnswerE => tbAnswerE.Text;

        public string AnswerF => tbAnswerF.Text;

        public List<khoiLop> GradeList { set => cbbGrade.DataSource = value; }
        public List<monHoc> SubjectList { set => cbbSubject.DataSource = value; }
        public string lvDifficute { get => cbbDifficute.Text; set => cbbDifficute.Text = value; }

        public string Question { get => tbQuestion.Text; set => tbQuestion.Text = value; }
        public string GradeSelected { set => cbbGrade.Text = value; }
        public string SubjectSelected { set => cbbSubject.Text = value; }
        string IUpdateQuestionView.AnswerA { get => tbAnswerA.Text; set => tbAnswerA.Text = value; }
        string IUpdateQuestionView.AnswerB { get => tbAnswerB.Text; set => tbAnswerB.Text = value; }
        string IUpdateQuestionView.AnswerC { get => tbAnswerC.Text; set => tbAnswerC.Text = value; }
        string IUpdateQuestionView.AnswerD { get => tbAnswerD.Text; set => tbAnswerD.Text = value; }
        string IUpdateQuestionView.AnswerE { get => tbAnswerE.Text; set => tbAnswerE.Text = value; }
        string IUpdateQuestionView.AnswerF { get => tbAnswerF.Text; set => tbAnswerF.Text = value; }
        bool IUpdateQuestionView.cbResultA { get => cbResultA.Checked; set => cbResultA.Checked = value; }
        bool IUpdateQuestionView.cbResultB { get => cbResultB.Checked; set => cbResultB.Checked = value; }
        bool IUpdateQuestionView.cbResultC { get => cbResultC.Checked; set => cbResultC.Checked = value; }
        bool IUpdateQuestionView.cbResultD { get => cbResultD.Checked; set => cbResultD.Checked = value; }
        bool IUpdateQuestionView.cbResultE { get => cbResultE.Checked; set => cbResultE.Checked = value; }
        bool IUpdateQuestionView.cbResultF { get => cbResultF.Checked; set => cbResultF.Checked = value; }

        public event EventHandler UpdateQuestion;
        public event EventHandler GoBackBefore;

        public void ShowListQuestion(int code, string gradeID, int subjectID)
        {
            this.Hide();
            QuestionListView screen = new QuestionListView(code, gradeID, subjectID);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }
    }
}
