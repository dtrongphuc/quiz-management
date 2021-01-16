namespace quiz_management.Views.Teacher.MockExamManagement
{
    partial class CreateMockExamView
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.linkGoBackBefore = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbKhoiLop = new System.Windows.Forms.ComboBox();
            this.dtgHocSinh = new System.Windows.Forms.DataGridView();
            this.HocSinhDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.dgvThiSinh = new System.Windows.Forms.DataGridView();
            this.ThiSinhDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoiDungDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgayThiBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNgayThiKT = new System.Windows.Forms.DateTimePicker();
            this.dgvBoDe = new System.Windows.Forms.DataGridView();
            this.maBoDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoDe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(354, 591);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 39);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Tạo kỳ thi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // linkGoBackBefore
            // 
            this.linkGoBackBefore.AutoSize = true;
            this.linkGoBackBefore.Location = new System.Drawing.Point(36, 25);
            this.linkGoBackBefore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkGoBackBefore.Name = "linkGoBackBefore";
            this.linkGoBackBefore.Size = new System.Drawing.Size(38, 13);
            this.linkGoBackBefore.TabIndex = 29;
            this.linkGoBackBefore.TabStop = true;
            this.linkGoBackBefore.Text = "Trở về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tạo Kì Thi Thử";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Bộ Đề";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Khối Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Môn Học";
            // 
            // cbbKhoiLop
            // 
            this.cbbKhoiLop.DisplayMember = "tenKhoiLop";
            this.cbbKhoiLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoiLop.FormattingEnabled = true;
            this.cbbKhoiLop.Location = new System.Drawing.Point(355, 128);
            this.cbbKhoiLop.Name = "cbbKhoiLop";
            this.cbbKhoiLop.Size = new System.Drawing.Size(150, 21);
            this.cbbKhoiLop.TabIndex = 53;
            this.cbbKhoiLop.ValueMember = "maKhoiLop";
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
            this.dtgHocSinh.Location = new System.Drawing.Point(40, 272);
            this.dtgHocSinh.Name = "dtgHocSinh";
            this.dtgHocSinh.ReadOnly = true;
            this.dtgHocSinh.RowHeadersVisible = false;
            this.dtgHocSinh.RowHeadersWidth = 51;
            this.dtgHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHocSinh.Size = new System.Drawing.Size(326, 282);
            this.dtgHocSinh.TabIndex = 50;
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
            // cbMonHoc
            // 
            this.cbMonHoc.DisplayMember = "tenMonHoc";
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(355, 172);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(150, 21);
            this.cbMonHoc.TabIndex = 49;
            this.cbMonHoc.ValueMember = "maMonHoc";
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(397, 434);
            this.btnMoveLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(34, 55);
            this.btnMoveLeft.TabIndex = 48;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(397, 362);
            this.btnMoveRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(34, 55);
            this.btnMoveRight.TabIndex = 47;
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
            this.dgvThiSinh.Location = new System.Drawing.Point(464, 272);
            this.dgvThiSinh.Name = "dgvThiSinh";
            this.dgvThiSinh.ReadOnly = true;
            this.dgvThiSinh.RowHeadersVisible = false;
            this.dgvThiSinh.RowHeadersWidth = 51;
            this.dgvThiSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThiSinh.Size = new System.Drawing.Size(326, 282);
            this.dgvThiSinh.TabIndex = 46;
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
            this.dtNgayThiBD.Location = new System.Drawing.Point(129, 129);
            this.dtNgayThiBD.Name = "dtNgayThiBD";
            this.dtNgayThiBD.Size = new System.Drawing.Size(200, 20);
            this.dtNgayThiBD.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Ngày kết thúc";
            // 
            // dtNgayThiKT
            // 
            this.dtNgayThiKT.Location = new System.Drawing.Point(129, 166);
            this.dtNgayThiKT.Name = "dtNgayThiKT";
            this.dtNgayThiKT.Size = new System.Drawing.Size(200, 20);
            this.dtNgayThiKT.TabIndex = 59;
            // 
            // dgvBoDe
            // 
            this.dgvBoDe.AllowUserToAddRows = false;
            this.dgvBoDe.AllowUserToDeleteRows = false;
            this.dgvBoDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoDe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBoDe});
            this.dgvBoDe.Location = new System.Drawing.Point(544, 110);
            this.dgvBoDe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBoDe.Name = "dgvBoDe";
            this.dgvBoDe.RowHeadersWidth = 51;
            this.dgvBoDe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoDe.Size = new System.Drawing.Size(215, 122);
            this.dgvBoDe.TabIndex = 60;
            // 
            // maBoDe
            // 
            this.maBoDe.DataPropertyName = "maBoDe";
            this.maBoDe.HeaderText = "Mã Bộ Đề";
            this.maBoDe.MinimumWidth = 6;
            this.maBoDe.Name = "maBoDe";
            // 
            // CreateMockExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 645);
            this.Controls.Add(this.dgvBoDe);
            this.Controls.Add(this.dtNgayThiKT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbKhoiLop);
            this.Controls.Add(this.dtgHocSinh);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.dgvThiSinh);
            this.Controls.Add(this.dtNgayThiBD);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.linkGoBackBefore);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateMockExamView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateMockExamView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.LinkLabel linkGoBackBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbKhoiLop;
        private System.Windows.Forms.DataGridView dtgHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocSinhDuocChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoidung;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.DataGridView dgvThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThiSinhDuocChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoiDungDuocChon;
        private System.Windows.Forms.DateTimePicker dtNgayThiBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtNgayThiKT;
        private System.Windows.Forms.DataGridView dgvBoDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBoDe;
    }
}