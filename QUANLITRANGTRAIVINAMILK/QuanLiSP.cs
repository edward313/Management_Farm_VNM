using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QUANLITRANGTRAIVINAMILK
{
    public partial class QuanLiSP : Form
    {
        public QuanLiSP()
        {
            InitializeComponent();
            LoadData_SP();
        }
        void LoadData_SP()
        {
            BLL_SanPham SP = new BLL_SanPham();
            DataTable sp = SP.DSSanPham();
            dgvSp.DataSource = sp;
        }

        private void QuanLiSP_Load(object sender, EventArgs e)
        {

        }
        private void btn_quaylai_Click(object sender, EventArgs e)
        {

        }

        private void btn_quaylai_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc ", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Menu tk = new Menu();
                tk.ShowDialog();
                this.Close();
            }
        }
    }
}
