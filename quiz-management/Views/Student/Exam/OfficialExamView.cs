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
using quiz_management.Models;

namespace quiz_management.Views.Student.Exam
{
    public partial class OfficialExamView : Form, IOfficialExamView
    {
        private OfficialExamPresenter presenter;
        private static System.Timers.Timer aTimer;
        public int TimeCount;
        public int QQuantity;
        public ListBox checkBoxList;

        public string StudentName { set => txtStudentName.Text = value; }
        public string StudentClass { set => txtClass.Text = value; }
        public string ExamCode { set => txtExamCode.Text = value; }
        public int QuestionOrder { set => lbQuestionCountSelected.Text = value.ToString(); }
        public int QuestionQuantity { set => QQuantity = value; }
        public int ExamTime { set => TimeCount = value; }
        public int Completed { set => txtCompleted.Text = value.ToString(); }
        public int Remain { get => int.Parse(txtRemain.Text); set => txtRemain.Text = value.ToString(); }
        public string QuestionString { set => tbQuestion.Text = value; }
        public List<Answer> Answers { set => checkBoxList.DataSource = value; }

        public event EventHandler QuestionChange;

        public event EventHandler Submit;

        public event EventHandler Next;

        public event EventHandler Prev;

        public OfficialExamView(int userCode)
        {
            InitializeComponent();
            checkBoxList = ((ListBox)cbAnswers);

            presenter = new OfficialExamPresenter(this, userCode);
            SetTimer();
            RenderQuestionButton(QQuantity);

            cbQuestions.SelectedIndexChanged += (_, e) =>
            {
                QuestionChange.Invoke(cbQuestions, e);
                checkBoxList.DisplayMember = "CauTraLoi";
                checkBoxList.ValueMember = "MaCauTraLoi";
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