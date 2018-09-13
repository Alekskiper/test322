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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wordDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.wordDataSet.User);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm7 = new Form2();
            frm7.Show();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
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
