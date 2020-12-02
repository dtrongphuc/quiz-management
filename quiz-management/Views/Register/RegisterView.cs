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
        RegisterPresenter presenter;
        ErrorProvider errorProvider = new ErrorProvider();

        public string Username { get => txtUsername.Text.Trim(); set => txtUsername.Text = value; }
        public string Password { get => txtFullName.Text.Trim(); set => txtFullName.Text = value; }
        public string FullName { get => txtFullName.Text.Trim(); set => txtFullName.Text = value; }
        public string Birthday { get => txtBirthday.Text.Trim(); set => txtBirthday.Text = value; }

        public event EventHandler Submit;
        public void ShowMessage(string text)
        {
            MessageBox.Show(text);
        }

        public RegisterView()
        {
            InitializeComponent();
            presenter = new RegisterPresenter(this);
            AutoValidate = AutoValidate.Disable;

            btnSubmit.Click += (_, e) =>
            {
                if(!ValidateChildren())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ dữ liệu hợp lệ");
                    return;
                }
                Submit?.Invoke(btnSubmit, e);
            };
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            string confirmPassword = txtPasswordConfirm.Text.Trim();
            string errorMessage = string.Empty;
            if(confirmPassword != Password)
            {
                errorMessage = "Mật khẩu không khớp";
            }
            errorProvider.SetError(txtPasswordConfirm, errorMessage);
        }
    }
}
