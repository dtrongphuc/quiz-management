namespace quiz_management.Views.Student.ContribuQuestions
{
    partial class CQuestionListView
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
            this.lbStudentID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.linkGobackMain = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgCQuestionList = new System.Windows.Forms.DataGridView();
            this.maDongGop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCQuestionList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(959, 37);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(36, 20);
            this.lbStudentID.TabIndex = 63;
            this.lbStudentID.Text = "362";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(877, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 62;
            this.label14.Text = "Mã số:";
            // 
            // linkGobackMain
            // 
            this.linkGobackMain.AutoSize = true;
            this.linkGobackMain.Location = new System.Drawing.Point(31, 37);
            this.linkGobackMain.Name = "linkGobackMain";
            this.linkGobackMain.Size = new System.Drawing.Size(49, 17);
            this.linkGobackMain.TabIndex = 47;
            this.linkGobackMain.TabStop = true;
            this.linkGobackMain.Text = "Trở về";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(481, 570);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 41);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 38);
            this.label2.TabIndex = 34;
            this.label2.Text = "Danh Sách Câu Hỏi Đã Đóng Góp";
            // 
            // dtgCQuestionList
            // 
            this.dtgCQuestionList.AllowUserToAddRows = false;
            this.dtgCQuestionList.AllowUserToDeleteRows = false;
            this.dtgCQuestionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCQuestionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCQuestionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDongGop,
            this.TenNguoiDung,
            this.TenMonHoc,
            this.trangThai,
            this.ngay,
            this.cauHoi,
            this.KhoiLop});
            this.dtgCQuestionList.Location = new System.Drawing.Point(63, 145);
            this.dtgCQuestionList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCQuestionList.Name = "dtgCQuestionList";
            this.dtgCQuestionList.ReadOnly = true;
            this.dtgCQuestionList.RowHeadersWidth = 51;
            this.dtgCQuestionList.RowTemplate.Height = 24;
            this.dtgCQuestionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCQuestionList.Size = new System.Drawing.Size(932, 390);
            this.dtgCQuestionList.TabIndex = 64;
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
            this.KhoiLop.HeaderText = "Cấp ";
            this.KhoiLop.MinimumWidth = 6;
            this.KhoiLop.Name = "KhoiLop";
            this.KhoiLop.ReadOnly = true;
            // 
            // CQuestionListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 642);
            this.Controls.Add(this.dtgCQuestionList);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.linkGobackMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CQuestionListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CQuestionListView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCQuestionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel linkGobackMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgCQuestionList;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDongGop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiLop;
    }
}