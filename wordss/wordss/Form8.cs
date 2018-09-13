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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.eventTableAdapter.Fill(this.wordDataSet.Event);

            label2.Text = "Вы вошли как:" + ((Form)this.MdiParent).Controls["label2"].Text;
                if (((Form)this.MdiParent).Controls["label2"].Text != "Ramder")
                {
                dataGridView1.Enabled= false;
                

                }
            

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.eventBindingSource.EndEdit();
                this.eventTableAdapter.Update(this.wordDataSet.Event);
                MessageBox.Show("Обновление успешно");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Не удалось обновить");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 frm8 = new Form18();
            frm8.Show();
        }
    }
}
