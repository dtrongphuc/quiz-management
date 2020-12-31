using quiz_management.Models;
using quiz_management.Presenters.Register;
using quiz_management.Views.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Student
{
    public partial class RegisterView : Form, IRegisterView
    {
        private RegisterPresenter presenter;
        private ErrorProvider errorProvider = new ErrorProvider();

        public string Username { get => txtUsername.Text.Trim(); set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text.Trim(); set => txtPassword.Text = value; }
        public string FullName { get => txtFullName.Text.Trim(); set => txtFullName.Text = value; }
        public string Birthday { get => txtBirthday.Text.Trim(); set => txtBirthday.Text = value; }
        public object ComboboxDataSource { set => cbClass.DataSource = value; }
        public object SelectedClass { get => cbClass.SelectedItem; }

        public event EventHandler Submit;

        public event EventHandler SwitchToLoginView;

        public void ShowMessage(string text)
        {
            MessageBox.Show(text);
        }

        public void ShowLoginView()
        {
            this.Hide();
            LoginView screen = new LoginView();
            screen.FormClosed += (_, e) => this.Close();
            screen.Show();
        }

        public RegisterView()
        {
            InitializeComponent();
            presenter = new RegisterPresenter(this);
            AutoValidate = AutoValidate.Disable;
            cbClass.DisplayMember = "tenLopHoc";

            btnSubmit.Click += (_, e) =>
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ dữ liệu hợp lệ");
                    return;
                }

                if (rbHs.Checked == true && cbClass.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn lớp");
                    return;
                }
                Submit?.Invoke(btnSubmit, e);
            };

            ToLoginView.Click += (_, e) =>
            {
                SwitchToLoginView.Invoke(ToLoginView, e);
            };
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            string confirmPassword = txtPasswordConfirm.Text.Trim();
            string errorMessage = string.Empty;
            if (confirmPassword != Password)
            {
                errorMessage = "Mật khẩu không khớp";
            }
            errorProvider.SetError(txtPasswordConfirm, errorMessage);
        }

        private void rbGv_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked == true)
            {
                cbClass.SelectedItem = null;
                cbClass.Enabled = false;
                return;
            }
        }

        private void rbHs_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked == true)
            {
                cbClass.Enabled = true;
                return;
            }
        }
    }
}