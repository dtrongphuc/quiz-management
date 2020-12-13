using quiz_management.Presenters.Student.Exam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace quiz_management.Views.Student.Exam
{
    public partial class OfficialExamView : Form, IOfficialExamView
    {
        private OfficialExamPresenter presenter;
        private static System.Timers.Timer aTimer;
        public int TimeCount;
        public int QuestionQuantity;
        public int QuestionSelected = 0;

        public string StudentName { set => txtStudentName.Text = value; }
        public string StudentClass { set => txtClass.Text = value; }
        public string ExamCode { set => txtExamCode.Text = value; }
        public int QuestionCount { set => QuestionQuantity = value; }
        public int ExamTime { set => TimeCount = value; }
        public int Completed { set => txtCompleted.Text = value.ToString(); }
        public int Remain { get => int.Parse(txtRemain.Text); set => txtRemain.Text = value.ToString(); }
        //public object QuestionsDataSource { set => lvQuestionCollection = value; }

        //public List<string> ExamQuestions { set => }
        public event EventHandler QuestionChange;

        public event EventHandler Submit;

        public event EventHandler Next;

        public event EventHandler Prev;

        public OfficialExamView(int userCode)
        {
            InitializeComponent();
            presenter = new OfficialExamPresenter(this, userCode);
            SetTimer();
            RenderQuestionButton(QuestionQuantity);
            //lbQuestionCollection.DisplayMember = "CauHoi";

            cbQuestions.SelectedIndexChanged += (_, e) =>
            {
                QuestionChange.Invoke(cbQuestions, e);
            };

            btnSubmit.Click += (_, e) =>
            {
                Submit.Invoke(btnSubmit, e);
            };

            btnPrev.Click += (_, e) =>
            {
                Prev.Invoke(btnPrev, e);
            };

            btnNext.Click += (_, e) =>
            {
                Next.Invoke(btnNext, e);
            };
        }

        public void TimeToString()
        {
            txtTimeMinutes.Invoke(new Action(() => { txtTimeMinutes.Text = (Math.Ceiling(TimeCount / 60 * 1.0)).ToString(); }));
            txtTimeSeconds.Invoke(new Action(() => { txtTimeSeconds.Text = (TimeCount % 60).ToString(); }));
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            TimeCount = TimeCount - 1;
            TimeToString();
        }

        private void RenderQuestionButton(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                cbQuestions.Items.Add("Câu " + (i + 1));
            }
        }
    }
}