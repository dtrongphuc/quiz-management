namespace quiz_management.Views.Administrator.UserManagement
{
    partial class UpdateUserView
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
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.linkGoBack = new System.Windows.Forms.LinkLabel();
            this.tbAcountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdminName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTitle2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Lớp:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(282, 306);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(305, 22);
            this.dtpDOB.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Ngày sinh:";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(283, 239);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(305, 27);
            this.tbUserName.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Tên người dùng:";
            // 
            // cbbClass
            // 
            this.cbbClass.DisplayMember = "tenLopHoc";
            this.cbbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(282, 359);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(91, 28);
            this.cbbClass.TabIndex = 56;
            this.cbbClass.ValueMember = "maLopHoc";
            // 
            // linkGoBack
            // 
            this.linkGoBack.AutoSize = true;
            this.linkGoBack.Location = new System.Drawing.Point(36, 38);
            this.linkGoBack.Name = "linkGoBack";
            this.linkGoBack.Size = new System.Drawing.Size(49, 17);
            this.linkGoBack.TabIndex = 55;
            this.linkGoBack.TabStop = true;
            this.linkGoBack.Text = "Trở về";
            // 
            // tbAcountName
            // 
            this.tbAcountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAcountName.Location = new System.Drawing.Point(283, 186);
            this.tbAcountName.Name = "tbAcountName";
            this.tbAcountName.ReadOnly = true;
            this.tbAcountName.Size = new System.Drawing.Size(305, 27);
            this.tbAcountName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tên tài khoản:";
            // 
            // lbAdminName
            // 
            this.lbAdminName.AutoSize = true;
            this.lbAdminName.Location = new System.Drawing.Point(631, 38);
            this.lbAdminName.Name = "lbAdminName";
            this.lbAdminName.Size = new System.Drawing.Size(131, 17);
            this.lbAdminName.TabIndex = 48;
            this.lbAdminName.Text = "Nguyễn Hiếu Nghĩa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Quản trị viên:";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOB.Location = new System.Drawing.Point(682, 524);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(80, 17);
            this.lbDOB.TabIndex = 46;
            this.lbDOB.Text = "20/10/2000";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(315, 433);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(217, 60);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Lưu Chinh Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtTitle2
            // 
            this.txtTitle2.AutoSize = true;
            this.txtTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle2.Location = new System.Drawing.Point(297, 116);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(290, 32);
            this.txtTitle2.TabIndex = 44;
            this.txtTitle2.Text = "Chỉnh Sửa Thông Tin ";
            // 
            // UpdateUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 566);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.linkGoBack);
            this.Controls.Add(this.tbAcountName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAdminName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDOB);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTitle2);
            this.Name = "UpdateUserView";
            this.Text = "UpdateUserView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.LinkLabel linkGoBack;
        private System.Windows.Forms.TextBox tbAcountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAdminName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label txtTitle2;
    }
}