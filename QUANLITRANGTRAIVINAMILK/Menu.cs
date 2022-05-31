using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLITRANGTRAIVINAMILK
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien nhanvien = new NhanVien();
            nhanvien.ShowDialog();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangTrai farm = new TrangTrai();
            farm.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_menu_NPP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhaphanphoi NPP = new Nhaphanphoi();
            NPP.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon NPP = new HoaDon();
            NPP.ShowDialog();
            this.Close();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiSP SP = new QuanLiSP();
            SP.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
