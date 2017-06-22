namespace 第五题
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblka = new System.Windows.Forms.Label();
            this.txtka = new System.Windows.Forms.TextBox();
            this.lblman = new System.Windows.Forms.Label();
            this.txtman = new System.Windows.Forms.TextBox();
            this.brnadd = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.lstshow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("宋体", 12F);
            this.lblid.Location = new System.Drawing.Point(12, 157);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(24, 16);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(113, 157);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(111, 21);
            this.txtid.TabIndex = 2;
            // 
            // lblka
            // 
            this.lblka.AutoSize = true;
            this.lblka.Font = new System.Drawing.Font("宋体", 12F);
            this.lblka.Location = new System.Drawing.Point(230, 157);
            this.lblka.Name = "lblka";
            this.lblka.Size = new System.Drawing.Size(40, 16);
            this.lblka.TabIndex = 3;
            this.lblka.Text = "卡号";
            this.lblka.Click += new System.EventHandler(this.lblka_Click);
            // 
            // txtka
            // 
            this.txtka.Location = new System.Drawing.Point(300, 158);
            this.txtka.Name = "txtka";
            this.txtka.Size = new System.Drawing.Size(190, 21);
            this.txtka.TabIndex = 4;
            this.txtka.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblman
            // 
            this.lblman.AutoSize = true;
            this.lblman.Font = new System.Drawing.Font("宋体", 12F);
            this.lblman.Location = new System.Drawing.Point(15, 195);
            this.lblman.Name = "lblman";
            this.lblman.Size = new System.Drawing.Size(72, 16);
            this.lblman.TabIndex = 5;
            this.lblman.Text = "消费金额";
            // 
            // txtman
            // 
            this.txtman.Location = new System.Drawing.Point(113, 195);
            this.txtman.Name = "txtman";
            this.txtman.Size = new System.Drawing.Size(128, 21);
            this.txtman.TabIndex = 6;
            // 
            // brnadd
            // 
            this.brnadd.Location = new System.Drawing.Point(101, 254);
            this.brnadd.Name = "brnadd";
            this.brnadd.Size = new System.Drawing.Size(75, 23);
            this.brnadd.TabIndex = 7;
            this.brnadd.Text = "添加";
            this.brnadd.UseVisualStyleBackColor = true;
            this.brnadd.Click += new System.EventHandler(this.brnadd_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(331, 254);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 8;
            this.btnno.Text = "退出";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // lstshow
            // 
            this.lstshow.FormattingEnabled = true;
            this.lstshow.ItemHeight = 12;
            this.lstshow.Location = new System.Drawing.Point(76, 12);
            this.lstshow.Name = "lstshow";
            this.lstshow.Size = new System.Drawing.Size(345, 112);
            this.lstshow.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 302);
            this.Controls.Add(this.lstshow);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.brnadd);
            this.Controls.Add(this.txtman);
            this.Controls.Add(this.lblman);
            this.Controls.Add(this.txtka);
            this.Controls.Add(this.lblka);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Name = "Form1";
            this.Text = "银行管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblka;
        private System.Windows.Forms.TextBox txtka;
        private System.Windows.Forms.Label lblman;
        private System.Windows.Forms.TextBox txtman;
        private System.Windows.Forms.Button brnadd;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.ListBox lstshow;
    }
}

