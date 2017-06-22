namespace Calculator
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblfu = new System.Windows.Forms.Label();
            this.comchar = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtjg = new System.Windows.Forms.TextBox();
            this.btnjs = new System.Windows.Forms.Button();
            this.btnon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(35, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 12);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "第一个数";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(37, 57);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(51, 21);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblfu
            // 
            this.lblfu.AutoSize = true;
            this.lblfu.Location = new System.Drawing.Point(132, 23);
            this.lblfu.Name = "lblfu";
            this.lblfu.Size = new System.Drawing.Size(41, 12);
            this.lblfu.TabIndex = 2;
            this.lblfu.Text = "运算符";
            // 
            // comchar
            // 
            this.comchar.FormattingEnabled = true;
            this.comchar.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comchar.Location = new System.Drawing.Point(134, 57);
            this.comchar.Name = "comchar";
            this.comchar.Size = new System.Drawing.Size(39, 20);
            this.comchar.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(210, 23);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 12);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "第二个数";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(212, 56);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(51, 21);
            this.txt2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(282, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "结果";
            // 
            // txtjg
            // 
            this.txtjg.Location = new System.Drawing.Point(321, 57);
            this.txtjg.Name = "txtjg";
            this.txtjg.Size = new System.Drawing.Size(60, 21);
            this.txtjg.TabIndex = 8;
            // 
            // btnjs
            // 
            this.btnjs.Location = new System.Drawing.Point(91, 101);
            this.btnjs.Name = "btnjs";
            this.btnjs.Size = new System.Drawing.Size(75, 23);
            this.btnjs.TabIndex = 9;
            this.btnjs.Text = "计算";
            this.btnjs.UseVisualStyleBackColor = true;
            this.btnjs.Click += new System.EventHandler(this.btnjs_Click);
            // 
            // btnon
            // 
            this.btnon.Location = new System.Drawing.Point(218, 101);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(75, 23);
            this.btnon.TabIndex = 10;
            this.btnon.Text = "退出";
            this.btnon.UseVisualStyleBackColor = true;
            this.btnon.Click += new System.EventHandler(this.btnon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 136);
            this.Controls.Add(this.btnon);
            this.Controls.Add(this.btnjs);
            this.Controls.Add(this.txtjg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.comchar);
            this.Controls.Add(this.lblfu);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblfu;
        private System.Windows.Forms.ComboBox comchar;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtjg;
        private System.Windows.Forms.Button btnjs;
        private System.Windows.Forms.Button btnon;
    }
}

