using quiz_management.Presenters.Teacher.Main;
using quiz_management.Properties;
using quiz_management.Views.Student;
using quiz_management.Views.Student.Exam;
using quiz_management.Views.Teacher.QuestionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.Main
{
    public partial class MainTeacherView : Form, IMainTeacherView
    {
        private bool isCollapsed;
        private bool isCollapsed1;

        private bool isCollapsed3;

        private bool isCollapsed5;
        private MainTeacherPresenter presenter;

        public MainTeacherView(int code)
        {
            InitializeComponent();
            presenter = new MainTeacherPresenter(this, code);
            btnUpdateInfo.Click += (_, e) =>
            {
                UpdateInfo?.Invoke(btnUpdateInfo, e);
            };

            btnCreateQuestion.Click += (_, e) =>
            {
                CreateQuestion?.Invoke(btnCreateQuestion, e);
            };

            btnApproval.Click += (_, e) =>
            {
                QuestionApproval?.Invoke(btnApproval, e);
            };

            btnOfficialExam.Click += (_, e) =>
            {
                OfficialExamClick?.Invoke(btnOfficialExam, e);
            };

            btnPracticExam.Click += (_, e) =>
            {
                PracticExamClick?.Invoke(btnPracticExam, e);
            };
        }

        public event EventHandler UpdateInfo;

        public event EventHandler CreateQuestion;

        public event EventHandler QuestionApproval;

        public event EventHandler OfficialExamClick;

        public event EventHandler PracticExamClick;

        public string TeacherName { set => tbTeacherName.Text = value; }
        public string TeacherID { set => tbTeacherID.Text = value; }
        public string DOB { set => tbDOB.Text = value; }

        private void QuizManager_Click(object sender, EventArgs e)
        {
            timerQLCauHoi.Start();
        }

        private void btnLamBaiThi_Click(object sender, EventArgs e)
        {
            timerLamBaiThi.Start();
        }

        private void timeQLKyThi_Tick(object sender, EventArgs e)
        {
            if (isCollapsed3)
            {
                btnQLKyThi.Image = Resources.Collapse_Arrow_20px;
                panelQLKyThi.Height += 10;
                if (panelQLKyThi.Size == panelQLKyThi.MaximumSize)
                {
                    timeQLKyThi.Stop();
                    isCollapsed3 = false;
                }
            }
            else
            {
                btnQLKyThi.Image = Resources.Expand_Arrow_20px;
                panelQLKyThi.Height -= 10;
                if (panelQLKyThi.Size == panelQLKyThi.MinimumSize)
                {
                    timeQLKyThi.Stop();
                    isCollapsed3 = true;
                }
            }
        }

        private void QLCauHoi_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                btnQuizManager.Image = Resources.Collapse_Arrow_20px;
                panelQLCauHoi.Height += 10;
                if (panelQLCauHoi.Size == panelQLCauHoi.MaximumSize)
                {
                    timerQLCauHoi.Stop();
                    isCollapsed1 = false;
                }
            }
            else
            {
                btnQuizManager.Image = Resources.Expand_Arrow_20px;
                panelQLCauHoi.Height -= 10;
                if (panelQLCauHoi.Size == panelQLCauHoi.MinimumSize)
                {
                    timerQLCauHoi.Stop();
                    isCollapsed1 = true;
                }
            }
        }

        private void LamBaiThi_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnLamBaiThi.Image = Resources.Collapse_Arrow_20px;
                panelLamBaiThi.Height += 10;
                if (panelLamBaiThi.Size == panelLamBaiThi.MaximumSize)
                {
                    timerLamBaiThi.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnLamBaiThi.Image = Resources.Expand_Arrow_20px;
                panelLamBaiThi.Height -= 10;
                if (panelLamBaiThi.Size == panelLamBaiThi.MinimumSize)
                {
                    timerLamBaiThi.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnQLKyThi_Click(object sender, EventArgs e)
        {
            timeQLKyThi.Start();
        }

        private void ThongKe_Tick(object sender, EventArgs e)
        {
            if (isCollapsed5)
            {
                btnThongKe.Image = Resources.Collapse_Arrow_20px;
                panelThongKe.Height += 10;
                if (panelThongKe.Size == panelThongKe.MaximumSize)
                {
                    timerThongKe.Stop();
                    isCollapsed5 = false;
                }
            }
            else
            {
                btnThongKe.Image = Resources.Expand_Arrow_20px;
                panelThongKe.Height -= 10;
                if (panelThongKe.Size == panelThongKe.MinimumSize)
                {
                    timerThongKe.Stop();
                    isCollapsed5 = true;
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            timerThongKe.Start();
        }

        public void ShowUpdateInfo(int code)
        {
            this.Hide();
            TeacherInfoView screen = new TeacherInfoView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowCreateQuestion(int code)
        {
            this.Hide();
            CreateQuestionView screen = new CreateQuestionView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowQuestionApproval(int code)
        {
            this.Hide();
            QuestionApprovalView screen = new QuestionApprovalView(code);
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

        public void ShowPracticExamView(int userCode)
        {
            this.Hide();
            PracticExamView screen = new PracticExamView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }
    }
}