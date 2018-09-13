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
    public partial class Form15 : Form
    {
       

        public Form15()
        {
            InitializeComponent();
           
        }
        double hight = 0, weight = 0 , age = 0, bmr = 0, total = 0;
               //Рост      Вес        Возраст 
        private void Form15_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form16 frm15 = new Form16();
            frm15.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm15 = new Form10();
            frm15.Show();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Сидячий");
            comboBox1.Items.Add("Маленькая активность");
            comboBox1.Items.Add("Средняя активность");
            comboBox1.Items.Add("Сильная активность");
            comboBox1.Items.Add("Максимальная активность");

        }

        string str;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                hight = double.Parse(textBox1.Text);
                weight = double.Parse(textBox2.Text);
                age = double.Parse(numericUpDown1.Value.ToString());
                bmr=88.36+(13.4*weight)+(4.8*hight)- (5.7*age);
                str = comboBox1.SelectedItem.ToString();
                switch(str)
                {
                    case "Сидячий": total = bmr * 1.2;
                        break;
                    case "Маленькая активность": total = bmr * 1.375;
                        break;
                    case "Средняя активность": total = bmr * 1.55;
                        break;
                    case "Сильная активность": total = bmr * 1.725;
                        break;
                    case "Максимальная активность":  total = bmr * 1.9;
                        break;

                }
                textBox3.Text = bmr.ToString("#,##");
                textBox4.Text = total.ToString("#,##");
            }
        else    if (radioButton2.Checked)
            {
                hight = double.Parse(textBox1.Text);
                weight = double.Parse(textBox2.Text);
                age = double.Parse(numericUpDown1.Value.ToString());
                bmr = 447.6 + (9.2 * weight) + (3.1 * hight) - (4.3 * age);
                str = comboBox1.SelectedItem.ToString();
                switch (str)
                {
                    case "Сидячий":total = bmr * 1.2;
                        break;
                    case "Маленькая активность": total = bmr * 1.375;
                        break;
                    case "Средняя активность": total = bmr * 1.55;
                        break;
                    case "Сильная активность": total = bmr * 1.725;
                        break;
                    case "Максимальная активность": total = bmr * 1.9;
                        break;
                }
                textBox3.Text = bmr.ToString("#,##");
                textBox4.Text = total.ToString("#,##");
            }
        }
    }
}
