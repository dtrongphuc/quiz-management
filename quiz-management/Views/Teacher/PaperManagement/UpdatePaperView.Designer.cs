namespace quiz_management.Views.Teacher.PaperManagement
{
    partial class UpdatePaperView
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
            this.dgvQuestionSelectedList = new System.Windows.Forms.DataGridView();
            this.MaCauHoiDaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoiDaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoveToQuestionList = new System.Windows.Forms.Button();
            this.btnMoveToSeleted = new System.Windows.Forms.Button();
            this.btnUpdatePaper = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvQuestionList = new System.Windows.Forms.DataGridView();
            this.MaCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkGoBackBefore = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPaperID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.lbExam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionSelectedList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuestionSelectedList
            // 
            this.dgvQuestionSelectedList.AllowUserToAddRows = false;
            this.dgvQuestionSelectedList.AllowUserToDeleteRows = false;
            this.dgvQuestionSelectedList.AllowUserToResizeRows = false;
            this.dgvQuestionSelectedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestionSelectedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionSelectedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCauHoiDaChon,
            this.CauHoiDaChon});
            this.dgvQuestionSelectedList.Location = new System.Drawing.Point(585, 290);
            this.dgvQuestionSelectedList.Name = "dgvQuestionSelectedList";
            this.dgvQuestionSelectedList.ReadOnly = true;
            this.dgvQuestionSelectedList.RowHeadersVisible = false;
            this.dgvQuestionSelectedList.RowHeadersWidth = 51;
            this.dgvQuestionSelectedList.RowTemplate.Height = 24;
            this.dgvQuestionSelectedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestionSelectedList.Size = new System.Drawing.Size(416, 271);
            this.dgvQuestionSelectedList.TabIndex = 40;
            // 
            // MaCauHoiDaChon
            // 
            this.MaCauHoiDaChon.DataPropertyName = "QuestionID";
            this.MaCauHoiDaChon.HeaderText = "Mã câu hỏi";
            this.MaCauHoiDaChon.MinimumWidth = 6;
            this.MaCauHoiDaChon.Name = "MaCauHoiDaChon";
            this.MaCauHoiDaChon.ReadOnly = true;
            this.MaCauHoiDaChon.Visible = false;
            // 
            // CauHoiDaChon
            // 
            this.CauHoiDaChon.DataPropertyName = "Question";
            this.CauHoiDaChon.HeaderText = "Câu hỏi";
            this.CauHoiDaChon.MinimumWidth = 6;
            this.CauHoiDaChon.Name = "CauHoiDaChon";
            this.CauHoiDaChon.ReadOnly = true;
            // 
            // btnMoveToQuestionList
            // 
            this.btnMoveToQuestionList.Location = new System.Drawing.Point(507, 441);
            this.btnMoveToQuestionList.Name = "btnMoveToQuestionList";
            this.btnMoveToQuestionList.Size = new System.Drawing.Size(46, 46);
            this.btnMoveToQuestionList.TabIndex = 37;
            this.btnMoveToQuestionList.Text = "<";
            this.btnMoveToQuestionList.UseVisualStyleBackColor = true;
            // 
            // btnMoveToSeleted
            // 
            this.btnMoveToSeleted.Location = new System.Drawing.Point(507, 371);
            this.btnMoveToSeleted.Name = "btnMoveToSeleted";
            this.btnMoveToSeleted.Size = new System.Drawing.Size(46, 46);
            this.btnMoveToSeleted.TabIndex = 36;
            this.btnMoveToSeleted.Text = ">";
            this.btnMoveToSeleted.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePaper
            // 
            this.btnUpdatePaper.Location = new System.Drawing.Point(451, 602);
            this.btnUpdatePaper.Name = "btnUpdatePaper";
            this.btnUpdatePaper.Size = new System.Drawing.Size(165, 48);
            this.btnUpdatePaper.TabIndex = 35;
            this.btnUpdatePaper.Text = "Cập nhật";
            this.btnUpdatePaper.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(691, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Danh sách câu hỏi đã chọn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Danh sách câu hỏi";
            // 
            // dgvQuestionList
            // 
            this.dgvQuestionList.AllowUserToAddRows = false;
            this.dgvQuestionList.AllowUserToDeleteRows = false;
            this.dgvQuestionList.AllowUserToResizeRows = false;
            this.dgvQuestionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCauHoi,
            this.CauHoi1});
            this.dgvQuestionList.Location = new System.Drawing.Point(52, 290);
            this.dgvQuestionList.Name = "dgvQuestionList";
            this.dgvQuestionList.ReadOnly = true;
            this.dgvQuestionList.RowHeadersVisible = false;
            this.dgvQuestionList.RowHeadersWidth = 51;
            this.dgvQuestionList.RowTemplate.Height = 24;
            this.dgvQuestionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestionList.Size = new System.Drawing.Size(416, 271);
            this.dgvQuestionList.TabIndex = 32;
            // 
            // MaCauHoi
            // 
            this.MaCauHoi.DataPropertyName = "QuestionID";
            this.MaCauHoi.HeaderText = "Mã câu hỏi";
            this.MaCauHoi.MinimumWidth = 6;
            this.MaCauHoi.Name = "MaCauHoi";
            this.MaCauHoi.ReadOnly = true;
            this.MaCauHoi.Visible = false;
            // 
            // CauHoi1
            // 
            this.CauHoi1.DataPropertyName = "Question";
            this.CauHoi1.HeaderText = "Câu hỏi";
            this.CauHoi1.MinimumWidth = 6;
            this.CauHoi1.Name = "CauHoi1";
            this.CauHoi1.ReadOnly = true;
            // 
            // linkGoBackBefore
            // 
            this.linkGoBackBefore.AutoSize = true;
            this.linkGoBackBefore.Location = new System.Drawing.Point(42, 28);
            this.linkGoBackBefore.Name = "linkGoBackBefore";
            this.linkGoBackBefore.Size = new System.Drawing.Size(49, 17);
            this.linkGoBackBefore.TabIndex = 29;
            this.linkGoBackBefore.TabStop = true;
            this.linkGoBackBefore.Text = "Trở về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cập Nhật Đề Thi";
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacher.Location = new System.Drawing.Point(124, 652);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(96, 17);
            this.lbTeacher.TabIndex = 27;
            this.lbTeacher.Text = "Mai Anh Tuấn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Giáo viên: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(725, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Khối lớp:";
            // 
            // tbPaperID
            // 
            this.tbPaperID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaperID.Location = new System.Drawing.Point(151, 176);
            this.tbPaperID.Name = "tbPaperID";
            this.tbPaperID.ReadOnly = true;
            this.tbPaperID.Size = new System.Drawing.Size(168, 27);
            this.tbPaperID.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mã đề:";
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubject.Location = new System.Drawing.Point(820, 176);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.ReadOnly = true;
            this.tbSubject.Size = new System.Drawing.Size(179, 27);
            this.tbSubject.TabIndex = 49;
            // 
            // tbGrade
            // 
            this.tbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGrade.Location = new System.Drawing.Point(451, 176);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.ReadOnly = true;
            this.tbGrade.Size = new System.Drawing.Size(186, 27);
            this.tbGrade.TabIndex = 50;
            // 
            // lbExam
            // 
            this.lbExam.AutoSize = true;
            this.lbExam.Location = new System.Drawing.Point(491, 112);
            this.lbExam.Name = "lbExam";
            this.lbExam.Size = new System.Drawing.Size(125, 17);
            this.lbExam.TabIndex = 51;
            this.lbExam.Text = "Đề thi: Chính Thức";
            // 
            // UpdatePaperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 688);
            this.Controls.Add(this.lbExam);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPaperID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvQuestionSelectedList);
            this.Controls.Add(this.btnMoveToQuestionList);
            this.Controls.Add(this.btnMoveToSeleted);
            this.Controls.Add(this.btnUpdatePaper);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvQuestionList);
            this.Controls.Add(this.linkGoBackBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePaperView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePaperView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionSelectedList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvQuestionSelectedList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauHoiDaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoiDaChon;
        private System.Windows.Forms.Button btnMoveToQuestionList;
        private System.Windows.Forms.Button btnMoveToSeleted;
        private System.Windows.Forms.Button btnUpdatePaper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvQuestionList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi1;
        private System.Windows.Forms.LinkLabel linkGoBackBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPaperID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label lbExam;
    }
}