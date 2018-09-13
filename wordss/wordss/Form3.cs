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
namespace wordss
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=PCG;Initial Catalog=word;Integrated Security=True");
            conn.Open();
            string str1 = "select [Email], [Password], [FirstName], [LastName], [RoleId] from [User] where [Email]='" + textBox5.Text + "' and [Password]='" + textBox6.Text + "'";
            SqlCommand cmd = new SqlCommand(str1, conn);
            SqlDataAdapter da = new SqlDataAdapter(str1, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string result = reader[4].ToString();

            switch (result)
            {
                case "A":
                    MessageBox.Show(reader[4].ToString() + " - Здравствуй Админ   ");
                    break;
                case "R":
                    MessageBox.Show(reader[4].ToString() + " - Привет Пользователь   ");
                    break;
                case "C":
                    MessageBox.Show(reader[4].ToString() + " - Хаю-хай Coordinator   ");
                    break;
            }      
            reader.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form5 f3 = new Form5();
                f3.ShowDialog();
                label3.Hide();
            }
            else
            {
                label3.Show();
                label3.Text = "Email или Пароль неверные";

            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 frm3 = new Form2();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm3 = new Form1();
            frm3.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.PasswordChar = checkBox1.Checked ? '\0' : '*';
            
        }
    }
}

