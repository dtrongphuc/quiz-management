using quiz_management.Models;
using quiz_management.Presenters.Student.ContribuQuestions;
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
    public partial class CQuestionListView : Form, ICQuestionListView
    {
        CQuestionListPresenter presenter;
        public CQuestionListView(int code)
        {
            InitializeComponent();
            dtgCQuestionList.AutoGenerateColumns = false;
            presenter = new CQuestionListPresenter(this, code);
            btnClose.Click += (_, e) =>
            {
                Closepage?.Invoke(btnClose, e);
            };
            linkGobackMain.Click += (_, e) =>
            {
                GoBackBefore?.Invoke(linkGobackMain, e);
            };
        }

        public List<ContributeQuestion> contributed { set => dtgCQuestionList.DataSource = value; }

        public event EventHandler Closepage;
        public event EventHandler GoBackBefore;

        public void ShowMainCQuestionView(int code)
        {
            this.Hide();
            MainCQuestionView screen = new MainCQuestionView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }
    }
}
