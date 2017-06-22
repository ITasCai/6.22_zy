using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 第五题
{
    public partial class Form1 : Form
    {
        //连接字符串
        string strcon = "Data Source=.;Initial Catalog=Bank;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
           
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblka_Click(object sender, EventArgs e)
        {

        }

        private void brnadd_Click(object sender, EventArgs e)
        {

            lstshow.Items.Clear();
            //连接数据库，打开数据源
            SqlConnection con = new SqlConnection(strcon);

            try
            {

                //创建sqly语句
                string strsql = string.Format("INSERT INTO CardRecord( cardno, cost )VALUES  ('{0}','{1}')",  txtka.Text.Trim(), txtman.Text.Trim());
                //创建命令对象
                SqlCommand cmd = new SqlCommand(strsql, con);
                //打开连接
                con.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally {
                //关闭连接
                con.Close();
            }
            
            ShowInfo();
        }

        public void ShowInfo()
        {
            //连接数据库，打开数据源
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                //创建sqly语
                string strsql =string.Format( "SELECT * FROM dbo.CardRecord ");
                //创建命令对象
                SqlCommand cmd = new SqlCommand(strsql, con);
                con.Open();
                //定义一个只读只进的记录的对象
                SqlDataReader dr = cmd.ExecuteReader();

           
                while (dr.Read())
                {
                    string id = dr[0].ToString();
                    string ka = dr[1].ToString();
                    string je = dr[2].ToString();

                    //显示在列表中
                    lstshow.Items.Add(id + "\t" + ka + "\t" + je);
                }
                //关闭记录集
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
                con.Close();
            }
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
