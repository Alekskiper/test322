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
    public partial class MDIParent1 : Form
    {


        public MDIParent1(string Name)
        {
            InitializeComponent();
            label2.Text = Name;
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 ss = new Form8();
            ss.MdiParent = this;
            ss.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wordDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.wordDataSet.User);

        }
    }
}