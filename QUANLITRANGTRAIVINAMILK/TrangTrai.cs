using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QUANLITRANGTRAIVINAMILK
{
    public partial class TrangTrai : Form
    {
        public TrangTrai()
        {
            InitializeComponent();
        }

        private void TrangTrai_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        void Loaddata()
        {
            BLL_TrangTrai NP = new BLL_TrangTrai();
            DataTable np = NP.DSNongTrai();
            dgv_NongTrai.DataSource = np;
        }

        private void dgv_NongTrai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_NongTrai.CurrentCell.Selected = true;
            txt_maNT.Text = dgv_NongTrai.Rows[e.RowIndex].Cells["MaNT"].Value.ToString();
            txt_TenNT.Text = dgv_NongTrai.Rows[e.RowIndex].Cells["TenNT"].Value.ToString();
            txt_ChuSoHuu.Text = dgv_NongTrai.Rows[e.RowIndex].Cells["ChuSoHuu"].Value.ToString();
            txt_diachi.Text = dgv_NongTrai.Rows[e.RowIndex].Cells["Diachi"].Value.ToString();
            txt_sdt.Text = dgv_NongTrai.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            txt_tk.Text = dgv_NongTrai.Rows[e.RowIndex].Cells["MaTk"].Value.ToString();
        }

        private void txt_them_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_TrangTrai a = new BLL_TrangTrai();
                string maNT = this.txt_maNT.Text.Trim();
                string TenNT = this.txt_TenNT.Text.Trim();
                string ChuSoHuu = this.txt_ChuSoHuu.Text.Trim();
                string Diachi = this.txt_diachi.Text.Trim();
                string SDTNT = this.txt_sdt.Text.Trim();
                string MaTK = this.txt_tk.Text.Trim();

                a.addTrangtrai(maNT, TenNT, ChuSoHuu, Diachi, SDTNT, MaTK);
                Loaddata();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (SqlException)
            {
                MessageBox.Show("Thêm không thành công.\nVui lòng kiểm tra lại", "Thông báo");
            }

        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa trang trại này không ", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    BLL_TrangTrai a = new BLL_TrangTrai();
                    string maNT = this.txt_maNT.Text.Trim();
                    a.deleteTrangtrai(maNT);
                    Loaddata();
                    MessageBox.Show("Xóa thành công nhà trạng trại ", "Thông báo");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Xóa không thành công nhà trại .\nVui lòng kiểm tra lại", "Thông báo");
                }
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
