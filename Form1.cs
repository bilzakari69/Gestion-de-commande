using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(c);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products c = new Products();
            c.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(c);
        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commande c = new Commande();
            c.Show();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(c);
        }
    }
}
