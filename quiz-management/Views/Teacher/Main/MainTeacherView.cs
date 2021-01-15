using quiz_management.Presenters.Teacher.ExamManagement;
using quiz_management.Presenters.Teacher.Main;
using quiz_management.Properties;
using quiz_management.Views.Student;
using quiz_management.Views.Student.Exam;
using quiz_management.Views.Student.InfoPersonal;
using quiz_management.Views.Teacher.ExamManagement;
using quiz_management.Views.Teacher.MockExamManagement;
using quiz_management.Views.Teacher.PaperManagement;
using quiz_management.Views.Teacher.QuestionManagement;
using quiz_management.Views.Teacher.StudentManagement;
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
        private int _currentCode;
        private MainTeacherPresenter presenter;

        public MainTeacherView(int code)
        {
            InitializeComponent();
            _currentCode = code;
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
            btnLichKyThi.Click += (_, e) =>
            {
                ExamListClick?.Invoke(btnLichKyThi, e);
            };
            btnTongKetKT.Click += (_, e) =>
            {
                WatchOrPrintExamCompletedClick?.Invoke(btnTongKetKT, e);
            };
            btnQLKyThiThu.Click += (_, e) =>
            {
                ListMockExamClick?.Invoke(btnQLKyThiThu, e);
            };
            btnXemDSThi.Click += (_, e) =>
            {
                WatchOrPrintExamClick?.Invoke(btnXemDSThi, e);
            };
            btnQLDeThi.Click += (_, e) =>
            {
                PaperClick?.Invoke(btnQLDeThi, e);
            };
            btnLogout.Click += (_, e) =>
            {
                LogoutClick?.Invoke(btnLogout, e);
            };

            btnTKHS.Click += (_, e) =>
            {
                ShowStudentStatisticView();
            };

            btnTKKyThi.Click += (_, e) =>
            {
                ShowExamStatisticView();
            };

            btnTKCauHoi.Click += (_, e) =>
            {
                ShowQuestionStatisticView();
            };

            btnExamResultView.Click += (_, e) =>
            {
                ShowResultExamView(_currentCode);
            };
        }

        public event EventHandler UpdateInfo;

        public event EventHandler CreateQuestion;

        public event EventHandler QuestionApproval;

        public event EventHandler OfficialExamClick;

        public event EventHandler PracticExamClick;

        public event EventHandler ExamListClick;

        public event EventHandler WatchOrPrintExamCompletedClick;

        public event EventHandler ListMockExamClick;

        public event EventHandler WatchOrPrintExamClick;

        public event EventHandler PaperClick;

        public event EventHandler LogoutClick;

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

        public void ShowResultExamView(int userCode)
        {
            this.Hide();
            ResultExamView screen = new ResultExamView(userCode);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
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

        public void ShowExamListView(int code)
        {
            this.Hide();
            ExamListView screen = new ExamListView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowWatchOrPrintExamCompletedView(int code)
        {
            this.Hide();
            WatchOrPrintExamCompletedView screen = new WatchOrPrintExamCompletedView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowListMockExamView(int code)
        {
            this.Hide();
            ListMockExamView screen = new ListMockExamView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowWatchOrPrintExamView(int code)
        {
            this.Hide();
            WatchOrPrintExamView screen = new WatchOrPrintExamView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowCreatePaper(int code)
        {
            this.Hide();
            CreatePaperView screen = new CreatePaperView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowLogin()
        {
            this.Hide();
            LoginView screen = new LoginView();
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowStudentStatisticView()
        {
            this.Hide();
            StudentStatisticView screen = new StudentStatisticView();
            screen.FormClosed += (_, e) => this.Show();
            screen.Show();
        }

        public void ShowExamStatisticView()
        {
            this.Hide();
            ExamStatisticView screen = new ExamStatisticView();
            screen.FormClosed += (_, e) => this.Show();
            screen.Show();
        }

        public void ShowQuestionStatisticView()
        {
            this.Hide();
            QuestionStatisticView screen = new QuestionStatisticView();
            screen.FormClosed += (_, e) => this.Show();
            screen.Show();
        }
    }
}