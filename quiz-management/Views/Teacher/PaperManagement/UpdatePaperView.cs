﻿using quiz_management.Models;
using quiz_management.Presenters.Teacher.PaperManagement;
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
    public partial class UpdatePaperView : Form, IUpdatePaperView
    {
        UpdatePaperPresenter presenter;
        public UpdatePaperView(int code, int paperid)
        {
            InitializeComponent();
            dgvQuestionList.AutoGenerateColumns = false;
            presenter = new UpdatePaperPresenter(this, code, paperid);
            linkGoBackBefore.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGoBackBefore, e);
            };
            btnUpdatePaper.Click += (_, e) =>
             {
                 UpdatePaper?.Invoke(btnUpdatePaper, e);
             };
            btnMoveToSeleted.Click += (_, e) =>
            {
                MoveToRight?.Invoke(btnMoveToSeleted, e);
            };
            btnMoveToQuestionList.Click += (_, e) =>
            {
                MoveToLeft?.Invoke(btnMoveToQuestionList, e);
            };
            cbbGrade.SelectedIndexChanged += (_, e) =>
             {
                 GradeChange?.Invoke(cbbGrade, e);
             };
            cbbSubject.SelectedIndexChanged += (_, e) =>
            {
                SubjectChange?.Invoke(cbbSubject, e);
            };
        }

        public string TeacherName { set => lbTeacher.Text = value; }

        public string PaperID { get => tbPaperID.Text; set => tbPaperID.Text = value; }

        public List<khoiLop> GradeList { set => cbbGrade.DataSource = value; }
        public int Gradeselected { set => cbbGrade.SelectedIndex = value; }

        public DataGridView AllQuestion => dgvQuestionList;
        public DataGridView AllQuestionSelect => dgvQuestionSelectedList;

        public List<CreatePaperWithQuestion> listQuestionselected { set => dgvQuestionSelectedList.DataSource = value; }
        public List<CreatePaperWithQuestion> listQuestion { set => dgvQuestionList.DataSource = value; }

        public string Grade => cbbGrade.SelectedValue.ToString();

        public List<monHoc> SubjectList { set => cbbSubject.DataSource = value; }
        public int Subjectseleted { set => cbbSubject.SelectedIndex = value; }

        public string Subject => cbbSubject.SelectedValue.ToString();

        public event EventHandler MoveToRight;
        //public event EventHandler MoveAllToRight;
        public event EventHandler MoveToLeft;
        //public event EventHandler MoveAllToLeft;
        public event EventHandler UpdatePaper;
        public event EventHandler GoBackBefore;
        public event EventHandler GradeChange;
        public event EventHandler SubjectChange;


        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }

        public void ShowPaperListView(int code)
        {
            this.Hide();
            PaperListView screen = new PaperListView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }
    }
}
