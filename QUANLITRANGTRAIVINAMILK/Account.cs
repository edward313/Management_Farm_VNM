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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void Loaddata()
        {
            BLL_ACCOUNT NP = new BLL_ACCOUNT();
            DataTable np = NP.DStaiKhoan();
            dgv_tk.DataSource = np;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            BLL_ACCOUNT a = new BLL_ACCOUNT();
            string TK = this.txt_TK.Text.Trim();
            string MK = this.txt_password.Text.Trim();
            string role = this.cb_role.Text.Trim();

            if (TK != null && MK != null && role != null)
            {
                a.addAccount(TK, MK, role);
                Loaddata();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
       
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            BLL_ACCOUNT a = new BLL_ACCOUNT();
            string TK = this.txt_TK.Text.Trim();
            string MK = this.txt_password.Text.Trim();
            string role = this.cb_role.Text.Trim();

            if (TK != null && MK != null && role != null)
            {
                a.editAccount(TK, MK, role);
                
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            Loaddata();


        }
    }
}
