namespace RF.ScoreQuerier
{
    partial class MultiGPA
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
            this.lblStartNumber = new System.Windows.Forms.Label();
            this.txtStartNumber = new System.Windows.Forms.TextBox();
            this.lblEndNumber = new System.Windows.Forms.Label();
            this.txtEndNumber = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.chkUseCount = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblStartNumber
            // 
            this.lblStartNumber.AutoSize = true;
            this.lblStartNumber.Location = new System.Drawing.Point(13, 13);
            this.lblStartNumber.Name = "lblStartNumber";
            this.lblStartNumber.Size = new System.Drawing.Size(59, 12);
            this.lblStartNumber.TabIndex = 0;
            this.lblStartNumber.Text = "起始学号:";
            // 
            // txtStartNumber
            // 
            this.txtStartNumber.Location = new System.Drawing.Point(78, 10);
            this.txtStartNumber.Name = "txtStartNumber";
            this.txtStartNumber.Size = new System.Drawing.Size(100, 21);
            this.txtStartNumber.TabIndex = 1;
            // 
            // lblEndNumber
            // 
            this.lblEndNumber.AutoSize = true;
            this.lblEndNumber.Location = new System.Drawing.Point(13, 40);
            this.lblEndNumber.Name = "lblEndNumber";
            this.lblEndNumber.Size = new System.Drawing.Size(59, 12);
            this.lblEndNumber.TabIndex = 0;
            this.lblEndNumber.Text = "终止学号:";
            // 
            // txtEndNumber
            // 
            this.txtEndNumber.Location = new System.Drawing.Point(78, 37);
            this.txtEndNumber.Name = "txtEndNumber";
            this.txtEndNumber.Size = new System.Drawing.Size(100, 21);
            this.txtEndNumber.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(15, 113);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(163, 32);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询并导入数据库";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // chkUseCount
            // 
            this.chkUseCount.AutoSize = true;
            this.chkUseCount.Location = new System.Drawing.Point(15, 73);
            this.chkUseCount.Name = "chkUseCount";
            this.chkUseCount.Size = new System.Drawing.Size(120, 16);
            this.chkUseCount.TabIndex = 3;
            this.chkUseCount.Text = "使用人数限定范围";
            this.chkUseCount.UseVisualStyleBackColor = true;
            this.chkUseCount.CheckedChanged += new System.EventHandler(this.chkUseCount_CheckedChanged);
            // 
            // MultiGPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 157);
            this.Controls.Add(this.chkUseCount);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtEndNumber);
            this.Controls.Add(this.lblEndNumber);
            this.Controls.Add(this.txtStartNumber);
            this.Controls.Add(this.lblStartNumber);
            this.Name = "MultiGPA";
            this.Text = "多人GPA查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartNumber;
        private System.Windows.Forms.TextBox txtStartNumber;
        private System.Windows.Forms.Label lblEndNumber;
        private System.Windows.Forms.TextBox txtEndNumber;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.CheckBox chkUseCount;
    }
}