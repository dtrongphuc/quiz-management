
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
            this.btnExam = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.dgvThiSinh = new System.Windows.Forms.DataGridView();
            this.ThiSinhDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoiDungDuocChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkGoForBack = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNgayThiChon = new System.Windows.Forms.TextBox();
            this.tbMonHocChon = new System.Windows.Forms.TextBox();
            this.tbKhoiLopChon = new System.Windows.Forms.TextBox();
            this.tbBoDeChon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(341, 501);
            this.btnExam.Margin = new System.Windows.Forms.Padding(2);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(124, 39);
            this.btnExam.TabIndex = 32;
            this.btnExam.Text = "Cập Nhật Kỳ Thi";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Môn Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Khối Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Bộ Đề";
            // 
            // tbNgayThiChon
            // 
            this.tbNgayThiChon.Enabled = false;
            this.tbNgayThiChon.Location = new System.Drawing.Point(29, 114);
            this.tbNgayThiChon.Name = "tbNgayThiChon";
            this.tbNgayThiChon.Size = new System.Drawing.Size(158, 20);
            this.tbNgayThiChon.TabIndex = 41;
            // 
            // tbMonHocChon
            // 
            this.tbMonHocChon.Enabled = false;
            this.tbMonHocChon.Location = new System.Drawing.Point(231, 114);
            this.tbMonHocChon.Name = "tbMonHocChon";
            this.tbMonHocChon.Size = new System.Drawing.Size(149, 20);
            this.tbMonHocChon.TabIndex = 44;
            // 
            // tbKhoiLopChon
            // 
            this.tbKhoiLopChon.Enabled = false;
            this.tbKhoiLopChon.Location = new System.Drawing.Point(423, 114);
            this.tbKhoiLopChon.Name = "tbKhoiLopChon";
            this.tbKhoiLopChon.Size = new System.Drawing.Size(149, 20);
            this.tbKhoiLopChon.TabIndex = 45;
            // 
            // tbBoDeChon
            // 
            this.tbBoDeChon.Enabled = false;
            this.tbBoDeChon.Location = new System.Drawing.Point(606, 114);
            this.tbBoDeChon.Name = "tbBoDeChon";
            this.tbBoDeChon.Size = new System.Drawing.Size(149, 20);
            this.tbBoDeChon.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Ngày Thi";
            // 
            // UpdateExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbBoDeChon);
            this.Controls.Add(this.tbKhoiLopChon);
            this.Controls.Add(this.tbMonHocChon);
            this.Controls.Add(this.tbNgayThiChon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgHocSinh);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.dgvThiSinh);
            this.Controls.Add(this.linkGoForBack);
            this.Controls.Add(this.label3);
            this.Name = "UpdateExamView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.DataGridView dgvThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThiSinhDuocChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoiDungDuocChon;
        private System.Windows.Forms.LinkLabel linkGoForBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNgayThiChon;
        private System.Windows.Forms.TextBox tbMonHocChon;
        private System.Windows.Forms.TextBox tbKhoiLopChon;
        private System.Windows.Forms.TextBox tbBoDeChon;
        private System.Windows.Forms.Label label7;
    }
}