using quiz_management.Models;
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
    public partial class PaperListView : Form, IPaperListView
    {
        PaperListPresenter presenter;
        public PaperListView(int code)
        {
            InitializeComponent();
            presenter = new PaperListPresenter(this, code);
            linkGoBackBefore.Click += (_, e) =>
            {
                GobackBefore?.Invoke(linkGoBackBefore, e);
            };
            btnUpdate.Click += (_, e) =>
            {
                UpdatePaper?.Invoke(btnUpdate, e);
            };
            btnDelete.Click += (_, e) =>
            {
                Delete?.Invoke(btnDelete, e);
            };
        }

        public string Teachername { set => lbTeacher.Text = value; }

        public string PaperID => throw new NotImplementedException();

        public List<Papers> papers { set => dgvPaper.DataSource = value; }

        public event EventHandler GobackBefore;
        public event EventHandler Delete;
        public event EventHandler UpdatePaper;

        public void ShowCreatePaperView(int code)
        {
            this.Hide();
            CreatePaperView screen = new CreatePaperView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }

        public void ShowUpdatePaperView(int code)
        {
            throw new NotImplementedException();
        }
    }
}
