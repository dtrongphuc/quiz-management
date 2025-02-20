﻿namespace quiz_management.Views.Student.InfoPersonal
{
    partial class ProfileView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileView));
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDOBStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.Date_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.FullName_Validator = new quiz_management.Validate.RequiredFieldValidator(this.components);
            this.SuspendLayout();
            // 
            // cbLop
            // 
            this.cbLop.DisplayMember = "tenLopHoc";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(157, 289);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(237, 21);
            this.cbLop.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(327, 344);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 38);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(157, 344);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 38);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Lưu Thông Tin";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã lớp";
            // 
            // txtDOBStudent
            // 
            this.txtDOBStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOBStudent.Location = new System.Drawing.Point(156, 232);
            this.txtDOBStudent.Margin = new System.Windows.Forms.Padding(2);
            this.txtDOBStudent.Name = "txtDOBStudent";
            this.txtDOBStudent.Size = new System.Drawing.Size(238, 23);
            this.txtDOBStudent.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày sinh";
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameStudent.Location = new System.Drawing.Point(156, 176);
            this.txtNameStudent.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(238, 23);
            this.txtNameStudent.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Họ và tên";
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Enabled = false;
            this.txtIdStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdStudent.Location = new System.Drawing.Point(157, 127);
            this.txtIdStudent.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(238, 23);
            this.txtIdStudent.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã số sinh viên: ";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(152, 54);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(180, 24);
            this.lbLogin.TabIndex = 14;
            this.lbLogin.Text = "Thông tin cá nhân";
            // 
            // Date_Validator
            // 
            this.Date_Validator.ControlToValidate = this.txtDOBStudent;
            this.Date_Validator.ErrorMessage = "Ngày sinh không hợp lệ";
            this.Date_Validator.InitialValue = null;
            this.Date_Validator.IsValid = false;
            this.Date_Validator.Regex = resources.GetString("Date_Validator.Regex");
            // 
            // FullName_Validator
            // 
            this.FullName_Validator.ControlToValidate = this.txtNameStudent;
            this.FullName_Validator.ErrorMessage = "Họ tên không hợp lệ";
            this.FullName_Validator.InitialValue = null;
            this.FullName_Validator.IsValid = false;
            this.FullName_Validator.Regex = "^[^\\d]+$";
            // 
            // ProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 424);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDOBStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogin);
            this.Name = "ProfileView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDOBStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLogin;
        private Validate.RequiredFieldValidator Date_Validator;
        private Validate.RequiredFieldValidator FullName_Validator;
    }
}