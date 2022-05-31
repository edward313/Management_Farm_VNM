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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            BLL_ACCOUNT tk = new BLL_ACCOUNT();
            string taikhoan = this.txt_tk.Text.Trim();
            string pass = this.txt_password.Text.Trim();
           
            int KT_taikhoan = tk.checklogin(taikhoan, pass);
            if (KT_taikhoan == 1)
            {

                this.Hide();
                Account menu = new Account();
                menu.ShowDialog();
                KT_taikhoan = 0;
                this.Close();

            }
            else if (KT_taikhoan == 2)
            {
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
                KT_taikhoan = 0;
                this.Close();
            }
            else {
                this.txt_tk.Clear();
                this.txt_password.Clear();
                MessageBox.Show("Bạn nhập sai vui lòng nhập lại", "Thông báo"); 
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
