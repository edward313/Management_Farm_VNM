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

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_SanPham a = new BLL_SanPham();
                string MaSP = this.txt_maSP.Text.Trim();
                string TenSP = this.txt_TenSP.Text.Trim();
                int Gia = int.Parse(this.txt_Gia.Text.Trim());
                int Dungtich = int.Parse(this.txt_Dungtich.Text.Trim());
                int SoLuong = int.Parse(this.txt_soluong.Text.Trim());




                a.addSP(MaSP, TenSP, Gia, SoLuong, Dungtich);
                LoadData_SP();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm không thành công.\nVui lòng kiểm tra lại" + ex, "Thông báo");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_SanPham a = new BLL_SanPham();
                string MaSP = this.txt_maSP.Text.Trim();
                string TenSP = this.txt_TenSP.Text.Trim();
                int Gia = int.Parse(this.txt_Gia.Text.Trim());
                int Dungtich = int.Parse(this.txt_Dungtich.Text.Trim());
                int SoLuong = int.Parse(this.txt_soluong.Text.Trim());




                a.updateSP(MaSP, TenSP, Gia, SoLuong, Dungtich);
                LoadData_SP();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa không thành công.\nVui lòng kiểm tra lại" + ex, "Thông báo");
            }
        }

        private void dgvSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvSp.CurrentCell.Selected = true;
            txt_maSP.Text = dgvSp.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_TenSP.Text = dgvSp.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Gia.Text = dgvSp.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_soluong.Text = dgvSp.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Dungtich.Text = dgvSp.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa trang trại này không ", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    BLL_SanPham a = new BLL_SanPham();
                    string maSP = this.txt_maSP.Text.Trim();
                    a.deleteSP(maSP);
                    LoadData_SP();
                    MessageBox.Show("Xóa thành công nhà trạng trại ", "Thông báo");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Xóa không thành công nhà trại .\nVui lòng kiểm tra lại " + ex, "Thông báo");
                }
            }
        }
    }
}
