
namespace QUANLITRANGTRAIVINAMILK
{
    partial class HoaDon
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
            this.dgv_chitietsp = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_NPP = new System.Windows.Forms.ComboBox();
            this.cb_MaNT = new System.Windows.Forms.ComboBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_hoadon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaHoaDon = new System.Windows.Forms.TextBox();
            this.btn_tinhtien = new System.Windows.Forms.Button();
            this.btn_themdonhang = new System.Windows.Forms.Button();
            this.tb_hoadon = new System.Windows.Forms.TabControl();
            this.ThemHoaDon = new System.Windows.Forms.TabPage();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_XemChiTiet = new System.Windows.Forms.Button();
            this.dgv_dsHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietsp)).BeginInit();
            this.tb_hoadon.SuspendLayout();
            this.ThemHoaDon.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_chitietsp
            // 
            this.dgv_chitietsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chitietsp.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgv_chitietsp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_chitietsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenHang,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgv_chitietsp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgv_chitietsp.Location = new System.Drawing.Point(26, 139);
            this.dgv_chitietsp.Name = "dgv_chitietsp";
            this.dgv_chitietsp.RowHeadersWidth = 51;
            this.dgv_chitietsp.Size = new System.Drawing.Size(776, 287);
            this.dgv_chitietsp.TabIndex = 0;
            this.dgv_chitietsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietsp_CellClick);
            this.dgv_chitietsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietsp_CellContentClick);
            this.dgv_chitietsp.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietsp_CellValueChanged);
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã Sản Phẩm ";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // cb_NPP
            // 
            this.cb_NPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NPP.FormattingEnabled = true;
            this.cb_NPP.Location = new System.Drawing.Point(517, 78);
            this.cb_NPP.Name = "cb_NPP";
            this.cb_NPP.Size = new System.Drawing.Size(252, 21);
            this.cb_NPP.TabIndex = 1;
            // 
            // cb_MaNT
            // 
            this.cb_MaNT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MaNT.FormattingEnabled = true;
            this.cb_MaNT.Location = new System.Drawing.Point(118, 78);
            this.cb_MaNT.Name = "cb_MaNT";
            this.cb_MaNT.Size = new System.Drawing.Size(252, 21);
            this.cb_MaNT.TabIndex = 1;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(277, 432);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(305, 20);
            this.txt_thanhtien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Nông Trại";
            // 
            // dtp_hoadon
            // 
            this.dtp_hoadon.CustomFormat = "MM/dd/yyyy";
            this.dtp_hoadon.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_hoadon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hoadon.Location = new System.Drawing.Point(517, 39);
            this.dtp_hoadon.Name = "dtp_hoadon";
            this.dtp_hoadon.Size = new System.Drawing.Size(252, 20);
            this.dtp_hoadon.TabIndex = 4;
            this.dtp_hoadon.ValueChanged += new System.EventHandler(this.dtp_hoadon_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã nhà phân phối";
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.Location = new System.Drawing.Point(118, 39);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(252, 20);
            this.txt_MaHoaDon.TabIndex = 5;
            // 
            // btn_tinhtien
            // 
            this.btn_tinhtien.Location = new System.Drawing.Point(182, 460);
            this.btn_tinhtien.Name = "btn_tinhtien";
            this.btn_tinhtien.Size = new System.Drawing.Size(75, 23);
            this.btn_tinhtien.TabIndex = 6;
            this.btn_tinhtien.Text = "Tổng tiền";
            this.btn_tinhtien.UseVisualStyleBackColor = true;
            this.btn_tinhtien.Click += new System.EventHandler(this.btn_tinhtien_Click);
            // 
            // btn_themdonhang
            // 
            this.btn_themdonhang.Location = new System.Drawing.Point(6, 432);
            this.btn_themdonhang.Name = "btn_themdonhang";
            this.btn_themdonhang.Size = new System.Drawing.Size(108, 23);
            this.btn_themdonhang.TabIndex = 7;
            this.btn_themdonhang.Text = "Thêm đơn hàng";
            this.btn_themdonhang.UseVisualStyleBackColor = true;
            this.btn_themdonhang.Click += new System.EventHandler(this.btn_themdonhang_Click);
            // 
            // tb_hoadon
            // 
            this.tb_hoadon.Controls.Add(this.ThemHoaDon);
            this.tb_hoadon.Controls.Add(this.tabPage2);
            this.tb_hoadon.Location = new System.Drawing.Point(12, 12);
            this.tb_hoadon.Name = "tb_hoadon";
            this.tb_hoadon.SelectedIndex = 0;
            this.tb_hoadon.Size = new System.Drawing.Size(850, 546);
            this.tb_hoadon.TabIndex = 8;
            // 
            // ThemHoaDon
            // 
            this.ThemHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ThemHoaDon.Controls.Add(this.btn_quaylai);
            this.ThemHoaDon.Controls.Add(this.dgv_chitietsp);
            this.ThemHoaDon.Controls.Add(this.txt_MaHoaDon);
            this.ThemHoaDon.Controls.Add(this.btn_tinhtien);
            this.ThemHoaDon.Controls.Add(this.dtp_hoadon);
            this.ThemHoaDon.Controls.Add(this.btn_themdonhang);
            this.ThemHoaDon.Controls.Add(this.label4);
            this.ThemHoaDon.Controls.Add(this.label5);
            this.ThemHoaDon.Controls.Add(this.label3);
            this.ThemHoaDon.Controls.Add(this.txt_thanhtien);
            this.ThemHoaDon.Controls.Add(this.cb_NPP);
            this.ThemHoaDon.Controls.Add(this.cb_MaNT);
            this.ThemHoaDon.Location = new System.Drawing.Point(4, 22);
            this.ThemHoaDon.Name = "ThemHoaDon";
            this.ThemHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.ThemHoaDon.Size = new System.Drawing.Size(842, 520);
            this.ThemHoaDon.TabIndex = 0;
            this.ThemHoaDon.Text = "Thêm Hóa Đơn";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.BackColor = System.Drawing.SystemColors.Control;
            this.btn_quaylai.Location = new System.Drawing.Point(630, 442);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(172, 59);
            this.btn_quaylai.TabIndex = 9;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = false;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Hóa Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Trang Trại";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.btn_XemChiTiet);
            this.tabPage2.Controls.Add(this.dgv_dsHoaDon);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách Hóa đơn";
            // 
            // btn_XemChiTiet
            // 
            this.btn_XemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemChiTiet.ForeColor = System.Drawing.Color.Maroon;
            this.btn_XemChiTiet.Location = new System.Drawing.Point(611, 485);
            this.btn_XemChiTiet.Name = "btn_XemChiTiet";
            this.btn_XemChiTiet.Size = new System.Drawing.Size(152, 31);
            this.btn_XemChiTiet.TabIndex = 1;
            this.btn_XemChiTiet.Text = "Xem Chi Tiết";
            this.btn_XemChiTiet.UseVisualStyleBackColor = true;
            this.btn_XemChiTiet.Click += new System.EventHandler(this.btn_XemChiTiet_Click);
            // 
            // dgv_dsHoaDon
            // 
            this.dgv_dsHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsHoaDon.Location = new System.Drawing.Point(20, 18);
            this.dgv_dsHoaDon.Name = "dgv_dsHoaDon";
            this.dgv_dsHoaDon.RowHeadersWidth = 51;
            this.dgv_dsHoaDon.Size = new System.Drawing.Size(768, 461);
            this.dgv_dsHoaDon.TabIndex = 0;
            this.dgv_dsHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsHoaDon_CellClick);
            this.dgv_dsHoaDon.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsHoaDon_CellValueChanged);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 570);
            this.Controls.Add(this.tb_hoadon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HoaDon";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Hoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietsp)).EndInit();
            this.tb_hoadon.ResumeLayout(false);
            this.ThemHoaDon.ResumeLayout(false);
            this.ThemHoaDon.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chitietsp;
        private System.Windows.Forms.ComboBox cb_NPP;
        private System.Windows.Forms.ComboBox cb_MaNT;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_hoadon;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaHoaDon;
        private System.Windows.Forms.Button btn_tinhtien;
        private System.Windows.Forms.Button btn_themdonhang;
        private System.Windows.Forms.TabControl tb_hoadon;
        private System.Windows.Forms.TabPage ThemHoaDon;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_dsHoaDon;
        private System.Windows.Forms.Button btn_XemChiTiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_quaylai;
    }
}