namespace TabControlTest
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPerson);
            this.tabMain.Controls.Add(this.tabAll);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(380, 311);
            this.tabMain.TabIndex = 0;
            // 
            // tabPerson
            // 
            this.tabPerson.Location = new System.Drawing.Point(4, 22);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerson.Size = new System.Drawing.Size(372, 285);
            this.tabPerson.TabIndex = 0;
            this.tabPerson.Tag = "PersonalSocre";
            this.tabPerson.Text = "个人成绩查询";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // tabAll
            // 
            this.tabAll.Location = new System.Drawing.Point(4, 22);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(372, 285);
            this.tabAll.TabIndex = 1;
            this.tabAll.Tag = "ClassScore";
            this.tabAll.Text = "全班\\院\\校GPA查询";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 311);
            this.Controls.Add(this.tabMain);
            this.Name = "MainForm";
            this.Tag = "PersonalScore";
            this.Text = "TabControlTest";
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPerson;
        private System.Windows.Forms.TabPage tabAll;
    }
}

