using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiemtra19_09
{
    public partial class Form1 : Form
    {

        List<CanHo> listCanHp = new List<CanHo>();
        public Form1()
        {
            InitializeComponent();
            hienthi();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string diachi, huongbancong, tinhtrang;
            int sophongngu, sowc;
            long gia;
            double trietkhau,tl = 0;
            diachi = txtDiaChi.Text;
            huongbancong = cbHuongBanCong.Text;
            tinhtrang = cbTinhTrang.Text;   
            sophongngu = int.Parse(txtPhongNgu.Text);
            sowc = int.Parse(txtNhaVeSinh.Text);
            gia = long.Parse(txtGia.Text);
            if(cbHuongBanCong.Text == "Tây")
            {
                tl = 0.1;
            }
            if (cbHuongBanCong.Text == "Tây Bắc")
            {
                tl = 0.05;
            }
            if (cbHuongBanCong.Text == "Tây Nam")
            {
                tl = 0.02;
            }
            if (cbHuongBanCong.Text == "Tây Bắc")
            {
                tl = -0.01;
            }
            trietkhau = Double.Parse(txtTrietKhau.Text) + tl;
            CanHo ch = new CanHo(diachi,huongbancong,tinhtrang,sophongngu, sowc, gia, trietkhau: trietkhau);
            lstDS.Items.Add(ch.ToString());
            hienthi();

        }

        public void hienthi()
        {
            if(listCanHp.Count == 0)
            {
                lstDS.Text = "";
            }
           else
            {
                foreach(CanHo CH in listCanHp)
                {
                    lstDS.Items.Add(CH);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstDS.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Chọn phần tử cần sửa.");
                return;
            }

            CanHo selectedChungCu = listCanHp[selectedIndex];

            txtDiaChi.Text = selectedChungCu.Diachi.ToString();
            txtNhaVeSinh.Text = selectedChungCu.Sowc.ToString();
            cbTinhTrang.Text = selectedChungCu.Tinhtrang.ToString();
            txtGia.Text = selectedChungCu.Gia.ToString();
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co muon thoat","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstDS.Items.Clear();
        }
    }
}
