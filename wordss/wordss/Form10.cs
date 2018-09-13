using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordss
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm10 = new Form1();
            frm10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 frm10 = new Form11();
            frm10.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 frm10 = new Form12();
            frm10.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 frm10 = new Form15();
            frm10.Show();
        }

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите выйти?", "Выйти", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 frm10 = new Form14();
            frm10.Show();
        }
    }
}
