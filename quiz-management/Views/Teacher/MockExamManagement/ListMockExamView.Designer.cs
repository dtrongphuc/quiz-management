﻿namespace quiz_management.Views.Teacher.MockExamManagement
{
    partial class ListMockExamView
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvMockExam = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaperID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkGoBackBefore = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTeacher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMockExam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 432);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 39);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(256, 432);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 39);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvMockExam
            // 
            this.dgvMockExam.AllowUserToAddRows = false;
            this.dgvMockExam.AllowUserToDeleteRows = false;
            this.dgvMockExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMockExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMockExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Subject,
            this.Grade,
            this.StartDay,
            this.EndDay,
            this.QuantityStudent,
            this.ExamID,
            this.PaperID});
            this.dgvMockExam.Location = new System.Drawing.Point(27, 117);
            this.dgvMockExam.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMockExam.Name = "dgvMockExam";
            this.dgvMockExam.ReadOnly = true;
            this.dgvMockExam.RowHeadersVisible = false;
            this.dgvMockExam.RowHeadersWidth = 51;
            this.dgvMockExam.RowTemplate.Height = 24;
            this.dgvMockExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMockExam.Size = new System.Drawing.Size(618, 273);
            this.dgvMockExam.TabIndex = 38;
            this.dgvMockExam.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMockExam_CellFormatting);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Môn Học";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Khối Lớp";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // StartDay
            // 
            this.StartDay.DataPropertyName = "StartDay";
            this.StartDay.HeaderText = "Ngày BĐ";
            this.StartDay.MinimumWidth = 6;
            this.StartDay.Name = "StartDay";
            this.StartDay.ReadOnly = true;
            // 
            // EndDay
            // 
            this.EndDay.DataPropertyName = "EndDay";
            this.EndDay.HeaderText = "Ngày KT";
            this.EndDay.MinimumWidth = 6;
            this.EndDay.Name = "EndDay";
            this.EndDay.ReadOnly = true;
            // 
            // QuantityStudent
            // 
            this.QuantityStudent.DataPropertyName = "QuantityStudent";
            this.QuantityStudent.HeaderText = "Số Lượng Thí Sinh";
            this.QuantityStudent.MinimumWidth = 6;
            this.QuantityStudent.Name = "QuantityStudent";
            this.QuantityStudent.ReadOnly = true;
            // 
            // ExamID
            // 
            this.ExamID.DataPropertyName = "ExamID";
            this.ExamID.HeaderText = "Column1";
            this.ExamID.MinimumWidth = 6;
            this.ExamID.Name = "ExamID";
            this.ExamID.ReadOnly = true;
            this.ExamID.Visible = false;
            // 
            // PaperID
            // 
            this.PaperID.DataPropertyName = "PaperID";
            this.PaperID.HeaderText = "Column1";
            this.PaperID.MinimumWidth = 6;
            this.PaperID.Name = "PaperID";
            this.PaperID.ReadOnly = true;
            this.PaperID.Visible = false;
            // 
            // linkGoBackBefore
            // 
            this.linkGoBackBefore.AutoSize = true;
            this.linkGoBackBefore.Location = new System.Drawing.Point(26, 25);
            this.linkGoBackBefore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkGoBackBefore.Name = "linkGoBackBefore";
            this.linkGoBackBefore.Size = new System.Drawing.Size(38, 13);
            this.linkGoBackBefore.TabIndex = 37;
            this.linkGoBackBefore.TabStop = true;
            this.linkGoBackBefore.Text = "Trở về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "Danh Sách Kì Thi Thử";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 513);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Giáo viên: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 432);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 39);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacher.Location = new System.Drawing.Point(89, 513);
            this.lbTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(0, 13);
            this.lbTeacher.TabIndex = 35;
            // 
            // ListMockExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 544);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvMockExam);
            this.Controls.Add(this.linkGoBackBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListMockExamView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListMockExamView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMockExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvMockExam;
        private System.Windows.Forms.LinkLabel linkGoBackBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaperID;
        private System.Windows.Forms.Label lbTeacher;
    }
}