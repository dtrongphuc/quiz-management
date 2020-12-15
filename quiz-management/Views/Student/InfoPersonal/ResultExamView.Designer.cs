namespace quiz_management.Views.Student.InfoPersonal
{
    partial class ResultExamView
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.lbLogin = new System.Windows.Forms.Label();
            this.TenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBoDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cauSai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cauDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuaLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(26, 29);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(36, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Trở lại";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNguoiDung,
            this.MaBoDe,
            this.cauSai,
            this.cauDung,
            this.maNguoiDung,
            this.chuaLam,
            this.ngayLam,
            this.thoiGian,
            this.diem,
            this.maKetQua,
            this.trangThai,
            this.MonHoc});
            this.dgvKetQua.Enabled = false;
            this.dgvKetQua.Location = new System.Drawing.Point(11, 91);
            this.dgvKetQua.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.RowHeadersVisible = false;
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.RowTemplate.Height = 24;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(855, 236);
            this.dgvKetQua.TabIndex = 14;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(396, 42);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(109, 24);
            this.lbLogin.TabIndex = 13;
            this.lbLogin.Text = "Kết quả thi";
            // 
            // TenNguoiDung
            // 
            this.TenNguoiDung.DataPropertyName = "TenNguoiDung";
            this.TenNguoiDung.DividerWidth = 1;
            this.TenNguoiDung.FillWeight = 58.04037F;
            this.TenNguoiDung.HeaderText = "Họ Và Tên";
            this.TenNguoiDung.Name = "TenNguoiDung";
            this.TenNguoiDung.ReadOnly = true;
            // 
            // MaBoDe
            // 
            this.MaBoDe.DataPropertyName = "MaBoDe";
            this.MaBoDe.FillWeight = 40.49627F;
            this.MaBoDe.HeaderText = "Mã Bộ Đề";
            this.MaBoDe.Name = "MaBoDe";
            this.MaBoDe.ReadOnly = true;
            // 
            // cauSai
            // 
            this.cauSai.DataPropertyName = "CauSai";
            this.cauSai.FillWeight = 45.49627F;
            this.cauSai.HeaderText = "Số Câu Sai";
            this.cauSai.Name = "cauSai";
            this.cauSai.ReadOnly = true;
            // 
            // cauDung
            // 
            this.cauDung.DataPropertyName = "CauDung";
            this.cauDung.FillWeight = 45.49627F;
            this.cauDung.HeaderText = "Số Câu Đúng";
            this.cauDung.Name = "cauDung";
            this.cauDung.ReadOnly = true;
            // 
            // maNguoiDung
            // 
            this.maNguoiDung.HeaderText = "maNguoiDung";
            this.maNguoiDung.Name = "maNguoiDung";
            this.maNguoiDung.ReadOnly = true;
            this.maNguoiDung.Visible = false;
            // 
            // chuaLam
            // 
            this.chuaLam.DataPropertyName = "ChuaLam";
            this.chuaLam.FillWeight = 45.49627F;
            this.chuaLam.HeaderText = "Số Chưa Làm";
            this.chuaLam.Name = "chuaLam";
            this.chuaLam.ReadOnly = true;
            // 
            // ngayLam
            // 
            this.ngayLam.DataPropertyName = "NgayLam";
            this.ngayLam.FillWeight = 45.49627F;
            this.ngayLam.HeaderText = "Ngày Làm";
            this.ngayLam.Name = "ngayLam";
            this.ngayLam.ReadOnly = true;
            // 
            // thoiGian
            // 
            this.thoiGian.DataPropertyName = "ThoiGian";
            this.thoiGian.FillWeight = 45.49627F;
            this.thoiGian.HeaderText = "Thời Gian";
            this.thoiGian.Name = "thoiGian";
            this.thoiGian.ReadOnly = true;
            // 
            // diem
            // 
            this.diem.DataPropertyName = "Diem";
            this.diem.FillWeight = 30.49627F;
            this.diem.HeaderText = "Điểm";
            this.diem.Name = "diem";
            this.diem.ReadOnly = true;
            // 
            // maKetQua
            // 
            this.maKetQua.HeaderText = "maKetQua";
            this.maKetQua.Name = "maKetQua";
            this.maKetQua.ReadOnly = true;
            this.maKetQua.Visible = false;
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "trangThai";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangThai.Visible = false;
            // 
            // MonHoc
            // 
            this.MonHoc.DataPropertyName = "MonHoc";
            this.MonHoc.FillWeight = 40.7446F;
            this.MonHoc.HeaderText = "Môn Học";
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.ReadOnly = true;
            // 
            // ResultExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 366);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.lbLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ResultExamView";
            this.Text = "ResultExamView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBoDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cauSai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cauDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuaLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
    }
}