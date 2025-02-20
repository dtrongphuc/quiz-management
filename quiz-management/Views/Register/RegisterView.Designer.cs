﻿namespace quiz_management.Views.Student
{
    partial class RegisterView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterView));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ToLoginView = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.rbHs = new System.Windows.Forms.RadioButton();
            this.rbGv = new System.Windows.Forms.RadioButton();
            this.Username_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.FullName_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.Date_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.Password_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.ConfirmPassword_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.gbRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // lbRegister
            // 
            this.lbRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.Location = new System.Drawing.Point(333, 17);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(110, 29);
            this.lbRegister.TabIndex = 6;
            this.lbRegister.Text = "Đăng Ký";
            this.lbRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập lại mật khẩu: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Họ và tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày sinh:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(208, 124);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(460, 22);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(208, 169);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(460, 22);
            this.txtFullName.TabIndex = 18;
            this.txtFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFullName_KeyDown);
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(208, 213);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(168, 22);
            this.txtBirthday.TabIndex = 19;
            this.txtBirthday.Text = "dd/mm/yyyy";
            this.txtBirthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBirthday_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(208, 263);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(460, 22);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(208, 311);
            this.txtPasswordConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(460, 22);
            this.txtPasswordConfirm.TabIndex = 21;
            this.txtPasswordConfirm.UseSystemPasswordChar = true;
            this.txtPasswordConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordConfirm_KeyDown);
            this.txtPasswordConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(324, 367);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 62);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Đăng ký";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Đã có tài khoản?";
            // 
            // ToLoginView
            // 
            this.ToLoginView.AutoSize = true;
            this.ToLoginView.Location = new System.Drawing.Point(444, 452);
            this.ToLoginView.Name = "ToLoginView";
            this.ToLoginView.Size = new System.Drawing.Size(78, 17);
            this.ToLoginView.TabIndex = 23;
            this.ToLoginView.TabStop = true;
            this.ToLoginView.Text = "Đăng nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Lớp:";
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(508, 212);
            this.cbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(160, 24);
            this.cbClass.TabIndex = 26;
            // 
            // gbRole
            // 
            this.gbRole.Controls.Add(this.rbHs);
            this.gbRole.Controls.Add(this.rbGv);
            this.gbRole.Location = new System.Drawing.Point(55, 50);
            this.gbRole.Margin = new System.Windows.Forms.Padding(4);
            this.gbRole.Name = "gbRole";
            this.gbRole.Padding = new System.Windows.Forms.Padding(4);
            this.gbRole.Size = new System.Drawing.Size(615, 52);
            this.gbRole.TabIndex = 27;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "Phân hệ";
            // 
            // rbHs
            // 
            this.rbHs.AutoSize = true;
            this.rbHs.Checked = true;
            this.rbHs.Location = new System.Drawing.Point(153, 23);
            this.rbHs.Margin = new System.Windows.Forms.Padding(4);
            this.rbHs.Name = "rbHs";
            this.rbHs.Size = new System.Drawing.Size(84, 21);
            this.rbHs.TabIndex = 31;
            this.rbHs.TabStop = true;
            this.rbHs.Text = "Học sinh";
            this.rbHs.UseVisualStyleBackColor = true;
            this.rbHs.CheckedChanged += new System.EventHandler(this.rbHs_CheckedChanged);
            // 
            // rbGv
            // 
            this.rbGv.AutoSize = true;
            this.rbGv.Location = new System.Drawing.Point(396, 23);
            this.rbGv.Margin = new System.Windows.Forms.Padding(4);
            this.rbGv.Name = "rbGv";
            this.rbGv.Size = new System.Drawing.Size(89, 21);
            this.rbGv.TabIndex = 30;
            this.rbGv.Text = "Giáo viên";
            this.rbGv.UseVisualStyleBackColor = true;
            this.rbGv.CheckedChanged += new System.EventHandler(this.rbGv_CheckedChanged);
            // 
            // Username_Validator
            // 
            this.Username_Validator.ControlToValidate = this.txtUsername;
            this.Username_Validator.ErrorMessage = "Tên đăng nhập không hợp lệ";
            this.Username_Validator.InitialValue = null;
            this.Username_Validator.IsValid = false;
            this.Username_Validator.Regex = "^([a-z])[a-z0-9]{2,16}$";
            // 
            // FullName_Validator
            // 
            this.FullName_Validator.ControlToValidate = this.txtFullName;
            this.FullName_Validator.ErrorMessage = "Họ tên không hợp lệ";
            this.FullName_Validator.InitialValue = null;
            this.FullName_Validator.IsValid = false;
            this.FullName_Validator.Regex = "^[^\\d]+$";
            // 
            // Date_Validator
            // 
            this.Date_Validator.ControlToValidate = this.txtBirthday;
            this.Date_Validator.ErrorMessage = "Ngày sinh không hợp lệ";
            this.Date_Validator.InitialValue = null;
            this.Date_Validator.IsValid = false;
            this.Date_Validator.Regex = resources.GetString("Date_Validator.Regex");
            // 
            // Password_Validator
            // 
            this.Password_Validator.ControlToValidate = this.txtPassword;
            this.Password_Validator.ErrorMessage = "Mật khẩu từ 3 - 10 ký tự";
            this.Password_Validator.InitialValue = null;
            this.Password_Validator.IsValid = false;
            this.Password_Validator.Regex = "^\\S{3,10}$";
            // 
            // ConfirmPassword_Validator
            // 
            this.ConfirmPassword_Validator.ControlToValidate = this.txtPasswordConfirm;
            this.ConfirmPassword_Validator.ErrorMessage = "Mật khẩu từ 3 - 10 ký tự";
            this.ConfirmPassword_Validator.InitialValue = null;
            this.ConfirmPassword_Validator.IsValid = false;
            this.ConfirmPassword_Validator.Regex = "^\\S{3,10}$";
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 502);
            this.Controls.Add(this.gbRole);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ToLoginView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterView";
            this.gbRole.ResumeLayout(false);
            this.gbRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Validate.RequiredFieldValidator Username_Validator;
        private Validate.RequiredFieldValidator FullName_Validator;
        private Validate.RequiredFieldValidator Date_Validator;
        private Validate.RequiredFieldValidator Password_Validator;
        private Validate.RequiredFieldValidator ConfirmPassword_Validator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel ToLoginView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.GroupBox gbRole;
        private System.Windows.Forms.RadioButton rbHs;
        private System.Windows.Forms.RadioButton rbGv;
    }
}