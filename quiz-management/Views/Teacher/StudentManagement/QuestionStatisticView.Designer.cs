
namespace quiz_management.Views.Teacher.StudentManagement
{
    partial class QuestionStatisticView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuestionStatistic = new System.Windows.Forms.DataGridView();
            this.MaCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLeRaDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLeChonDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLeChonSai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvQuestionStatistic);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "THỐNG KÊ CÂU HỎI";
            // 
            // dgvQuestionStatistic
            // 
            this.dgvQuestionStatistic.AllowUserToAddRows = false;
            this.dgvQuestionStatistic.AllowUserToDeleteRows = false;
            this.dgvQuestionStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestionStatistic.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvQuestionStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCauHoi,
            this.CauHoi,
            this.TiLeRaDe,
            this.TiLeChonDung,
            this.TiLeChonSai});
            this.dgvQuestionStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuestionStatistic.Location = new System.Drawing.Point(0, 0);
            this.dgvQuestionStatistic.Name = "dgvQuestionStatistic";
            this.dgvQuestionStatistic.ReadOnly = true;
            this.dgvQuestionStatistic.RowHeadersVisible = false;
            this.dgvQuestionStatistic.Size = new System.Drawing.Size(800, 339);
            this.dgvQuestionStatistic.TabIndex = 0;
            // 
            // MaCauHoi
            // 
            this.MaCauHoi.DataPropertyName = "MaCauHoi";
            this.MaCauHoi.HeaderText = "Mã câu hỏi";
            this.MaCauHoi.Name = "MaCauHoi";
            this.MaCauHoi.ReadOnly = true;
            // 
            // CauHoi
            // 
            this.CauHoi.DataPropertyName = "CauHoi";
            this.CauHoi.HeaderText = " Câu hỏi";
            this.CauHoi.Name = "CauHoi";
            this.CauHoi.ReadOnly = true;
            // 
            // TiLeRaDe
            // 
            this.TiLeRaDe.DataPropertyName = "TiLeRaDe";
            this.TiLeRaDe.HeaderText = "Tỉ lệ ra đề";
            this.TiLeRaDe.Name = "TiLeRaDe";
            this.TiLeRaDe.ReadOnly = true;
            // 
            // TiLeChonDung
            // 
            this.TiLeChonDung.DataPropertyName = "TiLeChonDung";
            this.TiLeChonDung.HeaderText = "Tỉ lệ chọn đúng";
            this.TiLeChonDung.Name = "TiLeChonDung";
            this.TiLeChonDung.ReadOnly = true;
            // 
            // TiLeChonSai
            // 
            this.TiLeChonSai.DataPropertyName = "TiLeChonSai";
            this.TiLeChonSai.HeaderText = "Tỉ lệ chọn sai";
            this.TiLeChonSai.Name = "TiLeChonSai";
            this.TiLeChonSai.ReadOnly = true;
            // 
            // QuestionStatisticView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "QuestionStatisticView";
            this.Text = "QuestionStatisticView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuestionStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLeRaDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLeChonDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLeChonSai;
    }
}