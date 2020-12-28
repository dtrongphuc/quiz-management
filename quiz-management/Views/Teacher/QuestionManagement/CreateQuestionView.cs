using quiz_management.Models;
using quiz_management.Presenters.Teacher.QuestionManagement;
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

namespace quiz_management.Views.Teacher.QuestionManagement
{
    public partial class CreateQuestionView : Form, ICreateQuestionView
    {
        CreateQuestionPresneter presneter;
        public CreateQuestionView(int code)
        {
            InitializeComponent();
            presneter = new CreateQuestionPresneter(this, code);
            btnSend.Click += (_, e) =>
            {
                Create?.Invoke(btnSend, e);
            };
            btnShowQuestionList.Click += (_, e) =>
            {
                ShowListQuestion?.Invoke(btnShowQuestionList, e);
            };
            linkGobackMain.Click += (_, e) =>
            {
                GoBackMain?.Invoke(linkGobackMain, e);
            };
        }

        public string TeacherName { set => lbTeacher.Text = value; }

        public string Question => tbQuestion.Text;

        public string GradeId => cbbLevel.SelectedValue.ToString();

        public string SubjectId => cbbSubject.SelectedValue.ToString();

        public string AnswerA => tbAnswerA.Text;

        public string AnswerB => tbAnswerB.Text;

        public string AnswerC => tbAnswerC.Text;

        public string AnswerD => tbAnswerD.Text;

        public string AnswerE => tbAnswerE.Text;

        public string AnswerF => tbAnswerF.Text;

        public List<khoiLop> GradeList { set => cbbLevel.DataSource = value; }
        public List<monHoc> SubjectList { set => cbbSubject.DataSource = value; }

        public string lvDifficute => cbbDifficute.Text;

        bool ICreateQuestionView.cbResultA => cbResultA.Checked;

        bool ICreateQuestionView.cbResultB => cbResultB.Checked;
                                              
        bool ICreateQuestionView.cbResultC => cbResultC.Checked;
                                              
        bool ICreateQuestionView.cbResultD => cbResultD.Checked;
                                            
        bool ICreateQuestionView.cbResultE => cbResultE.Checked;
                                            
        bool ICreateQuestionView.cbResultF => cbResultF.Checked;

        public event EventHandler Create;
        public event EventHandler GoBackMain;
        public event EventHandler ShowListQuestion;

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

        public void ShowQuestionList(int code, string gradeID, int subjectID)
        {
            this.Hide();
            QuestionListView screen = new QuestionListView(code, gradeID, subjectID);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}
