
namespace quiz_management.Views.Administrator.SystemManagement
{
    partial class DecentralizationView
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.maNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân Quyền";
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNguoiDung,
            this.STT,
            this.tenNguoiDung,
            this.ngaySinh,
            this.quyen});
            this.dgvThongTin.Location = new System.Drawing.Point(12, 107);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.Size = new System.Drawing.Size(590, 279);
            this.dgvThongTin.TabIndex = 1;
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Location = new System.Drawing.Point(27, 25);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(39, 13);
            this.linkBack.TabIndex = 2;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Trở Về";
            // 
            // maNguoiDung
            // 
            this.maNguoiDung.HeaderText = ".";
            this.maNguoiDung.Name = "maNguoiDung";
            this.maNguoiDung.Visible = false;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // tenNguoiDung
            // 
            this.tenNguoiDung.HeaderText = "Họ Tên";
            this.tenNguoiDung.Name = "tenNguoiDung";
            // 
            // ngaySinh
            // 
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.Name = "ngaySinh";
            // 
            // quyen
            // 
            this.quyen.DataPropertyName = "quyen";
            this.quyen.HeaderText = "Phân Quyền";
            this.quyen.Name = "quyen";
            // 
            // DecentralizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 412);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.dgvThongTin);
            this.Controls.Add(this.label1);
            this.Name = "DecentralizationView";
            this.Text = "DecentralizationView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.LinkLabel linkBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn quyen;
    }
}