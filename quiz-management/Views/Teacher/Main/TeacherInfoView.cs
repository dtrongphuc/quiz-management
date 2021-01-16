using quiz_management.Presenters.Teacher.Main;
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
    public partial class TeacherInfoView : Form, ITeacherInfoView
    {
        private TeacherInfoPresenter presenter;

        public TeacherInfoView(int code)
        {
            InitializeComponent();
            presenter = new TeacherInfoPresenter(this, code);
            AutoValidate = AutoValidate.Disable;
            btnUpdate.Click += (_, e) =>
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ dữ liệu hợp lệ");
                    return;
                }
                UpdateInfo?.Invoke(btnUpdate, e);
            };

            btnClose.Click += (_, e) =>
            {
                ClosePage?.Invoke(btnClose, e);
            };

            tbDOB.GotFocus += (_, e) =>
            {
                if (tbDOB.Text == "dd/mm/yyyy")
                {
                    tbDOB.Text = "";
                }
            };

            tbDOB.LostFocus += (_, e) =>
            {
                if (string.IsNullOrWhiteSpace(tbDOB.Text))
                    tbDOB.Text = "dd/mm/yyyy";
            };
        }

        public string TeacherName { get => tbName.Text; set => tbName.Text = value; }
        public string TeacherID { set => tbID.Text = value; }
        public string DOB { get => tbDOB.Text; set => tbDOB.Text = value; }

        public event EventHandler ClosePage;

        public event EventHandler UpdateInfo;

        public void ShowMainTeacher(int code)
        {
            this.Hide();
            MainTeacherView screen = new MainTeacherView(code);
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Thông báo");
        }
    }
}