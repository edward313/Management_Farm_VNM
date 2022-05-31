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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            Loaddata();
        }
        void Loaddata()
        {
            BLL_NhanVien NV = new BLL_NhanVien();
            DataTable nv = NV.DSNhanVien();
            dgv_NhanVien.DataSource = nv;
        }
        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_quaylai_Click(object sender, EventArgs e)
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

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
