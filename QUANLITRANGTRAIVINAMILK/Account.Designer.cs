
namespace QUANLITRANGTRAIVINAMILK
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.THONGTIN = new System.Windows.Forms.GroupBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_tk = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.THONGTIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(6, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 8;
            // 
            // txt_TK
            // 
            this.txt_TK.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK.Location = new System.Drawing.Point(6, 61);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(200, 19);
            this.txt_TK.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tài khoản";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // THONGTIN
            // 
            this.THONGTIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.THONGTIN.Controls.Add(this.cb_role);
            this.THONGTIN.Controls.Add(this.txt_password);
            this.THONGTIN.Controls.Add(this.label2);
            this.THONGTIN.Controls.Add(this.label1);
            this.THONGTIN.Controls.Add(this.txt_TK);
            this.THONGTIN.Controls.Add(this.panel1);
            this.THONGTIN.Controls.Add(this.label4);
            this.THONGTIN.Controls.Add(this.panel2);
            this.THONGTIN.Location = new System.Drawing.Point(12, 87);
            this.THONGTIN.Name = "THONGTIN";
            this.THONGTIN.Size = new System.Drawing.Size(224, 272);
            this.THONGTIN.TabIndex = 9;
            this.THONGTIN.TabStop = false;
            this.THONGTIN.Text = "Thông tin tài khoản";
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin ",
            "Nhà Phân phối ",
            "Nhà phát hành"});
            this.cb_role.Location = new System.Drawing.Point(9, 221);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(184, 21);
            this.cb_role.TabIndex = 9;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Control;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(6, 137);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(200, 19);
            this.txt_password.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vai trò";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(6, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 8;
            // 
            // dgv_tk
            // 
            this.dgv_tk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tk.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tk.Location = new System.Drawing.Point(276, 61);
            this.dgv_tk.Name = "dgv_tk";
            this.dgv_tk.RowHeadersWidth = 51;
            this.dgv_tk.Size = new System.Drawing.Size(443, 377);
            this.dgv_tk.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh sách tài khoản";
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_menu.Location = new System.Drawing.Point(276, 61);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(89, 40);
            this.btn_menu.TabIndex = 10;
            this.btn_menu.Text = "MENU";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_them.Location = new System.Drawing.Point(24, 382);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(91, 45);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUANLITRANGTRAIVINAMILK.Properties.Resources.Picture1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_sua.Location = new System.Drawing.Point(145, 382);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(91, 45);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_tk);
            this.Controls.Add(this.THONGTIN);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Account";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Account_Load);
            this.THONGTIN.ResumeLayout(false);
            this.THONGTIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox THONGTIN;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_tk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
    }
}