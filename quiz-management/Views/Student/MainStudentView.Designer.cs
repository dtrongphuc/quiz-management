namespace quiz_management.Views
{
    partial class MainView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStudentDOB = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.btnPrintTranScript = new System.Windows.Forms.Button();
            this.btnUpdateInfoStudent = new System.Windows.Forms.Button();
            this.btnTestScheduleView = new System.Windows.Forms.Button();
            this.btnExamResultView = new System.Windows.Forms.Button();
            this.lbDOB = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFeekback = new System.Windows.Forms.Button();
            this.btnOfficialExam = new System.Windows.Forms.Button();
            this.btnPracticExam = new System.Windows.Forms.Button();
            this.lbTestDOB = new System.Windows.Forms.Label();
            this.txtTitle2 = new System.Windows.Forms.Label();
            this.txtTitle1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 605);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStudentDOB);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.lbStudentID);
            this.groupBox1.Controls.Add(this.btnPrintTranScript);
            this.groupBox1.Controls.Add(this.btnUpdateInfoStudent);
            this.groupBox1.Controls.Add(this.btnTestScheduleView);
            this.groupBox1.Controls.Add(this.btnExamResultView);
            this.groupBox1.Controls.Add(this.lbDOB);
            this.groupBox1.Controls.Add(this.b);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 605);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // txtStudentDOB
            // 
            this.txtStudentDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentDOB.Location = new System.Drawing.Point(152, 162);
            this.txtStudentDOB.Name = "txtStudentDOB";
            this.txtStudentDOB.Size = new System.Drawing.Size(203, 27);
            this.txtStudentDOB.TabIndex = 9;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(152, 109);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(203, 27);
            this.txtStudentName.TabIndex = 8;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(152, 53);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(203, 27);
            this.txtStudentID.TabIndex = 7;
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(12, 60);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(60, 20);
            this.lbStudentID.TabIndex = 6;
            this.lbStudentID.Text = "Mã số:";
            // 
            // btnPrintTranScript
            // 
            this.btnPrintTranScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTranScript.Location = new System.Drawing.Point(95, 494);
            this.btnPrintTranScript.Name = "btnPrintTranScript";
            this.btnPrintTranScript.Size = new System.Drawing.Size(185, 64);
            this.btnPrintTranScript.TabIndex = 5;
            this.btnPrintTranScript.Text = "In bảng điểm";
            this.btnPrintTranScript.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInfoStudent
            // 
            this.btnUpdateInfoStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfoStudent.Location = new System.Drawing.Point(95, 418);
            this.btnUpdateInfoStudent.Name = "btnUpdateInfoStudent";
            this.btnUpdateInfoStudent.Size = new System.Drawing.Size(185, 60);
            this.btnUpdateInfoStudent.TabIndex = 4;
            this.btnUpdateInfoStudent.Text = "Sửa thông tin cá nhân";
            this.btnUpdateInfoStudent.UseVisualStyleBackColor = true;
            // 
            // btnTestScheduleView
            // 
            this.btnTestScheduleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestScheduleView.Location = new System.Drawing.Point(95, 345);
            this.btnTestScheduleView.Name = "btnTestScheduleView";
            this.btnTestScheduleView.Size = new System.Drawing.Size(185, 58);
            this.btnTestScheduleView.TabIndex = 3;
            this.btnTestScheduleView.Text = "Xem lịch thi";
            this.btnTestScheduleView.UseVisualStyleBackColor = true;
            // 
            // btnExamResultView
            // 
            this.btnExamResultView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamResultView.Location = new System.Drawing.Point(95, 269);
            this.btnExamResultView.Name = "btnExamResultView";
            this.btnExamResultView.Size = new System.Drawing.Size(185, 60);
            this.btnExamResultView.TabIndex = 2;
            this.btnExamResultView.Text = "Xem kết quả thi";
            this.btnExamResultView.UseVisualStyleBackColor = true;
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOB.Location = new System.Drawing.Point(12, 169);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(88, 20);
            this.lbDOB.TabIndex = 1;
            this.lbDOB.Text = "Ngày sinh:";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(12, 116);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(64, 20);
            this.b.TabIndex = 0;
            this.b.Text = "Họ tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFeekback);
            this.groupBox2.Controls.Add(this.btnOfficialExam);
            this.groupBox2.Controls.Add(this.btnPracticExam);
            this.groupBox2.Controls.Add(this.lbTestDOB);
            this.groupBox2.Controls.Add(this.txtTitle2);
            this.groupBox2.Controls.Add(this.txtTitle1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 605);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nội dung";
            // 
            // btnFeekback
            // 
            this.btnFeekback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeekback.Location = new System.Drawing.Point(378, 437);
            this.btnFeekback.Name = "btnFeekback";
            this.btnFeekback.Size = new System.Drawing.Size(185, 60);
            this.btnFeekback.TabIndex = 12;
            this.btnFeekback.Text = "Câu Hỏi Góp Ý";
            this.btnFeekback.UseVisualStyleBackColor = true;
            // 
            // btnOfficialExam
            // 
            this.btnOfficialExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfficialExam.Location = new System.Drawing.Point(261, 345);
            this.btnOfficialExam.Name = "btnOfficialExam";
            this.btnOfficialExam.Size = new System.Drawing.Size(185, 60);
            this.btnOfficialExam.TabIndex = 11;
            this.btnOfficialExam.Text = "Thi Chính Thức";
            this.btnOfficialExam.UseVisualStyleBackColor = true;
            // 
            // btnPracticExam
            // 
            this.btnPracticExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPracticExam.Location = new System.Drawing.Point(149, 437);
            this.btnPracticExam.Name = "btnPracticExam";
            this.btnPracticExam.Size = new System.Drawing.Size(185, 60);
            this.btnPracticExam.TabIndex = 10;
            this.btnPracticExam.Text = "Thi Thử";
            this.btnPracticExam.UseVisualStyleBackColor = true;
            // 
            // lbTestDOB
            // 
            this.lbTestDOB.AutoSize = true;
            this.lbTestDOB.Location = new System.Drawing.Point(591, 567);
            this.lbTestDOB.Name = "lbTestDOB";
            this.lbTestDOB.Size = new System.Drawing.Size(80, 17);
            this.lbTestDOB.TabIndex = 2;
            this.lbTestDOB.Text = "01/12/2020";
            // 
            // txtTitle2
            // 
            this.txtTitle2.AutoSize = true;
            this.txtTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle2.Location = new System.Drawing.Point(125, 159);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(464, 32);
            this.txtTitle2.TabIndex = 1;
            this.txtTitle2.Text = "Trường đại học Khoa Học Tự Nhiện ";
            // 
            // txtTitle1
            // 
            this.txtTitle1.AutoSize = true;
            this.txtTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle1.Location = new System.Drawing.Point(288, 109);
            this.txtTitle1.Name = "txtTitle1";
            this.txtTitle1.Size = new System.Drawing.Size(140, 20);
            this.txtTitle1.TabIndex = 0;
            this.txtTitle1.Text = "Thi trắc nghiệm";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 605);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrintTranScript;
        private System.Windows.Forms.Button btnUpdateInfoStudent;
        private System.Windows.Forms.Button btnTestScheduleView;
        private System.Windows.Forms.Button btnExamResultView;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.TextBox txtStudentDOB;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnPracticExam;
        private System.Windows.Forms.Label lbTestDOB;
        private System.Windows.Forms.Label txtTitle2;
        private System.Windows.Forms.Label txtTitle1;
        private System.Windows.Forms.Button btnFeekback;
        private System.Windows.Forms.Button btnOfficialExam;
    }
}