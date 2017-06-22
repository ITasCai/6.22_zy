namespace 第二题
{
    partial class Form1
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
            this.comyue = new System.Windows.Forms.ComboBox();
            this.comri = new System.Windows.Forms.ComboBox();
            this.lalyue = new System.Windows.Forms.Label();
            this.lblri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comyue
            // 
            this.comyue.FormattingEnabled = true;
            this.comyue.Location = new System.Drawing.Point(123, 40);
            this.comyue.Name = "comyue";
            this.comyue.Size = new System.Drawing.Size(121, 20);
            this.comyue.TabIndex = 0;
            this.comyue.SelectedIndexChanged += new System.EventHandler(this.comyue_SelectedIndexChanged);
            // 
            // comri
            // 
            this.comri.FormattingEnabled = true;
            this.comri.Location = new System.Drawing.Point(123, 94);
            this.comri.Name = "comri";
            this.comri.Size = new System.Drawing.Size(121, 20);
            this.comri.TabIndex = 1;
            this.comri.SelectedIndexChanged += new System.EventHandler(this.comri_SelectedIndexChanged);
            // 
            // lalyue
            // 
            this.lalyue.AutoSize = true;
            this.lalyue.Location = new System.Drawing.Point(47, 47);
            this.lalyue.Name = "lalyue";
            this.lalyue.Size = new System.Drawing.Size(17, 12);
            this.lalyue.TabIndex = 2;
            this.lalyue.Text = "月";
            // 
            // lblri
            // 
            this.lblri.AutoSize = true;
            this.lblri.Location = new System.Drawing.Point(49, 101);
            this.lblri.Name = "lblri";
            this.lblri.Size = new System.Drawing.Size(17, 12);
            this.lblri.TabIndex = 3;
            this.lblri.Text = "日";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.lblri);
            this.Controls.Add(this.lalyue);
            this.Controls.Add(this.comri);
            this.Controls.Add(this.comyue);
            this.Name = "Form1";
            this.Text = "日期变化";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comyue;
        private System.Windows.Forms.ComboBox comri;
        private System.Windows.Forms.Label lalyue;
        private System.Windows.Forms.Label lblri;
    }
}

