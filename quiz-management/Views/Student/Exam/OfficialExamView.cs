﻿using quiz_management.Presenters.Student.Exam;
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
        public int QuestionSelectedIndex;
        public ListBox checkBoxList;

        public string StudentName { set => txtStudentName.Text = value; }
        public string StudentClass { set => txtClass.Text = value; }
        public string ExamCode { set => txtExamCode.Text = value; }
        public int QuestionOrder { set => lbQuestionCountSelected.Text = value.ToString(); }
        public int QuestionQuantity { set => QQuantity = value; }
        public int QuestionSelected { set => QuestionSelectedIndex = value; }

        public bool QuestionChecked
        {
            set =>
                cbQuestions.SetItemCheckState(QuestionSelectedIndex,
                value == true ? CheckState.Checked : CheckState.Unchecked);
        }

        public int ExamTime { set => TimeCount = value; }
        public int Completed { get => int.Parse(txtCompleted.Text); set => txtCompleted.Text = value.ToString(); }
        public int Remain { get => int.Parse(txtRemain.Text); set => txtRemain.Text = value.ToString(); }
        public string QuestionString { set => tbQuestion.Text = value; }
        public List<Answer> Answers { set => checkBoxList.DataSource = value; }

        public event EventHandler QuestionChange;

        public event EventHandler AnswerCheck;

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
            txtRemain.Text = QQuantity.ToString();

            cbQuestions.SelectedIndexChanged += (_, e) =>
            {
                QuestionChange.Invoke(cbQuestions, e);
                checkBoxList.ItemHeight = 32;
                checkBoxList.DisplayMember = "CauTraLoi";
                checkBoxList.ValueMember = "MaCauTraLoi";
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
            };

            btnNext.Click += (_, e) =>
            {
                Next.Invoke(btnNext, e);
            };
        }

        public void TimeToString()
        {
            txtTimeMinutes.Invoke(new Action(() => { txtTimeMinutes.Text = (Math.Ceiling(TimeCount / 60 * 1.0)).ToString(); }));
            txtTimeSeconds.Invoke(new Action(() =>
            {
                int secconds = (TimeCount % 60);
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