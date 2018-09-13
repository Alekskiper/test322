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
    public partial class Form1 : Form
    {
        

        DateTime voteTime = new DateTime(2018, 03, 01, 6, 0, 0);
        
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm1 = new Form3();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm1 = new Form4();
            frm1.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            this.statusStrip1.Items[0].Text = TimeRemaining.Days + " day(s) " + TimeRemaining.Hours + " hour(s) " + TimeRemaining.Minutes + " minute(s) до старта марафона";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form9 frm1 = new Form9();
            //frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm1 = new Form10();
            frm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 frm1 = new Form17();
            frm1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 frm1 = new Form18();
            frm1.Show();
        }
    }
}
