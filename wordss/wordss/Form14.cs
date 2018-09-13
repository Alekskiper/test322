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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C://Users//Computer//Desktop//zadanie//TP09_resources//Icons\\airbus-a380.jpg");
            label3.Visible  = true;
            label12.Visible = true;
            label2.Visible  = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C://Users//Computer//Desktop//zadanie//TP09_resources//Icons\\banco-banespa.jpg");
            label2.Visible  = true;
            label13.Visible = true;
            label3.Visible  = false;
            label12.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C://Users//Computer//Desktop//zadanie//TP09_resources//Icons\\bus.jpg");
            label14.Visible = true;
            label15.Visible = true;
            label2.Visible  = false;
            label3.Visible  = false;
            label12.Visible = false;
            label13.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C://Users//Computer//Desktop//zadanie//TP09_resources//Icons\\f1-car.jpg");
            label16.Visible = true;
            label17.Visible = true;
            label2.Visible  = false;
            label3.Visible  = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C://Users//Computer//Desktop//zadanie//TP09_resources//Icons\\capybara.jpg");
            label18.Visible = true;
            label19.Visible = true;
            label2.Visible  = false;
            label3.Visible  = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C://Users//Computer//Desktop//zadanie//TP09_resources//Icons\\football-field.jpg");
            label20.Visible = true;
            label21.Visible = true;
            label2.Visible  = false;
            label3.Visible  = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C://Users//Computer//Desktop//zadanie//TP09_resources//Icons\\ronaldinho.jpg");
            label22.Visible = true;
            label23.Visible = true;
            label2.Visible  = false;
            label3.Visible  = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C://Users//Computer//Desktop//zadanie//TP09_resources//Icons\\teatro-municipal.jpg");
            label24.Visible = true;
            label25.Visible = true;
            label2.Visible  = false;
            label3.Visible  = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm14 = new Form10();
            frm14.Show();
        }
    }
}
