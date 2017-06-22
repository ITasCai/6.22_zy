using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第四题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (rodah.Checked==true)
            {
                MessageBox.Show("你的爱好是旅行", "猜对了", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (rdoty.Checked==true)
            {
                MessageBox.Show("你的爱好是体育运动", "猜对了", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (rdoit.Checked == true)
            {
                MessageBox.Show("你的爱好是编程", "猜对了", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
