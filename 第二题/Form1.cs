using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第二题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 13; i++)
            {
                comyue.Items.Add(i);
            }
           
        }

        private void comyue_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comyue.Text)
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "11":
                    for (int i = 1; i < 32; i++)
                    {
                        comri.Items.Add(i);
                    }
                    break;

                case "4":
                case "6":
                case "9":
                case "12":
                    for (int i = 1; i < 31; i++)
                    {
                        comri.Items.Add(i);
                    }
                    break;
                case "2":
                    for (int i = 1; i < 29; i++)
                    {
                        comri.Items.Add(i);
                    }
                    break;
            }
        }

        private void comri_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

       }
    }

