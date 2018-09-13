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
    public partial class Form2 : Form
    {
        string connectionstring = @"Data Source=PCG;Initial Catalog=word;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "" )
                MessageBox.Show("Заполните обязательные поля!");
            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Пароли не совпадают!");
            else
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@RoleId", txtRoleId.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Спасибо за регистрацию. Добро Пожаловать!"); 
                Clear();
                }
        }
        void Clear()
       {
            txtEmail.Text = txtPassword.Text = txtFirstName.Text = txtLastName.Text = txtRoleId.Text = txtConfirmPassword.Text= "";
        }

          
         

private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 frm2 = new Form3();
            frm2.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

       



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm2 = new Form1();
            frm2.Show();
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
            txtConfirmPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
            
        }

       
    }
}
