namespace quiz_management.Views.Teacher.PaperManagement
{
    partial class CreatePaperView
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
            this.linkGoBackBefore = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPaperID = new System.Windows.Forms.TextBox();
            this.dgvQuestionList = new System.Windows.Forms.DataGridView();
            this.MaCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreatePaper = new System.Windows.Forms.Button();
            this.btnMoveToSeleted = new System.Windows.Forms.Button();
            this.btnMoveToQuestionList = new System.Windows.Forms.Button();
            this.cbbGrade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQuestionSelectedList = new System.Windows.Forms.DataGridView();
            this.MaCauHoiDaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoiDaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnWatchPaperList = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionSelectedList)).BeginInit();
            this.SuspendLayout();
            // 
            // linkGoBackBefore
            // 
            this.linkGoBackBefore.AutoSize = true;
            this.linkGoBackBefore.Location = new System.Drawing.Point(38, 23);
            this.linkGoBackBefore.Name = "linkGoBackBefore";
            this.linkGoBackBefore.Size = new System.Drawing.Size(49, 17);
            this.linkGoBackBefore.TabIndex = 7;
            this.linkGoBackBefore.TabStop = true;
            this.linkGoBackBefore.Text = "Trở về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tạo Đề Thi";
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacher.Location = new System.Drawing.Point(901, 23);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(96, 17);
            this.lbTeacher.TabIndex = 5;
            this.lbTeacher.Text = "Mai Anh Tuấn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(806, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giáo viên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã đề:";
            // 
            // tbPaperID
            // 
            this.tbPaperID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaperID.Location = new System.Drawing.Point(142, 125);
            this.tbPaperID.Name = "tbPaperID";
            this.tbPaperID.ReadOnly = true;
            this.tbPaperID.Size = new System.Drawing.Size(168, 27);
            this.tbPaperID.TabIndex = 9;
            // 
            // dgvQuestionList
            // 
            this.dgvQuestionList.AllowUserToAddRows = false;
            this.dgvQuestionList.AllowUserToDeleteRows = false;
            this.dgvQuestionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCauHoi,
            this.CauHoi1});
            this.dgvQuestionList.Location = new System.Drawing.Point(48, 267);
            this.dgvQuestionList.Name = "dgvQuestionList";
            this.dgvQuestionList.ReadOnly = true;
            this.dgvQuestionList.RowHeadersVisible = false;
            this.dgvQuestionList.RowHeadersWidth = 51;
            this.dgvQuestionList.RowTemplate.Height = 24;
            this.dgvQuestionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestionList.Size = new System.Drawing.Size(416, 271);
            this.dgvQuestionList.TabIndex = 10;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Danh sách câu hỏi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(687, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Danh sách câu hỏi đã chọn";
            // 
            // btnCreatePaper
            // 
            this.btnCreatePaper.Location = new System.Drawing.Point(447, 588);
            this.btnCreatePaper.Name = "btnCreatePaper";
            this.btnCreatePaper.Size = new System.Drawing.Size(165, 48);
            this.btnCreatePaper.TabIndex = 14;
            this.btnCreatePaper.Text = "Tạo đề thi";
            this.btnCreatePaper.UseVisualStyleBackColor = true;
            // 
            // btnMoveToSeleted
            // 
            this.btnMoveToSeleted.Location = new System.Drawing.Point(503, 348);
            this.btnMoveToSeleted.Name = "btnMoveToSeleted";
            this.btnMoveToSeleted.Size = new System.Drawing.Size(46, 46);
            this.btnMoveToSeleted.TabIndex = 15;
            this.btnMoveToSeleted.Text = ">";
            this.btnMoveToSeleted.UseVisualStyleBackColor = true;
            // 
            // btnMoveToQuestionList
            // 
            this.btnMoveToQuestionList.Location = new System.Drawing.Point(503, 418);
            this.btnMoveToQuestionList.Name = "btnMoveToQuestionList";
            this.btnMoveToQuestionList.Size = new System.Drawing.Size(46, 46);
            this.btnMoveToQuestionList.TabIndex = 17;
            this.btnMoveToQuestionList.Text = "<";
            this.btnMoveToQuestionList.UseVisualStyleBackColor = true;
            // 
            // cbbGrade
            // 
            this.cbbGrade.DisplayMember = "tenKhoiLop";
            this.cbbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGrade.FormattingEnabled = true;
            this.cbbGrade.Location = new System.Drawing.Point(442, 124);
            this.cbbGrade.Name = "cbbGrade";
            this.cbbGrade.Size = new System.Drawing.Size(186, 28);
            this.cbbGrade.TabIndex = 19;
            this.cbbGrade.ValueMember = "maKhoiLop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Khối lớp:";
            // 
            // dgvQuestionSelectedList
            // 
            this.dgvQuestionSelectedList.AllowUserToAddRows = false;
            this.dgvQuestionSelectedList.AllowUserToDeleteRows = false;
            this.dgvQuestionSelectedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestionSelectedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionSelectedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCauHoiDaChon,
            this.CauHoiDaChon});
            this.dgvQuestionSelectedList.Location = new System.Drawing.Point(581, 267);
            this.dgvQuestionSelectedList.Name = "dgvQuestionSelectedList";
            this.dgvQuestionSelectedList.ReadOnly = true;
            this.dgvQuestionSelectedList.RowHeadersVisible = false;
            this.dgvQuestionSelectedList.RowHeadersWidth = 51;
            this.dgvQuestionSelectedList.RowTemplate.Height = 24;
            this.dgvQuestionSelectedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestionSelectedList.Size = new System.Drawing.Size(416, 271);
            this.dgvQuestionSelectedList.TabIndex = 21;
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
            // btnWatchPaperList
            // 
            this.btnWatchPaperList.Location = new System.Drawing.Point(809, 53);
            this.btnWatchPaperList.Name = "btnWatchPaperList";
            this.btnWatchPaperList.Size = new System.Drawing.Size(188, 35);
            this.btnWatchPaperList.TabIndex = 22;
            this.btnWatchPaperList.Text = "Xem danh sách đề thi";
            this.btnWatchPaperList.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "(*) Một đề ít nhất 20 câu hỏi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(727, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Môn học:";
            // 
            // cbbSubject
            // 
            this.cbbSubject.DisplayMember = "tenMonHoc";
            this.cbbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(818, 124);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(179, 28);
            this.cbbSubject.TabIndex = 24;
            this.cbbSubject.ValueMember = "maMonHoc";
            // 
            // CreatePaperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 667);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnWatchPaperList);
            this.Controls.Add(this.dgvQuestionSelectedList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbGrade);
            this.Controls.Add(this.btnMoveToQuestionList);
            this.Controls.Add(this.btnMoveToSeleted);
            this.Controls.Add(this.btnCreatePaper);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvQuestionList);
            this.Controls.Add(this.tbPaperID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkGoBackBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.label1);
            this.Name = "CreatePaperView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePaperView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionSelectedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkGoBackBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPaperID;
        private System.Windows.Forms.DataGridView dgvQuestionList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreatePaper;
        private System.Windows.Forms.Button btnMoveToSeleted;
        private System.Windows.Forms.Button btnMoveToQuestionList;
        private System.Windows.Forms.ComboBox cbbGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvQuestionSelectedList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi1;
        private System.Windows.Forms.Button btnWatchPaperList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauHoiDaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoiDaChon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbSubject;
    }
}