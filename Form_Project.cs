using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class Form_Project : Form
    {
        public Form_Project()
        {
            InitializeComponent();
            toolStrip.Hide();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Show();
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Show();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Show();
        }
    }
}
