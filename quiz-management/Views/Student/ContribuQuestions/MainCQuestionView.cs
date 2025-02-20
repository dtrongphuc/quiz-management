﻿using quiz_management.Models;
using quiz_management.Presenters.Student.ContribuQuestions;
using quiz_management.Views.Student.Main;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Student.ContribuQuestions
{
    public partial class MainCQuestionView : Form, IMainCQuestionView
    {
        ContribuQuestionPresenter presenter;
        public MainCQuestionView(int code)
        {
            InitializeComponent();
            presenter = new ContribuQuestionPresenter(this, code);
            btnSend.Click += (_, e) =>
            {
                Send?.Invoke(btnSend, e);
            };
            linkGobackMain.Click += (_, e) =>
            {
                GoBackMain?.Invoke(linkGobackMain, e);
            };
            btnWatchContributeQuestion.Click += (_, e) =>
            {
                WatchContributeQuestions?.Invoke(btnWatchContributeQuestion, e);
            };
        }
        public string StudentID { set => lbStudentID.Text = value; }

        public string Question { get => tbQuestion.Text; set => tbQuestion.Text = value; }

        public string AnswerA => tbAnswerA.Text;

        public string AnswerB => tbAnswerB.Text;

        public string AnswerC => tbAnswerC.Text;

        public string AnswerD => tbAnswerD.Text;

        public string AnswerE => tbAnswerE.Text;

        public string AnswerF => tbAnswerF.Text;
        public List<khoiLop> classes { set => cbbLevel.DataSource = value; }
        public List<monHoc> Subjects { set => cbbSubject.DataSource = value; }

        public string ClassSelect => cbbLevel.SelectedValue.ToString();

        public string SubjectSelect => cbbSubject.SelectedValue.ToString();

        bool IMainCQuestionView.cbResultA => cbResultA.Checked;
        bool IMainCQuestionView.cbResultB => cbResultB.Checked;
        bool IMainCQuestionView.cbResultC => cbResultC.Checked;
        bool IMainCQuestionView.cbResultD => cbResultD.Checked;
        bool IMainCQuestionView.cbResultE => cbResultE.Checked;
        bool IMainCQuestionView.cbResultF => cbResultF.Checked;
        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");//, MessageBoxButtons.YesNo);
        }
        public event EventHandler Send;
        public event EventHandler GoBackMain;
        public event EventHandler WatchContributeQuestions;

        public void ShowMainStudentView(int code)
        {
            this.Hide();
            MainStudentView screen = new MainStudentView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowWatchContributeQuestions(int code)
        {
            this.Hide();
            CQuestionListView screen = new CQuestionListView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        private void btnWatchContributeQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
