namespace quiz_management.Views.Teacher.ExamManagement
{
    partial class WatchOrPrintExamView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchOrPrintExamView));
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.linkGoBackBefore = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOBExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(367, 549);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(165, 48);
            this.btnPrint.TabIndex = 46;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvExam
            // 
            this.dgvExam.AllowUserToAddRows = false;
            this.dgvExam.AllowUserToDeleteRows = false;
            this.dgvExam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.StudentName,
            this.DOBExam});
            this.dgvExam.Location = new System.Drawing.Point(44, 167);
            this.dgvExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExam.MultiSelect = false;
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.ReadOnly = true;
            this.dgvExam.RowHeadersVisible = false;
            this.dgvExam.RowHeadersWidth = 51;
            this.dgvExam.RowTemplate.Height = 24;
            this.dgvExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExam.Size = new System.Drawing.Size(824, 336);
            this.dgvExam.TabIndex = 45;
            // 
            // linkGoBackBefore
            // 
            this.linkGoBackBefore.AutoSize = true;
            this.linkGoBackBefore.Location = new System.Drawing.Point(41, 25);
            this.linkGoBackBefore.Name = "linkGoBackBefore";
            this.linkGoBackBefore.Size = new System.Drawing.Size(49, 17);
            this.linkGoBackBefore.TabIndex = 44;
            this.linkGoBackBefore.TabStop = true;
            this.linkGoBackBefore.Text = "Trở về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 32);
            this.label3.TabIndex = 43;
            this.label3.Text = "Danh Sách Thí Sinh Của Kì Thi";
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacher.Location = new System.Drawing.Point(752, 25);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(96, 17);
            this.lbTeacher.TabIndex = 42;
            this.lbTeacher.Text = "Mai Anh Tuấn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Giáo viên: ";
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
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Tên Thí Sinh";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // DOBExam
            // 
            this.DOBExam.DataPropertyName = "DOBExam";
            this.DOBExam.HeaderText = "Ngày Thi";
            this.DOBExam.MinimumWidth = 6;
            this.DOBExam.Name = "DOBExam";
            this.DOBExam.ReadOnly = true;
            // 
            // WatchOrPrintExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 626);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvExam);
            this.Controls.Add(this.linkGoBackBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WatchOrPrintExamView";
            this.Text = "WatchOrPrintExamView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.LinkLabel linkGoBackBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOBExam;
    }
}