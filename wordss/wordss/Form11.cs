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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( radioButton1.Checked)
            { 
            double bmi;
            double kg = double.Parse(numericUpDown2.Value.ToString()); //вес
            double mt2 = Math.Pow(double.Parse(numericUpDown1.Value.ToString()), 2); //рост
            bmi = kg / mt2 ;
            if (bmi.ToString().Length > 5 )
            {
                textBox1.Text = (kg / mt2 ).ToString().Remove(5);
            }
            else
            {
                textBox1.Text = (kg / mt2 ).ToString();
            }
            
            if (bmi < 18.5 )
            {
                label10.Visible = true;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
            }
            else if (bmi > 18.5 && bmi < 24.9 )
            {
                label10.Visible = false;
                label11.Visible = true;
                label12.Visible = false;
                label13.Visible = false;
            }
            else if (bmi > 25 && bmi < 29.9)
            {
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = true;
                label13.Visible = false;
            }
            else if (bmi > 30)
            {
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = true;
            }
            }


            if (radioButton2.Checked)
            {
                double bmi;
                double kg = double.Parse(numericUpDown2.Value.ToString());
                double mt2 = Math.Pow(double.Parse(numericUpDown1.Value.ToString()), 2);
                bmi = kg / mt2;
                if (bmi.ToString().Length > 5)
                {
                    textBox1.Text = (kg / mt2 * 0.95).ToString().Remove(5);
                }
                else
                {
                    textBox1.Text = (kg / mt2 * 0.95).ToString();
                }

                if (bmi < 18.5)
                {
                    label10.Visible = true;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                }
                else if (bmi > 18.5 && bmi < 24.9)
                {
                    label10.Visible = false;
                    label11.Visible = true;
                    label12.Visible = false;
                    label13.Visible = false;
                }
                else if (bmi > 25 && bmi < 29.9)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = true;
                    label13.Visible = false;
                }
                else if (bmi > 30)
                {
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm11 = new Form10();
            frm11.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label15.Text = "22";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label15.Text = "23";

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label15.Text = "24";

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label15.Text = "25";

            }
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
