using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第三题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tmrda.Start();
        }

        private void pictu_Click(object sender, EventArgs e)
        {

        }

        int i = 0;
        private void tmrda_Tick(object sender, EventArgs e)
        {
            picimg.Image = imapic.Images[i];
            i++;
            if (i == imapic.Images.Count)
            {
                i = 0;
            }
        }
    }
}
