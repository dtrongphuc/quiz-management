using quiz_management.Presenters.Student.ContribuQuestions;
using System;
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
        public BindingList<string> classes { get => throw new NotImplementedException();; set => throw new NotImplementedException(); }

        public string Subject { get => throw new NotImplementedException(); }
        public string Question { get => tbQuestion.Text; set => tbQuestion.Text = value; }

        public string AnswerA => tbAnswerA.Text;

        public string AnswerB => tbAnswerB.Text;

        public string AnswerC => tbAnswerC.Text;

        public string AnswerD => tbAnswerD.Text;

        public string AnswerE => tbAnswerE.Text;

        public string AnswerF => tbAnswerF.Text;

        public event EventHandler Send;
        public event EventHandler Pre;

        public MainCQuestionView()
        {
            presenter = new ContribuQuestionPresenter(this);
            InitializeComponent();
            btnSend.Click += (_, e) =>
            {
                Send?.Invoke(btnSend, e);
            };

        }

    }
}
