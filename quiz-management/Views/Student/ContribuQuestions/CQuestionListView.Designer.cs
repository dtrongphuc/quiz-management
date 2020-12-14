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
            ((System.ComponentModel.ISupportInitialize)(this.dtgCQuestionList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(739, 23);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(36, 20);
            this.lbStudentID.TabIndex = 63;
            this.lbStudentID.Text = "362";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(657, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 62;
            this.label14.Text = "Mã số:";
            // 
            // linkGobackMain
            // 
            this.linkGobackMain.AutoSize = true;
            this.linkGobackMain.Location = new System.Drawing.Point(31, 40);
            this.linkGobackMain.Name = "linkGobackMain";
            this.linkGobackMain.Size = new System.Drawing.Size(49, 17);
            this.linkGobackMain.TabIndex = 47;
            this.linkGobackMain.TabStop = true;
            this.linkGobackMain.Text = "Trở về";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(340, 580);
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
            this.label2.Location = new System.Drawing.Point(164, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 38);
            this.label2.TabIndex = 34;
            this.label2.Text = "Danh Sách Câu Hỏi Đã Đóng Góp";
            // 
            // dtgCQuestionList
            // 
            this.dtgCQuestionList.AllowUserToAddRows = false;
            this.dtgCQuestionList.AllowUserToDeleteRows = false;
            this.dtgCQuestionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCQuestionList.Location = new System.Drawing.Point(56, 149);
            this.dtgCQuestionList.Name = "dtgCQuestionList";
            this.dtgCQuestionList.ReadOnly = true;
            this.dtgCQuestionList.RowHeadersWidth = 51;
            this.dtgCQuestionList.RowTemplate.Height = 24;
            this.dtgCQuestionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCQuestionList.Size = new System.Drawing.Size(705, 390);
            this.dtgCQuestionList.TabIndex = 64;
            // 
            // CQuestionListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.dtgCQuestionList);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.linkGobackMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
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
    }
}