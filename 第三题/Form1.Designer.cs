namespace 第三题
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picimg = new System.Windows.Forms.PictureBox();
            this.tmrda = new System.Windows.Forms.Timer(this.components);
            this.imapic = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).BeginInit();
            this.SuspendLayout();
            // 
            // picimg
            // 
            this.picimg.Image = ((System.Drawing.Image)(resources.GetObject("picimg.Image")));
            this.picimg.Location = new System.Drawing.Point(40, 31);
            this.picimg.Name = "picimg";
            this.picimg.Size = new System.Drawing.Size(304, 294);
            this.picimg.TabIndex = 0;
            this.picimg.TabStop = false;
            this.picimg.Click += new System.EventHandler(this.pictu_Click);
            // 
            // tmrda
            // 
            this.tmrda.Interval = 50;
            this.tmrda.Tick += new System.EventHandler(this.tmrda_Tick);
            // 
            // imapic
            // 
            this.imapic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imapic.ImageStream")));
            this.imapic.TransparentColor = System.Drawing.Color.Transparent;
            this.imapic.Images.SetKeyName(0, "6`J_C$7[2D6H7)JKHIWV@$S.gif");
            this.imapic.Images.SetKeyName(1, "BO766$~4)O}(1}_USD63AR0.jpg");
            this.imapic.Images.SetKeyName(2, "BO766$~4)O}(1}_USD63AR0.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.picimg);
            this.Name = "Form1";
            this.Text = "变脸";
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picimg;
        private System.Windows.Forms.Timer tmrda;
        private System.Windows.Forms.ImageList imapic;
    }
}

