
namespace quiz_management.Views.Administrator.UserManagement
{
    partial class ExportUserView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InfoUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.linkGoBack = new System.Windows.Forms.LinkLabel();
            this.lbAdminName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InfoUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoUserBindingSource
            // 
            this.InfoUserBindingSource.DataSource = typeof(quiz_management.Models.InfoUser);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "UsersDataset";
            reportDataSource2.Value = this.InfoUserBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quiz_management.Views.Administrator.UserManagement.ListUserReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 338);
            this.reportViewer1.TabIndex = 0;
            // 
            // linkGoBack
            // 
            this.linkGoBack.AutoSize = true;
            this.linkGoBack.Location = new System.Drawing.Point(21, 9);
            this.linkGoBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkGoBack.Name = "linkGoBack";
            this.linkGoBack.Size = new System.Drawing.Size(38, 13);
            this.linkGoBack.TabIndex = 59;
            this.linkGoBack.TabStop = true;
            this.linkGoBack.Text = "Trở về";
            this.linkGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGoBack_LinkClicked);
            // 
            // lbAdminName
            // 
            this.lbAdminName.AutoSize = true;
            this.lbAdminName.Location = new System.Drawing.Point(647, 6);
            this.lbAdminName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminName.Name = "lbAdminName";
            this.lbAdminName.Size = new System.Drawing.Size(0, 13);
            this.lbAdminName.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quản trị viên:";
            // 
            // txtTitle2
            // 
            this.txtTitle2.AutoSize = true;
            this.txtTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle2.Location = new System.Drawing.Point(263, 34);
            this.txtTitle2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(241, 26);
            this.txtTitle2.TabIndex = 56;
            this.txtTitle2.Text = "Danh Sách Người Dùng";
            // 
            // ExportUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.linkGoBack);
            this.Controls.Add(this.lbAdminName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ExportUserView";
            this.Text = "ExportUser";
            this.Load += new System.EventHandler(this.ExportUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfoUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InfoUserBindingSource;
        private System.Windows.Forms.LinkLabel linkGoBack;
        private System.Windows.Forms.Label lbAdminName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTitle2;
    }
}