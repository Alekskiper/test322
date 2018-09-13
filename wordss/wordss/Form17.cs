using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
//using Microsoft.SqlServer.Management.Smo;
namespace wordss
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
                SqlConnection conn = new SqlConnection(@"Data Source=PCG;Initial Catalog=word;Integrated Security=True");
                conn.Open();
            string abc = "CREATE LOGIN [" + txtFirstName.Text + "]  WITH PASSWORD = '"+ txtPassword.Text +"', DEFAULT_DATABASE =[word]";
                var cmd = new SqlCommand(abc, conn);
            //MessageBox.Show(abc);
               cmd.ExecuteNonQuery();
                MessageBox.Show("Вы зарегистрировали нового пользователя в SQL Server!");
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
                SqlConnection conn = new SqlConnection(@"Data Source=PCG;Initial Catalog=word;Integrated Security=True");
                conn.Open();
                var cmd = new SqlCommand("DROP LOGIN  [" + textBox1.Text+ "];" +
                                            "USE word;" +
                                            "DROP USER  [" + txtFirstName.Text + "]; ", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Вы удалили нового пользователя в SQL Server!");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PCG;Initial Catalog=word;Integrated Security=True");
            conn.Open();
            var cmd = new SqlCommand("Use word;" + "CREATE USER [" + txtFirstName.Text + "] FOR LOGIN [" + txtFirstName.Text + "] WITH DEFAULT_SCHEMA =[dbo] " +
                                        "ALTER ROLE[db_datareader] ADD MEMBER [" + txtFirstName.Text + "]" +
                                        "ALTER ROLE[db_datawriter] ADD MEMBER [" + txtFirstName.Text + "];" +
                                        "ALTER ROLE[db_ddladmin] ADD MEMBER [" + txtFirstName.Text + "]; ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Вы дали права новому пользователю в SQL Server!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PCG;Initial Catalog=word;Integrated Security=True");
            conn.Open();
            var cmd = new SqlCommand("Use word;" + 
                                      "ALTER ROLE[db_datareader] DROP MEMBER [" + txtFirstName.Text + "]" +
                                      "ALTER ROLE[db_datawriter] DROP MEMBER [" + txtFirstName.Text + "];" +
                                      "ALTER ROLE[db_ddladmin] DROP MEMBER [" + txtFirstName.Text + "];", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Вы убрали права у нового пользователя  в SQL Server!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm17 = new Form1();
            frm17.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}
