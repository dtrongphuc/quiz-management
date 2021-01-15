namespace quiz_management.Presenters.Teacher.ExamManagement
{
    partial class WatchOrPrintExamCompletedView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchOrPrintExamCompletedView));
            this.btnPrint = new System.Windows.Forms.Button();
            this.linkGoBackBefore = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaperID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(274, 453);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 39);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // linkGoBackBefore
            // 
            this.linkGoBackBefore.AutoSize = true;
            this.linkGoBackBefore.Location = new System.Drawing.Point(30, 17);
            this.linkGoBackBefore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkGoBackBefore.Name = "linkGoBackBefore";
            this.linkGoBackBefore.Size = new System.Drawing.Size(38, 13);
            this.linkGoBackBefore.TabIndex = 50;
            this.linkGoBackBefore.TabStop = true;
            this.linkGoBackBefore.Text = "Trở về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "Danh Sách Tổng Kết Kì Thi";
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacher.Location = new System.Drawing.Point(563, 17);
            this.lbTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(74, 13);
            this.lbTeacher.TabIndex = 48;
            this.lbTeacher.Text = "Mai Anh Tuấn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Giáo viên: ";
            // 
            // dgvExam
            // 
            this.dgvExam.AllowUserToAddRows = false;
            this.dgvExam.AllowUserToDeleteRows = false;
            this.dgvExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaKQ,
            this.StudentName,
            this.SubjectName,
            this.PaperID,
            this.Date,
            this.Score});
            this.dgvExam.Location = new System.Drawing.Point(9, 133);
            this.dgvExam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvExam.MultiSelect = false;
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.ReadOnly = true;
            this.dgvExam.RowHeadersVisible = false;
            this.dgvExam.RowHeadersWidth = 51;
            this.dgvExam.RowTemplate.Height = 24;
            this.dgvExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExam.Size = new System.Drawing.Size(682, 298);
            this.dgvExam.TabIndex = 51;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaKQ
            // 
            this.MaKQ.DataPropertyName = "MaKQ";
            this.MaKQ.HeaderText = ".";
            this.MaKQ.MinimumWidth = 6;
            this.MaKQ.Name = "MaKQ";
            this.MaKQ.ReadOnly = true;
            this.MaKQ.Visible = false;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Tên Thí Sinh";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Môn Học";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // PaperID
            // 
            this.PaperID.DataPropertyName = "PaperID";
            this.PaperID.HeaderText = "Mã Bộ Đề";
            this.PaperID.MinimumWidth = 6;
            this.PaperID.Name = "PaperID";
            this.PaperID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày Thi";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "Kết Quả";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // WatchOrPrintExamCompletedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 501);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvExam);
            this.Controls.Add(this.linkGoBackBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WatchOrPrintExamCompletedView";
            this.Text = "WatchOrPrintExamCompletedView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.LinkLabel linkGoBackBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaperID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}