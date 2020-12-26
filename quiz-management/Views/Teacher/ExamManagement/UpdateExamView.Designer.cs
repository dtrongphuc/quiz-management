
namespace quiz_management.Views.Teacher.ExamManagement
{
    partial class UpdateExamView
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
            this.label5 = new System.Windows.Forms.Label();
            this.dtgHocSinh = new System.Windows.Forms.DataGridView();
            this.HocSinhDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.dgvThiSinh = new System.Windows.Forms.DataGridView();
            this.ThiSinhDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoiDungDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.cbBoDe = new System.Windows.Forms.ComboBox();
            this.linkGoForBack = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbKhoiLop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Danh sách Thí Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Danh sách Học Sinh";
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
            this.dtgHocSinh.Location = new System.Drawing.Point(29, 193);
            this.dtgHocSinh.Name = "dtgHocSinh";
            this.dtgHocSinh.ReadOnly = true;
            this.dtgHocSinh.RowHeadersVisible = false;
            this.dtgHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHocSinh.Size = new System.Drawing.Size(326, 282);
            this.dtgHocSinh.TabIndex = 34;
            // 
            // HocSinhDuocChon
            // 
            this.HocSinhDuocChon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HocSinhDuocChon.DataPropertyName = "maNguoidung";
            this.HocSinhDuocChon.FillWeight = 30.52284F;
            this.HocSinhDuocChon.HeaderText = "MSV";
            this.HocSinhDuocChon.Name = "HocSinhDuocChon";
            this.HocSinhDuocChon.ReadOnly = true;
            // 
            // tenNguoidung
            // 
            this.tenNguoidung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNguoidung.DataPropertyName = "tenNguoidung";
            this.tenNguoidung.FillWeight = 98.47716F;
            this.tenNguoidung.HeaderText = "Tên Hoc Sinh";
            this.tenNguoidung.Name = "tenNguoidung";
            this.tenNguoidung.ReadOnly = true;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.DisplayMember = "tenMonHoc";
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(249, 98);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(150, 21);
            this.cbMonHoc.TabIndex = 33;
            this.cbMonHoc.ValueMember = "maMonHoc";
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(341, 501);
            this.btnExam.Margin = new System.Windows.Forms.Padding(2);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(124, 39);
            this.btnExam.TabIndex = 32;
            this.btnExam.Text = "Tạo Kỳ Thi";
            this.btnExam.UseVisualStyleBackColor = true;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(386, 336);
            this.btnMoveLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(34, 55);
            this.btnMoveLeft.TabIndex = 31;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(386, 264);
            this.btnMoveRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(34, 55);
            this.btnMoveRight.TabIndex = 30;
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
            this.dgvThiSinh.Location = new System.Drawing.Point(453, 193);
            this.dgvThiSinh.Name = "dgvThiSinh";
            this.dgvThiSinh.ReadOnly = true;
            this.dgvThiSinh.RowHeadersVisible = false;
            this.dgvThiSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThiSinh.Size = new System.Drawing.Size(326, 282);
            this.dgvThiSinh.TabIndex = 29;
            // 
            // ThiSinhDuocChon
            // 
            this.ThiSinhDuocChon.DataPropertyName = "maNguoiDung";
            this.ThiSinhDuocChon.FillWeight = 30.52284F;
            this.ThiSinhDuocChon.HeaderText = "MSV";
            this.ThiSinhDuocChon.Name = "ThiSinhDuocChon";
            this.ThiSinhDuocChon.ReadOnly = true;
            // 
            // tenNguoiDungDuocChon
            // 
            this.tenNguoiDungDuocChon.DataPropertyName = "tenNguoiDung";
            this.tenNguoiDungDuocChon.FillWeight = 98.47716F;
            this.tenNguoiDungDuocChon.HeaderText = "Tên Hoc Sinh";
            this.tenNguoiDungDuocChon.Name = "tenNguoiDungDuocChon";
            this.tenNguoiDungDuocChon.ReadOnly = true;
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.Location = new System.Drawing.Point(29, 98);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayThi.TabIndex = 28;
            // 
            // cbBoDe
            // 
            this.cbBoDe.DisplayMember = "maBoDe";
            this.cbBoDe.FormattingEnabled = true;
            this.cbBoDe.Location = new System.Drawing.Point(602, 101);
            this.cbBoDe.Name = "cbBoDe";
            this.cbBoDe.Size = new System.Drawing.Size(164, 21);
            this.cbBoDe.TabIndex = 27;
            this.cbBoDe.ValueMember = "maBoDe";
            // 
            // linkGoForBack
            // 
            this.linkGoForBack.AutoSize = true;
            this.linkGoForBack.Location = new System.Drawing.Point(33, 15);
            this.linkGoForBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkGoForBack.Name = "linkGoForBack";
            this.linkGoForBack.Size = new System.Drawing.Size(38, 13);
            this.linkGoForBack.TabIndex = 26;
            this.linkGoForBack.TabStop = true;
            this.linkGoForBack.Text = "Trở về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chỉnh Sửa Kỳ Thi ";
            // 
            // cbbKhoiLop
            // 
            this.cbbKhoiLop.DisplayMember = "tenKhoiLop";
            this.cbbKhoiLop.FormattingEnabled = true;
            this.cbbKhoiLop.Location = new System.Drawing.Point(423, 98);
            this.cbbKhoiLop.Name = "cbbKhoiLop";
            this.cbbKhoiLop.Size = new System.Drawing.Size(150, 21);
            this.cbbKhoiLop.TabIndex = 37;
            this.cbbKhoiLop.ValueMember = "maKhoiLop";
            // 
            // UpdateExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 554);
            this.Controls.Add(this.cbbKhoiLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgHocSinh);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.dgvThiSinh);
            this.Controls.Add(this.dtpNgayThi);
            this.Controls.Add(this.cbBoDe);
            this.Controls.Add(this.linkGoForBack);
            this.Controls.Add(this.label3);
            this.Name = "UpdateExamView";
            this.Text = "UpdateExamView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocSinhDuocChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoidung;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.DataGridView dgvThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThiSinhDuocChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoiDungDuocChon;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.ComboBox cbBoDe;
        private System.Windows.Forms.LinkLabel linkGoForBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbKhoiLop;
    }
}