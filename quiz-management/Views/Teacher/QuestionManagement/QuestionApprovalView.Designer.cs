namespace quiz_management.Views.Teacher.QuestionManagement
{
    partial class QuestionApprovalView
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
            this.dgvCQuestionList = new System.Windows.Forms.DataGridView();
            this.maDongGop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkGobackMain = new System.Windows.Forms.LinkLabel();
            this.btnApproval = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCQuestionList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCQuestionList
            // 
            this.dgvCQuestionList.AllowUserToAddRows = false;
            this.dgvCQuestionList.AllowUserToDeleteRows = false;
            this.dgvCQuestionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCQuestionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCQuestionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDongGop,
            this.TenNguoiDung,
            this.TenMonHoc,
            this.trangThai,
            this.ngay,
            this.cauHoi,
            this.KhoiLop});
            this.dgvCQuestionList.Location = new System.Drawing.Point(31, 169);
            this.dgvCQuestionList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCQuestionList.Name = "dgvCQuestionList";
            this.dgvCQuestionList.ReadOnly = true;
            this.dgvCQuestionList.RowHeadersWidth = 51;
            this.dgvCQuestionList.RowTemplate.Height = 24;
            this.dgvCQuestionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCQuestionList.Size = new System.Drawing.Size(985, 390);
            this.dgvCQuestionList.TabIndex = 70;
            // 
            // maDongGop
            // 
            this.maDongGop.DataPropertyName = "maDongGop";
            this.maDongGop.HeaderText = "Mã đóng góp";
            this.maDongGop.MinimumWidth = 6;
            this.maDongGop.Name = "maDongGop";
            this.maDongGop.ReadOnly = true;
            // 
            // TenNguoiDung
            // 
            this.TenNguoiDung.DataPropertyName = "TenNguoiDung";
            this.TenNguoiDung.HeaderText = "Tên người dùng";
            this.TenNguoiDung.MinimumWidth = 6;
            this.TenNguoiDung.Name = "TenNguoiDung";
            this.TenNguoiDung.ReadOnly = true;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.HeaderText = "Tên môn học";
            this.TenMonHoc.MinimumWidth = 6;
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.ReadOnly = true;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngày";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            // 
            // cauHoi
            // 
            this.cauHoi.DataPropertyName = "cauHoi";
            this.cauHoi.HeaderText = "Câu hỏi";
            this.cauHoi.MinimumWidth = 6;
            this.cauHoi.Name = "cauHoi";
            this.cauHoi.ReadOnly = true;
            // 
            // KhoiLop
            // 
            this.KhoiLop.DataPropertyName = "KhoiLop";
            this.KhoiLop.HeaderText = "Khối lớp";
            this.KhoiLop.MinimumWidth = 6;
            this.KhoiLop.Name = "KhoiLop";
            this.KhoiLop.ReadOnly = true;
            // 
            // linkGobackMain
            // 
            this.linkGobackMain.AutoSize = true;
            this.linkGobackMain.Location = new System.Drawing.Point(28, 28);
            this.linkGobackMain.Name = "linkGobackMain";
            this.linkGobackMain.Size = new System.Drawing.Size(49, 17);
            this.linkGobackMain.TabIndex = 67;
            this.linkGobackMain.TabStop = true;
            this.linkGobackMain.Text = "Trở về";
            // 
            // btnApproval
            // 
            this.btnApproval.Location = new System.Drawing.Point(455, 593);
            this.btnApproval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Size = new System.Drawing.Size(170, 55);
            this.btnApproval.TabIndex = 66;
            this.btnApproval.Text = "Phê duyệt";
            this.btnApproval.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 38);
            this.label2.TabIndex = 65;
            this.label2.Text = "Duyệt Câu Hỏi Đã Đóng Góp";
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacher.Location = new System.Drawing.Point(112, 657);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(96, 17);
            this.lbTeacher.TabIndex = 72;
            this.lbTeacher.Text = "Mai Anh Tuấn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 657);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 71;
            this.label14.Text = "Giáo viên: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "(*) Có thể chọn nhiều câu hỏi để phê duyệt";
            // 
            // QuestionApprovalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvCQuestionList);
            this.Controls.Add(this.linkGobackMain);
            this.Controls.Add(this.btnApproval);
            this.Controls.Add(this.label2);
            this.Name = "QuestionApprovalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionApprovalView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCQuestionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCQuestionList;
        private System.Windows.Forms.LinkLabel linkGobackMain;
        private System.Windows.Forms.Button btnApproval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDongGop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiLop;
    }
}