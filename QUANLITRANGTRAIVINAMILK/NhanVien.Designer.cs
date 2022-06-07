
namespace QUANLITRANGTRAIVINAMILK
{
    partial class NhanVien
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
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.TenNV = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_GT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(24, 94);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_NhanVien.Size = new System.Drawing.Size(738, 403);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellContentClick);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.BackColor = System.Drawing.Color.Chocolate;
            this.btn_quaylai.Location = new System.Drawing.Point(682, 534);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(128, 44);
            this.btn_quaylai.TabIndex = 1;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = false;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(370, 525);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(111, 43);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(31, 24);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(126, 20);
            this.txt_MaNV.TabIndex = 3;
            // 
            // TenNV
            // 
            this.TenNV.Location = new System.Drawing.Point(31, 59);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(126, 20);
            this.TenNV.TabIndex = 3;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(210, 24);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(126, 20);
            this.txt_SDT.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(370, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txt_GT
            // 
            this.txt_GT.Location = new System.Drawing.Point(210, 59);
            this.txt_GT.Name = "txt_GT";
            this.txt_GT.Size = new System.Drawing.Size(126, 20);
            this.txt_GT.TabIndex = 3;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 589);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_GT);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.TenNV);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.dgv_NhanVien);
            this.Name = "NhanVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox TenNV;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_GT;
    }
}