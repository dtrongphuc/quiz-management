
namespace quiz_management.Views.Teacher.StudentManagement
{
    partial class ExamStatisticView
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbDateTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quiz_management.Views.Teacher.StudentManagement.ExamStatisticReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(873, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbDateTime
            // 
            this.cbDateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDateTime.FormattingEnabled = true;
            this.cbDateTime.Location = new System.Drawing.Point(712, 34);
            this.cbDateTime.Name = "cbDateTime";
            this.cbDateTime.Size = new System.Drawing.Size(135, 21);
            this.cbDateTime.TabIndex = 1;
            this.cbDateTime.SelectedIndexChanged += new System.EventHandler(this.cbDateTime_SelectedIndexChanged);
            this.cbDateTime.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbDateTime_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày thi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thống kê kì thi";
            // 
            // ExamStatisticView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDateTime);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ExamStatisticView";
            this.Text = "ExamStatisticView";
            this.Load += new System.EventHandler(this.Form_Loaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}