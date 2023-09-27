using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Menu26_9
{
    public partial class PTB1 : Form
    {
        public PTB1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            float a, b;
            bool k = float.TryParse(txta.Text, out a);
            bool k2 = float.TryParse(txtb.Text, out b);
            if (k == true && k2 == true)
            {
                lblKq.Text = "x =  " + (-b / a).ToString();

            }
            else
            {
                MessageBox.Show("Dữ liệu nhập chưa đúng!");
            }
        }
    }
}
