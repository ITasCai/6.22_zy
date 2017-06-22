namespace 第四题
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
            this.grprong = new System.Windows.Forms.GroupBox();
            this.rdoty = new System.Windows.Forms.RadioButton();
            this.rodah = new System.Windows.Forms.RadioButton();
            this.rdoit = new System.Windows.Forms.RadioButton();
            this.btnok = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.grprong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grprong
            // 
            this.grprong.Controls.Add(this.rdoit);
            this.grprong.Controls.Add(this.rodah);
            this.grprong.Controls.Add(this.rdoty);
            this.grprong.Location = new System.Drawing.Point(43, 29);
            this.grprong.Name = "grprong";
            this.grprong.Size = new System.Drawing.Size(253, 115);
            this.grprong.TabIndex = 0;
            this.grprong.TabStop = false;
            this.grprong.Text = "爱好：";
            // 
            // rdoty
            // 
            this.rdoty.AutoSize = true;
            this.rdoty.Location = new System.Drawing.Point(73, 51);
            this.rdoty.Name = "rdoty";
            this.rdoty.Size = new System.Drawing.Size(77, 16);
            this.rdoty.TabIndex = 0;
            this.rdoty.TabStop = true;
            this.rdoty.Text = " 体育运动";
            this.rdoty.UseVisualStyleBackColor = true;
            // 
            // rodah
            // 
            this.rodah.AutoSize = true;
            this.rodah.Location = new System.Drawing.Point(20, 51);
            this.rodah.Name = "rodah";
            this.rodah.Size = new System.Drawing.Size(47, 16);
            this.rodah.TabIndex = 1;
            this.rodah.TabStop = true;
            this.rodah.Text = "旅行";
            this.rodah.UseVisualStyleBackColor = true;
            // 
            // rdoit
            // 
            this.rdoit.AutoSize = true;
            this.rdoit.Location = new System.Drawing.Point(169, 51);
            this.rdoit.Name = "rdoit";
            this.rdoit.Size = new System.Drawing.Size(47, 16);
            this.rdoit.TabIndex = 2;
            this.rdoit.TabStop = true;
            this.rdoit.Text = "编程";
            this.rdoit.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(63, 152);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "确定";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(189, 152);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 2;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 187);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.grprong);
            this.Name = "Form1";
            this.Text = "我的爱好";
            this.grprong.ResumeLayout(false);
            this.grprong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grprong;
        private System.Windows.Forms.RadioButton rodah;
        private System.Windows.Forms.RadioButton rdoty;
        private System.Windows.Forms.RadioButton rdoit;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnno;
    }
}

