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
            this.maNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCQuestionList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(719, 30);
            this.lbStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(32, 17);
            this.lbStudentID.TabIndex = 63;
            this.lbStudentID.Text = "362";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(658, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 17);
            this.label14.TabIndex = 62;
            this.label14.Text = "Mã số:";
            // 
            // linkGobackMain
            // 
            this.linkGobackMain.AutoSize = true;
            this.linkGobackMain.Location = new System.Drawing.Point(23, 30);
            this.linkGobackMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkGobackMain.Name = "linkGobackMain";
            this.linkGobackMain.Size = new System.Drawing.Size(38, 13);
            this.linkGobackMain.TabIndex = 47;
            this.linkGobackMain.TabStop = true;
            this.linkGobackMain.Text = "Trở về";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(361, 463);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 33);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Danh Sách Câu Hỏi Đã Đóng Góp";
            // 
            // dtgCQuestionList
            // 
            this.dtgCQuestionList.AllowUserToAddRows = false;
            this.dtgCQuestionList.AllowUserToDeleteRows = false;
            this.dtgCQuestionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgCQuestionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCQuestionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDongGop,
            this.maNguoiDung,
            this.maMonHoc,
            this.trangThai,
            this.ngay,
            this.cauHoi,
            this.maKhoiLop});
            this.dtgCQuestionList.Location = new System.Drawing.Point(47, 118);
            this.dtgCQuestionList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgCQuestionList.Name = "dtgCQuestionList";
            this.dtgCQuestionList.ReadOnly = true;
            this.dtgCQuestionList.RowHeadersWidth = 51;
            this.dtgCQuestionList.RowTemplate.Height = 24;
            this.dtgCQuestionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCQuestionList.Size = new System.Drawing.Size(699, 317);
            this.dtgCQuestionList.TabIndex = 64;
            // 
            // maDongGop
            // 
            this.maDongGop.DataPropertyName = "maDongGop";
            this.maDongGop.HeaderText = "MaDongGop";
            this.maDongGop.MinimumWidth = 6;
            this.maDongGop.Name = "maDongGop";
            this.maDongGop.ReadOnly = true;
            this.maDongGop.Width = 93;
            // 
            // maNguoiDung
            // 
            this.maNguoiDung.DataPropertyName = "maNguoiDung";
            this.maNguoiDung.HeaderText = "MaNguoiDung";
            this.maNguoiDung.MinimumWidth = 6;
            this.maNguoiDung.Name = "maNguoiDung";
            this.maNguoiDung.ReadOnly = true;
            this.maNguoiDung.Width = 101;
            // 
            // maMonHoc
            // 
            this.maMonHoc.DataPropertyName = "maMonHoc";
            this.maMonHoc.HeaderText = "MaMonHoc";
            this.maMonHoc.MinimumWidth = 6;
            this.maMonHoc.Name = "maMonHoc";
            this.maMonHoc.ReadOnly = true;
            this.maMonHoc.Width = 88;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "TrangThai";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 81;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngay";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            this.ngay.Width = 57;
            // 
            // cauHoi
            // 
            this.cauHoi.DataPropertyName = "cauHoi";
            this.cauHoi.HeaderText = "CauHoi";
            this.cauHoi.MinimumWidth = 6;
            this.cauHoi.Name = "cauHoi";
            this.cauHoi.ReadOnly = true;
            this.cauHoi.Width = 67;
            // 
            // maKhoiLop
            // 
            this.maKhoiLop.DataPropertyName = "maKhoiLop";
            this.maKhoiLop.HeaderText = "MaKhoiLop";
            this.maKhoiLop.MinimumWidth = 6;
            this.maKhoiLop.Name = "maKhoiLop";
            this.maKhoiLop.ReadOnly = true;
            this.maKhoiLop.Width = 86;
            // 
            // CQuestionListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 522);
            this.Controls.Add(this.dtgCQuestionList);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.linkGobackMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CQuestionListView";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoiLop;
    }
}