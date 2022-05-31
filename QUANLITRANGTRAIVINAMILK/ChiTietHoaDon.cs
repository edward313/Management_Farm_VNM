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
    public partial class ChiTietHoaDon : Form
    {
        String MaHoaDon;
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        public ChiTietHoaDon(String MaHoaDon)
        {
            InitializeComponent();
            this.MaHoaDon = MaHoaDon;
            BLL_ChiTietHoaDon CTHD = new BLL_ChiTietHoaDon();
            DataTable cthd = CTHD.ChiTietHoaDon(MaHoaDon);
            dgv_chitiethoadon.DataSource = cthd;
        }
        
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
