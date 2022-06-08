using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace QUANLITRANGTRAIVINAMILK
{
    public partial class Nhaphanphoi : Form
    {
        public Nhaphanphoi()
        {
            InitializeComponent();
        }


        void Loaddata()
        {
            BLL_NPP NP = new BLL_NPP();
            DataTable np = NP.DSNhaPhanPhoi();
            dgv_nhaphanphoi.DataSource = np;
        }
       

        private void Nhaphanphoi_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void dgv_nhaphanphoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_nhaphanphoi.CurrentCell.Selected = true;
            txt_maNPP.Text = dgv_nhaphanphoi.Rows[e.RowIndex].Cells["MaNPP"].Value.ToString();
            txt_TenNPP.Text = dgv_nhaphanphoi.Rows[e.RowIndex].Cells["TenNPP"].Value.ToString();
            txt_diachi.Text = dgv_nhaphanphoi.Rows[e.RowIndex].Cells["Diachi"].Value.ToString();
            txt_sdt.Text = dgv_nhaphanphoi.Rows[e.RowIndex].Cells["SDTNPP"].Value.ToString();
            txt_matk.Text = dgv_nhaphanphoi.Rows[e.RowIndex].Cells["MaTK"].Value.ToString();
           
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           
            
                BLL_NPP a = new BLL_NPP();
                string maNPP = this.txt_maNPP.Text.Trim();
                string TenNPP = this.txt_TenNPP.Text.Trim();
                string Diachi = this.txt_diachi.Text.Trim();
                string SDTNPP = this.txt_sdt.Text.Trim();
                string MaTK = this.txt_matk.Text.Trim();




                a.addNPP(maNPP, TenNPP, Diachi, SDTNPP, MaTK);
                Loaddata();

                MessageBox.Show("Thêm nhà phân phối thành công", "Thông báo");
            
            


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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhà phân phối này không " , "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    BLL_NPP a = new BLL_NPP();
                    string maNPP = this.txt_maNPP.Text.Trim();
                    a.deleteNPP(maNPP);
                    Loaddata();
                    MessageBox.Show("Xóa thành công nhà phân phối ", "Thông báo");
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Xóa không thành công nhà phân phói .\nVui lòng kiểm tra lại", "Thông báo");
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            BLL_NPP a = new BLL_NPP();
            string maNPP = this.txt_maNPP.Text.Trim();
            string TenNPP = this.txt_TenNPP.Text.Trim();
            string Diachi = this.txt_diachi.Text.Trim();
            string SDTNPP = this.txt_sdt.Text.Trim();
            string MaTK = this.txt_matk.Text.Trim();




            a.UpdateNPP(maNPP, TenNPP, Diachi, SDTNPP, MaTK);
            Loaddata();

            MessageBox.Show("Update nhà phân phối thành công", "Thông báo");
        }
    }
}
