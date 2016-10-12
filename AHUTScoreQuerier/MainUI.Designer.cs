namespace RF.ScoreQuerier
{
    partial class ScoreQuerierMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreQuerierMainForm));
            this.lblName = new System.Windows.Forms.Label();
            this.lblSchoolNumber = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSchoolNumber = new System.Windows.Forms.TextBox();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.btnQueryScore = new System.Windows.Forms.Button();
            this.lvwSubjects = new System.Windows.Forms.ListView();
            this.colNumberOfSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameOfSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCredit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAttribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumberOfTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameOfTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFinalScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsualScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picSchoolLogo = new System.Windows.Forms.PictureBox();
            this.cboSchoolYear = new System.Windows.Forms.ComboBox();
            this.cboSchoolTerm = new System.Windows.Forms.ComboBox();
            this.lblSchoolTerm = new System.Windows.Forms.Label();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.prcGetScore = new System.Windows.Forms.ProgressBar();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.lblCountOfSubjects = new System.Windows.Forms.Label();
            this.btnQueryRange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名:";
            // 
            // lblSchoolNumber
            // 
            this.lblSchoolNumber.AutoSize = true;
            this.lblSchoolNumber.Location = new System.Drawing.Point(10, 41);
            this.lblSchoolNumber.Name = "lblSchoolNumber";
            this.lblSchoolNumber.Size = new System.Drawing.Size(35, 12);
            this.lblSchoolNumber.TabIndex = 1;
            this.lblSchoolNumber.Text = "学号:";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(10, 67);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(59, 12);
            this.lblIDNumber.TabIndex = 2;
            this.lblIDNumber.Text = "身份证号:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(80, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtSchoolNumber
            // 
            this.txtSchoolNumber.Location = new System.Drawing.Point(75, 39);
            this.txtSchoolNumber.MaxLength = 9;
            this.txtSchoolNumber.Name = "txtSchoolNumber";
            this.txtSchoolNumber.Size = new System.Drawing.Size(80, 21);
            this.txtSchoolNumber.TabIndex = 4;
            this.txtSchoolNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSchoolNumber_KeyPress);
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(75, 64);
            this.txtIDNumber.MaxLength = 18;
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(137, 21);
            this.txtIDNumber.TabIndex = 5;
            this.txtIDNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDNumber_KeyPress);
            // 
            // btnQueryScore
            // 
            this.btnQueryScore.Location = new System.Drawing.Point(218, 62);
            this.btnQueryScore.Name = "btnQueryScore";
            this.btnQueryScore.Size = new System.Drawing.Size(89, 23);
            this.btnQueryScore.TabIndex = 6;
            this.btnQueryScore.Text = "查询成绩";
            this.btnQueryScore.UseVisualStyleBackColor = true;
            this.btnQueryScore.Click += new System.EventHandler(this.btnQueryScore_Click);
            // 
            // lvwSubjects
            // 
            this.lvwSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumberOfSubject,
            this.colNameOfSubject,
            this.colCredit,
            this.colAttribute,
            this.colNumberOfTeacher,
            this.colNameOfTeacher,
            this.colFinalScore,
            this.colUsualScore});
            this.lvwSubjects.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwSubjects.FullRowSelect = true;
            this.lvwSubjects.GridLines = true;
            this.lvwSubjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwSubjects.Location = new System.Drawing.Point(12, 94);
            this.lvwSubjects.Name = "lvwSubjects";
            this.lvwSubjects.Size = new System.Drawing.Size(584, 211);
            this.lvwSubjects.TabIndex = 8;
            this.lvwSubjects.UseCompatibleStateImageBehavior = false;
            this.lvwSubjects.View = System.Windows.Forms.View.Details;
            // 
            // colNumberOfSubject
            // 
            this.colNumberOfSubject.Text = "课程号";
            this.colNumberOfSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNumberOfSubject.Width = 75;
            // 
            // colNameOfSubject
            // 
            this.colNameOfSubject.Text = "课程名";
            this.colNameOfSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNameOfSubject.Width = 135;
            // 
            // colCredit
            // 
            this.colCredit.Text = "学分";
            this.colCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCredit.Width = 40;
            // 
            // colAttribute
            // 
            this.colAttribute.Text = "课程属性";
            this.colAttribute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAttribute.Width = 80;
            // 
            // colNumberOfTeacher
            // 
            this.colNumberOfTeacher.Text = "教师号";
            this.colNumberOfTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNumberOfTeacher.Width = 50;
            // 
            // colNameOfTeacher
            // 
            this.colNameOfTeacher.Text = "教师姓名";
            this.colNameOfTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colFinalScore
            // 
            this.colFinalScore.Text = "总评成绩";
            this.colFinalScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colUsualScore
            // 
            this.colUsualScore.Text = "平时成绩";
            this.colUsualScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUsualScore.Width = 62;
            // 
            // picSchoolLogo
            // 
            this.picSchoolLogo.Image = ((System.Drawing.Image)(resources.GetObject("picSchoolLogo.Image")));
            this.picSchoolLogo.Location = new System.Drawing.Point(512, 11);
            this.picSchoolLogo.Name = "picSchoolLogo";
            this.picSchoolLogo.Size = new System.Drawing.Size(81, 74);
            this.picSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSchoolLogo.TabIndex = 9;
            this.picSchoolLogo.TabStop = false;
            // 
            // cboSchoolYear
            // 
            this.cboSchoolYear.FormattingEnabled = true;
            this.cboSchoolYear.Location = new System.Drawing.Point(218, 11);
            this.cboSchoolYear.Name = "cboSchoolYear";
            this.cboSchoolYear.Size = new System.Drawing.Size(89, 20);
            this.cboSchoolYear.TabIndex = 10;
            // 
            // cboSchoolTerm
            // 
            this.cboSchoolTerm.FormattingEnabled = true;
            this.cboSchoolTerm.Items.AddRange(new object[] {
            "==请选择==",
            "1",
            "2"});
            this.cboSchoolTerm.Location = new System.Drawing.Point(218, 37);
            this.cboSchoolTerm.Name = "cboSchoolTerm";
            this.cboSchoolTerm.Size = new System.Drawing.Size(89, 20);
            this.cboSchoolTerm.TabIndex = 11;
            // 
            // lblSchoolTerm
            // 
            this.lblSchoolTerm.AutoSize = true;
            this.lblSchoolTerm.Location = new System.Drawing.Point(177, 41);
            this.lblSchoolTerm.Name = "lblSchoolTerm";
            this.lblSchoolTerm.Size = new System.Drawing.Size(35, 12);
            this.lblSchoolTerm.TabIndex = 12;
            this.lblSchoolTerm.Text = "学期:";
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.AutoSize = true;
            this.lblSchoolYear.Location = new System.Drawing.Point(177, 15);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(35, 12);
            this.lblSchoolYear.TabIndex = 13;
            this.lblSchoolYear.Text = "学年:";
            // 
            // prcGetScore
            // 
            this.prcGetScore.Location = new System.Drawing.Point(313, 12);
            this.prcGetScore.Name = "prcGetScore";
            this.prcGetScore.Size = new System.Drawing.Size(193, 45);
            this.prcGetScore.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(317, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清空成绩";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(416, 62);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(89, 23);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "导出成绩";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(10, 319);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(71, 12);
            this.lblGPA.TabIndex = 18;
            this.lblGPA.Text = "平均学分绩:";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(90, 316);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.ReadOnly = true;
            this.txtGPA.Size = new System.Drawing.Size(65, 21);
            this.txtGPA.TabIndex = 19;
            // 
            // lblCountOfSubjects
            // 
            this.lblCountOfSubjects.AutoSize = true;
            this.lblCountOfSubjects.Location = new System.Drawing.Point(484, 319);
            this.lblCountOfSubjects.Name = "lblCountOfSubjects";
            this.lblCountOfSubjects.Size = new System.Drawing.Size(0, 12);
            this.lblCountOfSubjects.TabIndex = 20;
            // 
            // btnQueryRange
            // 
            this.btnQueryRange.Location = new System.Drawing.Point(218, 314);
            this.btnQueryRange.Name = "btnQueryRange";
            this.btnQueryRange.Size = new System.Drawing.Size(84, 23);
            this.btnQueryRange.TabIndex = 21;
            this.btnQueryRange.Text = "查询多人GPA";
            this.btnQueryRange.UseVisualStyleBackColor = true;
            this.btnQueryRange.Click += new System.EventHandler(this.btnQueryRange_Click);
            // 
            // ScoreQuerierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 344);
            this.Controls.Add(this.btnQueryRange);
            this.Controls.Add(this.lblCountOfSubjects);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.prcGetScore);
            this.Controls.Add(this.lblSchoolYear);
            this.Controls.Add(this.lblSchoolTerm);
            this.Controls.Add(this.cboSchoolTerm);
            this.Controls.Add(this.cboSchoolYear);
            this.Controls.Add(this.picSchoolLogo);
            this.Controls.Add(this.lvwSubjects);
            this.Controls.Add(this.btnQueryScore);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.txtSchoolNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.lblSchoolNumber);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScoreQuerierMainForm";
            this.Text = "AHUT成绩查询器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScoreQuerierMainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSchoolNumber;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSchoolNumber;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Button btnQueryScore;
        private System.Windows.Forms.ListView lvwSubjects;
        private System.Windows.Forms.ColumnHeader colNumberOfSubject;
        private System.Windows.Forms.ColumnHeader colNameOfSubject;
        private System.Windows.Forms.ColumnHeader colCredit;
        private System.Windows.Forms.ColumnHeader colAttribute;
        private System.Windows.Forms.ColumnHeader colNumberOfTeacher;
        private System.Windows.Forms.ColumnHeader colNameOfTeacher;
        private System.Windows.Forms.ColumnHeader colFinalScore;
        private System.Windows.Forms.ColumnHeader colUsualScore;
        private System.Windows.Forms.PictureBox picSchoolLogo;
        private System.Windows.Forms.ComboBox cboSchoolYear;
        private System.Windows.Forms.ComboBox cboSchoolTerm;
        private System.Windows.Forms.Label lblSchoolTerm;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.ProgressBar prcGetScore;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Label lblCountOfSubjects;
        private System.Windows.Forms.Button btnQueryRange;
    }
}

