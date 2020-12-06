namespace quiz_management.Views.Student
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Username_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.FullName_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.Date_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.Password_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.ConfirmPassword_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // lbRegister
            // 
            this.lbRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.Location = new System.Drawing.Point(194, 21);
            this.lbRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(88, 24);
            this.lbRegister.TabIndex = 6;
            this.lbRegister.Text = "Đăng Ký";
            this.lbRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập lại mật khẩu: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Họ và tên:";
            // 
            // Username_Validator
            // 
            this.Username_Validator.ControlToValidate = null;
            this.Username_Validator.ErrorMessage = null;
            this.Username_Validator.InitialValue = null;
            this.Username_Validator.IsValid = false;
            this.Username_Validator.Regex = null;
            // 
            // FullName_Validator
            // 
            this.FullName_Validator.ControlToValidate = null;
            this.FullName_Validator.ErrorMessage = null;
            this.FullName_Validator.InitialValue = null;
            this.FullName_Validator.IsValid = false;
            this.FullName_Validator.Regex = null;
            // 
            // Date_Validator
            // 
            this.Date_Validator.ControlToValidate = null;
            this.Date_Validator.ErrorMessage = null;
            this.Date_Validator.InitialValue = null;
            this.Date_Validator.IsValid = false;
            this.Date_Validator.Regex = null;
            // 
            // Password_Validator
            // 
            this.Password_Validator.ControlToValidate = null;
            this.Password_Validator.ErrorMessage = null;
            this.Password_Validator.InitialValue = null;
            this.Password_Validator.IsValid = false;
            this.Password_Validator.Regex = null;
            // 
            // ConfirmPassword_Validator
            // 
            this.ConfirmPassword_Validator.ControlToValidate = null;
            this.ConfirmPassword_Validator.ErrorMessage = null;
            this.ConfirmPassword_Validator.InitialValue = null;
            this.ConfirmPassword_Validator.IsValid = false;
            this.ConfirmPassword_Validator.Regex = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày sinh:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(198, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 20);
            this.txtUsername.TabIndex = 17;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(198, 114);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(228, 20);
            this.txtFullName.TabIndex = 18;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(198, 158);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(228, 20);
            this.txtBirthday.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(198, 212);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(228, 20);
            this.txtPassword.TabIndex = 20;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(198, 268);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(228, 20);
            this.txtPasswordConfirm.TabIndex = 21;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(164, 316);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(135, 50);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Đăng ký";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 385);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Đã có tài khoản?";
            // 
            // txtLink
            // 
            this.txtLink.AutoSize = true;
            this.txtLink.Location = new System.Drawing.Point(263, 385);
            this.txtLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(60, 13);
            this.txtLink.TabIndex = 23;
            this.txtLink.TabStop = true;
            this.txtLink.Text = "Đăng nhập";
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 434);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLink);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
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
        private System.Windows.Forms.LinkLabel txtLink;
    }
}