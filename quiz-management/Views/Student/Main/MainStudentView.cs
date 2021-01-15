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
        private MainStudentPresenter presenter;
        private int _currentUserCode;

        public string DOBHS { set => txtStudentDOBview.Text = value; }
        public string IdHS { set => txtStudentIDview.Text = value; }
        public string NameHS { set => lbStudentNameview.Text = value; }
        public string LopHS { set => txtclassview.Text = value; }

        public event EventHandler EditProfile;

        public event EventHandler ContribuQuestion;

        public event EventHandler OfficialExamClick;

        public event EventHandler ResultExamClick;

        public event EventHandler TestScheduleClick;

        public event EventHandler PracticExamClick;

        public event EventHandler PracticStatisticClick;
        public event EventHandler LogoutClick;

        public MainStudentView(int u)
        {
            InitializeComponent();
            _currentUserCode = u;
            presenter = new MainStudentPresenter(this, u);

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

            btnExamResultView.Click += (_, e) =>
            {
                ResultExamClick?.Invoke(btnExamResultView, e);
            };

            btnTestScheduleView.Click += (_, e) =>
            {
                TestScheduleClick?.Invoke(btnTestScheduleView, e);
            };

            btnPracticExam.Click += (_, e) =>
            {
                PracticExamClick?.Invoke(btnPracticExam, e);
            };

            btnPracticStatistic.Click += (_, e) =>
            {
                PracticStatisticClick?.Invoke(btnPracticStatistic, e);
            };
            btnLogout.Click += (_, e) =>
            {
                LogoutClick?.Invoke(btnLogout, e);
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
            ProfileView screen = new ProfileView(userCode);
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

        public void ShowResultExamView(int userCode)
        {
            this.Hide();
            ResultExamView screen = new ResultExamView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowTestScheduleView(int userCode)
        {
            this.Hide();
            TestScheduleView screen = new TestScheduleView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowPracticExamView(int userCode)
        {
            this.Hide();
            PracticExamView screen = new PracticExamView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowPracticStatisticView(int userCode)
        {
            this.Hide();
            PracticStatisticView screen = new PracticStatisticView(userCode);
            screen.FormClosed += (_, e) => this.Show();
            screen.Show();
        }

        public void ShowLogin()
        {
            this.Hide();
            LoginView screen = new LoginView();
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}