using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu26_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HCNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HCN h = new HCN();
            h.Show();
        }

        private void HTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void B1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PTB1 pTB1 = new PTB1();
            pTB1.Show();
        }
    }
}
