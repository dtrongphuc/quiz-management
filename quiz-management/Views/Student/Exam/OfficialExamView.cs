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
using quiz_management.Views.Student.Main;

namespace quiz_management.Views.Student.Exam
{
    public partial class OfficialExamView : Form, IOfficialExamView
    {
        private OfficialExamPresenter presenter;
        private static System.Timers.Timer aTimer;
        public int TimeCount;
        public int QQuantity;
        public int QuestionSelectedIndex;
        public ListBox checkBoxList;

        public string StudentName { set => txtStudentName.Text = value; }
        public string StudentClass { set => txtClass.Text = value; }
        public string ExamCode { set => txtExamCode.Text = value; }
        public int QuestionOrder { set => lbQuestionCountSelected.Text = value.ToString(); }

        public int QuestionQuantity
        {
            set
            {
                RenderQuestionButton(value);
                txtRemain.Text = value.ToString();
            }
        }

        public int QuestionSelected { set => QuestionSelectedIndex = value; }
        public int TimeLeft { get => TimeCount; }

        public bool QuestionChecked
        {
            set =>
                cbQuestions.SetItemChecked(QuestionSelectedIndex, value);
        }

        public int ExamTime { set => TimeCount = value; }
        public int Completed { get => int.Parse(txtCompleted.Text); set => txtCompleted.Text = value.ToString(); }
        public int Remain { get => int.Parse(txtRemain.Text); set => txtRemain.Text = value.ToString(); }
        public string QuestionString { set => tbQuestion.Text = value; }

        public List<Answer> Answers
        {
            set
            {
                checkBoxList.DataSource = value;
                for (int i = 0; i < value.Count; i++)
                {
                    bool state = value[i].Checked;
                    cbAnswers.SetItemChecked(i, state);
                };
                cbAnswers.SelectedItem = null;
            }
        }

        public List<int> QuestionsChecked
        {
            set
            {
                foreach (int index in value)
                {
                    cbQuestions.SetItemChecked(index, true);
                }
            }
        }

        public event EventHandler QuestionChange;

        public event EventHandler AnswerCheck;

        public event EventHandler Timeout;

        public event EventHandler Submit;

        public event EventHandler Next;

        public event EventHandler Prev;

        public bool ShowMessage(string caption, string text)
        {
            DialogResult result = MessageBox.Show(this, text, caption, MessageBoxButtons.OKCancel);
            return result == DialogResult.OK;
        }

        public void ShowStudentView(int userCode)
        {
            this.Hide();
            MainStudentView screen = new MainStudentView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public OfficialExamView(int userCode)
        {
            InitializeComponent();
            checkBoxList = ((ListBox)cbAnswers);

            presenter = new OfficialExamPresenter(this, userCode);
            Init();

            cbQuestions.SelectedIndexChanged += (_, e) =>
            {
                QuestionChange.Invoke(cbQuestions, e);
            };

            cbAnswers.ItemCheck += (_, e) =>
            {
                AnswerCheck.Invoke(cbQuestions, e);
            };

            btnSubmit.Click += (_, e) =>
            {
                Submit.Invoke(btnSubmit, e);
            };

            btnPrev.Click += (_, e) =>
            {
                Prev.Invoke(btnPrev, e);
                cbQuestions.SelectedIndex = QuestionSelectedIndex;
            };

            btnNext.Click += (_, e) =>
            {
                Next.Invoke(btnNext, e);
                cbQuestions.SelectedIndex = QuestionSelectedIndex;
            };
        }

        private void Form_Loaded(object sender, EventArgs e)
        {
            cbQuestions.SelectedIndex = -1;
            cbQuestions.SelectedIndex = QuestionSelectedIndex;
        }

        public void Init()
        {
            SetTimer();
            cbQuestions.SelectedIndex = QuestionSelectedIndex;
            checkBoxList.ItemHeight = 32;
            checkBoxList.DisplayMember = "CauTraLoi";
            checkBoxList.ValueMember = "MaCauTraLoi";
        }

        public void TimeToString()
        {
            double minutes = Math.Ceiling(TimeCount / 60 * 1.0);
            int secconds = (TimeCount % 60);

            if (minutes == 0 && secconds == 0)
            {
                Timeout.Invoke(null, null);
                return;
            }

            txtTimeMinutes.Invoke(new Action(() =>
            {
                txtTimeMinutes.Text = minutes < 10 ? "0" + minutes : minutes.ToString();
            }));

            txtTimeSeconds.Invoke(new Action(() =>
            {
                txtTimeSeconds.Text = secconds < 10 ? "0" + secconds : secconds.ToString();
            }));
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