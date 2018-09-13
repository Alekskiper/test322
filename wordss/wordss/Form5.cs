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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label2.Text = "Вы вошли как:" + ((Form)this.MdiParent).Controls["label2"].Text;
            if (((Form)this.MdiParent).Controls["label2"].Text != "Ramder")
            {
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm5 = new Form6();
            frm5.Show();
        }
    }
}
