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
    public partial class HCN : Form
    {
        public HCN()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b;
            bool k = float.TryParse(textBox1.Text, out a);
            bool k2 = float.TryParse(textBox2.Text, out b);
            if(k == true && k2 == true) {
                lblKetQua.Text = "Diện tích là: " + (a * b).ToString();

            }
            else
            {
                MessageBox.Show("Dữ liệu nhập chưa đúng!");
            }
        }

        private void xanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblKetQua.BackColor = Color.Green;
        }

        private void đỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblKetQua.BackColor= Color.Red;
        }

        private void vàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblKetQua.BackColor = Color.Yellow;
        }
    }
}
