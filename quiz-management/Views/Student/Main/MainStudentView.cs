using quiz_management.Models;
using quiz_management.Presenters.Student.Main;
using quiz_management.Views.Student.ContribuQuestions;
using quiz_management.Views.Student.Exam;
using quiz_management.Views.Student.InfoPersonal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Student.Main
{
    public partial class MainStudentView : Form, IMainStudentView
    {
        MainStudentPresenter presenter;

        public string DOBHS { set => txtStudentDOBview.Text = value; }
        public string IdHS { set => txtStudentIDview.Text = value; }
        public string NameHS { set => lbStudentNameview.Text = value; }
        public string LopHS { set => txtclassview.Text = value; }

        public event EventHandler EditProfile;
        public event EventHandler ContribuQuestion;
        public event EventHandler OfficialExamClick;

        public MainStudentView(int u)
        {
            InitializeComponent();
           
            presenter = new MainStudentPresenter(this,u);

            btnInfoStudent.Click += (_, e) =>
            {
                EditProfile?.Invoke(btnInfoStudent, e);
            };

            btnQuestions.Click += (_, e) =>
            {
                ContribuQuestion?.Invoke(btnQuestions, e);
            };

            btnOfficialExam.Click += (_, e) =>
            {
                OfficialExamClick?.Invoke(btnOfficialExam, e);
            };
        }


        public void ShowContribuQuestionsView(int userCode)
        {
            this.Hide();
            MainCQuestionView screen = new MainCQuestionView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowEditProfileStudentView(int userCode)
        {
            this.Hide();
            UpdateInfoStudentView screen = new UpdateInfoStudentView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowOfficialExamView(int userCode)
        {
            this.Hide();
            OfficialExamView screen = new OfficialExamView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}
