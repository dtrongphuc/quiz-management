namespace quiz_management.Views.Teacher.MockExamManagement
{
    partial class UpdateMockExamView
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
            this.dgvBoDe = new System.Windows.Forms.DataGridView();
            this.maBoDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgayThiKT = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgHocSinh = new System.Windows.Forms.DataGridView();
            this.HocSinhDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.dgvThiSinh = new System.Windows.Forms.DataGridView();
            this.ThiSinhDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoiDungDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgayThiBD = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.linkGoBackBefore = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDeThiChon = new System.Windows.Forms.DataGridView();
            this.maDeThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbKhoiLop = new System.Windows.Forms.Label();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.btnMoveLeftBoDe = new System.Windows.Forms.Button();
            this.btnMoveRightBoDe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeThiChon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoDe
            // 
            this.dgvBoDe.AllowUserToAddRows = false;
            this.dgvBoDe.AllowUserToDeleteRows = false;
            this.dgvBoDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoDe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBoDe});
            this.dgvBoDe.Location = new System.Drawing.Point(200, 218);
            this.dgvBoDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBoDe.Name = "dgvBoDe";
            this.dgvBoDe.RowHeadersWidth = 51;
            this.dgvBoDe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoDe.Size = new System.Drawing.Size(172, 122);
            this.dgvBoDe.TabIndex = 77;
            // 
            // maBoDe
            // 
            this.maBoDe.DataPropertyName = "maBoDe";
            this.maBoDe.HeaderText = "Mã Bộ Đề";
            this.maBoDe.MinimumWidth = 6;
            this.maBoDe.Name = "maBoDe";
            // 
            // dtNgayThiKT
            // 
            this.dtNgayThiKT.Location = new System.Drawing.Point(302, 135);
            this.dtNgayThiKT.Name = "dtNgayThiKT";
            this.dtNgayThiKT.Size = new System.Drawing.Size(200, 20);
            this.dtNgayThiKT.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Khối Lớp: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Môn Học: ";
            // 
            // dtgHocSinh
            // 
            this.dtgHocSinh.AllowUserToAddRows = false;
            this.dtgHocSinh.AllowUserToDeleteRows = false;
            this.dtgHocSinh.AllowUserToResizeColumns = false;
            this.dtgHocSinh.AllowUserToResizeRows = false;
            this.dtgHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HocSinhDuocChon,
            this.tenNguoidung});
            this.dtgHocSinh.Location = new System.Drawing.Point(45, 361);
            this.dtgHocSinh.Name = "dtgHocSinh";
            this.dtgHocSinh.ReadOnly = true;
            this.dtgHocSinh.RowHeadersVisible = false;
            this.dtgHocSinh.RowHeadersWidth = 51;
            this.dtgHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHocSinh.Size = new System.Drawing.Size(326, 192);
            this.dtgHocSinh.TabIndex = 69;
            // 
            // HocSinhDuocChon
            // 
            this.HocSinhDuocChon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HocSinhDuocChon.DataPropertyName = "maNguoidung";
            this.HocSinhDuocChon.FillWeight = 30.52284F;
            this.HocSinhDuocChon.HeaderText = "MSV";
            this.HocSinhDuocChon.MinimumWidth = 6;
            this.HocSinhDuocChon.Name = "HocSinhDuocChon";
            this.HocSinhDuocChon.ReadOnly = true;
            // 
            // tenNguoidung
            // 
            this.tenNguoidung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNguoidung.DataPropertyName = "tenNguoidung";
            this.tenNguoidung.FillWeight = 98.47716F;
            this.tenNguoidung.HeaderText = "Tên Hoc Sinh";
            this.tenNguoidung.MinimumWidth = 6;
            this.tenNguoidung.Name = "tenNguoidung";
            this.tenNguoidung.ReadOnly = true;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(402, 483);
            this.btnMoveLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(34, 55);
            this.btnMoveLeft.TabIndex = 67;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(402, 395);
            this.btnMoveRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(34, 55);
            this.btnMoveRight.TabIndex = 66;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            // 
            // dgvThiSinh
            // 
            this.dgvThiSinh.AllowUserToAddRows = false;
            this.dgvThiSinh.AllowUserToDeleteRows = false;
            this.dgvThiSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThiSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThiSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThiSinhDuocChon,
            this.tenNguoiDungDuocChon});
            this.dgvThiSinh.Location = new System.Drawing.Point(469, 361);
            this.dgvThiSinh.Name = "dgvThiSinh";
            this.dgvThiSinh.ReadOnly = true;
            this.dgvThiSinh.RowHeadersVisible = false;
            this.dgvThiSinh.RowHeadersWidth = 51;
            this.dgvThiSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThiSinh.Size = new System.Drawing.Size(326, 192);
            this.dgvThiSinh.TabIndex = 65;
            // 
            // ThiSinhDuocChon
            // 
            this.ThiSinhDuocChon.DataPropertyName = "maNguoiDung";
            this.ThiSinhDuocChon.FillWeight = 30.52284F;
            this.ThiSinhDuocChon.HeaderText = "MSV";
            this.ThiSinhDuocChon.MinimumWidth = 6;
            this.ThiSinhDuocChon.Name = "ThiSinhDuocChon";
            this.ThiSinhDuocChon.ReadOnly = true;
            // 
            // tenNguoiDungDuocChon
            // 
            this.tenNguoiDungDuocChon.DataPropertyName = "tenNguoiDung";
            this.tenNguoiDungDuocChon.FillWeight = 98.47716F;
            this.tenNguoiDungDuocChon.HeaderText = "Tên Hoc Sinh";
            this.tenNguoiDungDuocChon.MinimumWidth = 6;
            this.tenNguoiDungDuocChon.Name = "tenNguoiDungDuocChon";
            this.tenNguoiDungDuocChon.ReadOnly = true;
            // 
            // dtNgayThiBD
            // 
            this.dtNgayThiBD.Location = new System.Drawing.Point(45, 135);
            this.dtNgayThiBD.Name = "dtNgayThiBD";
            this.dtNgayThiBD.Size = new System.Drawing.Size(200, 20);
            this.dtNgayThiBD.TabIndex = 64;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(359, 589);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 39);
            this.btnSubmit.TabIndex = 63;
            this.btnSubmit.Text = "Cập Nhật kỳ thi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // linkGoBackBefore
            // 
            this.linkGoBackBefore.AutoSize = true;
            this.linkGoBackBefore.Location = new System.Drawing.Point(41, 24);
            this.linkGoBackBefore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkGoBackBefore.Name = "linkGoBackBefore";
            this.linkGoBackBefore.Size = new System.Drawing.Size(38, 13);
            this.linkGoBackBefore.TabIndex = 62;
            this.linkGoBackBefore.TabStop = true;
            this.linkGoBackBefore.Text = "Trở về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 26);
            this.label3.TabIndex = 61;
            this.label3.Text = "Cập Nhật Kì Thi Thử";
            // 
            // dgvDeThiChon
            // 
            this.dgvDeThiChon.AllowUserToAddRows = false;
            this.dgvDeThiChon.AllowUserToDeleteRows = false;
            this.dgvDeThiChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeThiChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeThiChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDeThi});
            this.dgvDeThiChon.Location = new System.Drawing.Point(469, 218);
            this.dgvDeThiChon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDeThiChon.Name = "dgvDeThiChon";
            this.dgvDeThiChon.RowHeadersWidth = 51;
            this.dgvDeThiChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeThiChon.Size = new System.Drawing.Size(172, 122);
            this.dgvDeThiChon.TabIndex = 80;
            // 
            // maDeThi
            // 
            this.maDeThi.DataPropertyName = "maBoDe";
            this.maDeThi.HeaderText = "Mã Bộ Đề";
            this.maDeThi.MinimumWidth = 6;
            this.maDeThi.Name = "maDeThi";
            // 
            // lbKhoiLop
            // 
            this.lbKhoiLop.AutoSize = true;
            this.lbKhoiLop.Location = new System.Drawing.Point(593, 139);
            this.lbKhoiLop.Name = "lbKhoiLop";
            this.lbKhoiLop.Size = new System.Drawing.Size(26, 13);
            this.lbKhoiLop.TabIndex = 81;
            this.lbKhoiLop.Text = "K10";
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.Location = new System.Drawing.Point(734, 139);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(43, 13);
            this.lbMonHoc.TabIndex = 82;
            this.lbMonHoc.Text = "Lịch Sử";
            // 
            // btnMoveLeftBoDe
            // 
            this.btnMoveLeftBoDe.Location = new System.Drawing.Point(402, 276);
            this.btnMoveLeftBoDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoveLeftBoDe.Name = "btnMoveLeftBoDe";
            this.btnMoveLeftBoDe.Size = new System.Drawing.Size(34, 40);
            this.btnMoveLeftBoDe.TabIndex = 84;
            this.btnMoveLeftBoDe.Text = "<";
            this.btnMoveLeftBoDe.UseVisualStyleBackColor = true;
            // 
            // btnMoveRightBoDe
            // 
            this.btnMoveRightBoDe.Location = new System.Drawing.Point(402, 230);
            this.btnMoveRightBoDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoveRightBoDe.Name = "btnMoveRightBoDe";
            this.btnMoveRightBoDe.Size = new System.Drawing.Size(34, 43);
            this.btnMoveRightBoDe.TabIndex = 83;
            this.btnMoveRightBoDe.Text = ">";
            this.btnMoveRightBoDe.UseVisualStyleBackColor = true;
            // 
            // UpdateMockExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 609);
            this.Controls.Add(this.btnMoveLeftBoDe);
            this.Controls.Add(this.btnMoveRightBoDe);
            this.Controls.Add(this.lbMonHoc);
            this.Controls.Add(this.lbKhoiLop);
            this.Controls.Add(this.dgvDeThiChon);
            this.Controls.Add(this.dgvBoDe);
            this.Controls.Add(this.dtNgayThiKT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgHocSinh);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.dgvThiSinh);
            this.Controls.Add(this.dtNgayThiBD);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.linkGoBackBefore);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateMockExamView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateMockExamView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeThiChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBoDe;
        private System.Windows.Forms.DateTimePicker dtNgayThiKT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocSinhDuocChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoidung;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.DataGridView dgvThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThiSinhDuocChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoiDungDuocChon;
        private System.Windows.Forms.DateTimePicker dtNgayThiBD;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.LinkLabel linkGoBackBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDeThiChon;
        private System.Windows.Forms.Label lbKhoiLop;
        private System.Windows.Forms.Label lbMonHoc;
        private System.Windows.Forms.Button btnMoveLeftBoDe;
        private System.Windows.Forms.Button btnMoveRightBoDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeThi;
    }
}