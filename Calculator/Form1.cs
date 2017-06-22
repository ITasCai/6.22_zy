using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnjs_Click(object sender, EventArgs e)
        {
            string ch = comchar.Text.Trim();

            double t1 = Convert.ToDouble(txt1.Text);
            double t2 = Convert.ToDouble(txt2.Text);
            double jg=0 ;

            switch (ch)
            {
                case "+":

                    jg = t1 + t2; 
                    break;
                case "-":
                    jg = t1 - t2;
                    break;
                case "*":
                    jg = t1 * t2;
                    break;
                case "/":
                    jg = t1 / t2;
                    break;
            }
            txtjg.Text = jg.ToString();
        }

        private void btnon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
