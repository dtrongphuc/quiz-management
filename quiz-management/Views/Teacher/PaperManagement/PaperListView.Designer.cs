namespace quiz_management.Views.Teacher.PaperManagement
{
    partial class PaperListView
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvPaper = new System.Windows.Forms.DataGridView();
            this.PaperCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkGoBackBefore = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(263, 535);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 48);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvPaper
            // 
            this.dgvPaper.AllowUserToAddRows = false;
            this.dgvPaper.AllowUserToDeleteRows = false;
            this.dgvPaper.AllowUserToResizeRows = false;
            this.dgvPaper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaperCode,
            this.Subject,
            this.Grade,
            this.QuestionNum,
            this.Status});
            this.dgvPaper.Location = new System.Drawing.Point(71, 146);
            this.dgvPaper.Name = "dgvPaper";
            this.dgvPaper.ReadOnly = true;
            this.dgvPaper.RowHeadersVisible = false;
            this.dgvPaper.RowHeadersWidth = 51;
            this.dgvPaper.RowTemplate.Height = 24;
            this.dgvPaper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaper.Size = new System.Drawing.Size(751, 336);
            this.dgvPaper.TabIndex = 29;
            // 
            // PaperCode
            // 
            this.PaperCode.DataPropertyName = "PaperCode";
            this.PaperCode.HeaderText = "Mã đề";
            this.PaperCode.MinimumWidth = 6;
            this.PaperCode.Name = "PaperCode";
            this.PaperCode.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Môn học";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Khối lớp";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // QuestionNum
            // 
            this.QuestionNum.DataPropertyName = "QuestionNum";
            this.QuestionNum.HeaderText = "Số câu hỏi";
            this.QuestionNum.MinimumWidth = 6;
            this.QuestionNum.Name = "QuestionNum";
            this.QuestionNum.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // linkGoBackBefore
            // 
            this.linkGoBackBefore.AutoSize = true;
            this.linkGoBackBefore.Location = new System.Drawing.Point(29, 21);
            this.linkGoBackBefore.Name = "linkGoBackBefore";
            this.linkGoBackBefore.Size = new System.Drawing.Size(49, 17);
            this.linkGoBackBefore.TabIndex = 26;
            this.linkGoBackBefore.TabStop = true;
            this.linkGoBackBefore.Text = "Trở về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Danh Sách Đề Thi";
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacher.Location = new System.Drawing.Point(113, 619);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(96, 17);
            this.lbTeacher.TabIndex = 24;
            this.lbTeacher.Text = "Mai Anh Tuấn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Giáo viên: ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(463, 535);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 48);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // PaperListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 655);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvPaper);
            this.Controls.Add(this.linkGoBackBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.label1);
            this.Name = "PaperListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaperListView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvPaper;
        private System.Windows.Forms.LinkLabel linkGoBackBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaperCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}