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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        int dong = 0;
        private void Hoadon_Load(object sender, EventArgs e)
        {
            BLL_NPP NP = new BLL_NPP();
            DataTable np = NP.DSNhaPhanPhoi();

            cb_NPP.DataSource = np;
            cb_NPP.ValueMember = "MaNPP";
            cb_NPP.DisplayMember = "MaNPP";


            BLL_TrangTrai NT = new BLL_TrangTrai();
            DataTable nt = NT.DSNongTrai();

            cb_MaNT.DataSource = nt;
            cb_MaNT.ValueMember = "MaNT";
            cb_MaNT.DisplayMember = "TenNT";

            BLL_SanPham SP = new BLL_SanPham();
            DataTable sp = SP.DSSanPham();
            MaSP.DataSource = sp;
            MaSP.ValueMember = "MaSp";
            MaSP.DisplayMember = "TenSanPham";

            Loaddata_HoaDon();
        }


        void Loaddata_HoaDon()
        {
            BLL_HoaDon HD = new BLL_HoaDon();
            DataTable hd = HD.DSHoaDon();
            dgv_dsHoaDon.DataSource = hd;
        }
        private void dgv_chitietsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void dgv_chitietsp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_chitietsp.Rows[dong].Cells[2].Value != null && dgv_chitietsp.Rows[dong].Cells[3].Value != null)
            {

                
              
                
                dgv_chitietsp.Rows[dong].Cells[4].Value = (double.Parse(dgv_chitietsp.Rows[dong].Cells["DonGia"].Value.ToString()) * double.Parse(dgv_chitietsp.Rows[dong].Cells["SoLuong"].Value.ToString()));
            }    
            try
            {
                BLL_SanPham SP = new BLL_SanPham();
                DataTable dt = new DataTable();
                dt = SP.DSSanPham_DonGia(dgv_chitietsp.Rows[dong].Cells[0].Value?.ToString());
                dgv_chitietsp.Rows[dong].Cells[2].Value = dt.Rows[0][2];

              
            } catch
            {
                    
            }
        }

        private void dgv_chitietsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_tinhtien_Click(object sender, EventArgs e)
        {
            int sc = dgv_chitietsp.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgv_chitietsp.Rows[i].Cells["ThanhTien"].Value.ToString());

            txt_thanhtien.Text = thanhtien.ToString();
        }

        private void btn_themdonhang_Click(object sender, EventArgs e)
        {
            BLL_HoaDon HD = new BLL_HoaDon();
            BLL_ChiTietHoaDon CTHD = new BLL_ChiTietHoaDon();
            string MaHoaDon = txt_MaHoaDon.Text.Trim();
            string MaNPP = cb_NPP.Text.Trim();
            string MaNT = cb_MaNT.Text.Trim();
            float tongtien = float.Parse(txt_thanhtien.Text);
            HD.addHoaDon(MaHoaDon, MaNT, MaNPP, DateTime.Now, tongtien);
            

            

            for (int i =0;i <dgv_chitietsp.Rows.Count -1; i++)
            {
                string MaSP = dgv_chitietsp.Rows[i].Cells[0].Value.ToString();
                float SoLuong = float.Parse(dgv_chitietsp.Rows[i].Cells[3].Value.ToString());
                float DonGia = float.Parse(dgv_chitietsp.Rows[i].Cells[2].Value.ToString());
                float ThanhTien = float.Parse(dgv_chitietsp.Rows[i].Cells[4].Value.ToString());
                CTHD.addCTHoaDon(MaHoaDon, MaSP, SoLuong, DonGia, ThanhTien);

            }


            MessageBox.Show("Thêm Hoa đơn thành công.\nVui lòng kiểm tra lại", "Thông báo");


        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            string MaDonHang = dgv_dsHoaDon.Rows[dong].Cells[0].Value.ToString();
            
            
            ChiTietHoaDon CTHD = new ChiTietHoaDon(MaDonHang);
            CTHD.Show();
            
        }

        private void dgv_dsHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_dsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
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

        private void dtp_hoadon_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
