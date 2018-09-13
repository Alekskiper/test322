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
using Microsoft.SqlServer.Management.Smo;
namespace wordss
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Persist Security Info=False;User ID=" + textBox1.Text + ";Password=" + textBox2.Text + ";Initial Catalog=word; Data Source =PCG;");
            SqlDataAdapter sda = new SqlDataAdapter("select * from sys.sql_logins where default_database_name = 'word'", conn);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                
                MDIParent1 ss = new MDIParent1(dt.Rows[0][0].ToString());
                ss.Show();
               
            }
            else
            {
                MessageBox.Show("Неверные данные");

            }


        }
        
        
       
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm18 = new Form1();
            frm18.Show();
        }
        
    }
    

}

