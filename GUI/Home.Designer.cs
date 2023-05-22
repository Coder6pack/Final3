namespace Final3
{
    partial class frm_home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.btn_thongKe = new System.Windows.Forms.Button();
            this.btn_kho = new System.Windows.Forms.Button();
            this.btn_hoaDon = new System.Windows.Forms.Button();
            this.btn_nhanVien = new System.Windows.Forms.Button();
            this.btn_gioHang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_body = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_dangXuat);
            this.panel1.Controls.Add(this.btn_thongKe);
            this.panel1.Controls.Add(this.btn_kho);
            this.panel1.Controls.Add(this.btn_hoaDon);
            this.panel1.Controls.Add(this.btn_nhanVien);
            this.panel1.Controls.Add(this.btn_gioHang);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 1405);
            this.panel1.TabIndex = 2;
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.Location = new System.Drawing.Point(3, 1045);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Size = new System.Drawing.Size(294, 125);
            this.btn_dangXuat.TabIndex = 6;
            this.btn_dangXuat.Text = "Đăng xuất";
            this.btn_dangXuat.UseVisualStyleBackColor = true;
            // 
            // btn_thongKe
            // 
            this.btn_thongKe.Location = new System.Drawing.Point(3, 914);
            this.btn_thongKe.Name = "btn_thongKe";
            this.btn_thongKe.Size = new System.Drawing.Size(294, 125);
            this.btn_thongKe.TabIndex = 5;
            this.btn_thongKe.Text = "THỐNG KÊ";
            this.btn_thongKe.UseVisualStyleBackColor = true;
            // 
            // btn_kho
            // 
            this.btn_kho.Location = new System.Drawing.Point(3, 783);
            this.btn_kho.Name = "btn_kho";
            this.btn_kho.Size = new System.Drawing.Size(294, 125);
            this.btn_kho.TabIndex = 4;
            this.btn_kho.Text = "KHO";
            this.btn_kho.UseVisualStyleBackColor = true;
            this.btn_kho.Click += new System.EventHandler(this.btn_kho_Click);
            // 
            // btn_hoaDon
            // 
            this.btn_hoaDon.Location = new System.Drawing.Point(3, 652);
            this.btn_hoaDon.Name = "btn_hoaDon";
            this.btn_hoaDon.Size = new System.Drawing.Size(294, 125);
            this.btn_hoaDon.TabIndex = 3;
            this.btn_hoaDon.Text = "HOÁ ĐƠN";
            this.btn_hoaDon.UseVisualStyleBackColor = true;
            this.btn_hoaDon.Click += new System.EventHandler(this.btn_hoaDon_Click);
            // 
            // btn_nhanVien
            // 
            this.btn_nhanVien.Location = new System.Drawing.Point(3, 521);
            this.btn_nhanVien.Name = "btn_nhanVien";
            this.btn_nhanVien.Size = new System.Drawing.Size(294, 125);
            this.btn_nhanVien.TabIndex = 2;
            this.btn_nhanVien.Text = "NHÂN VIÊN";
            this.btn_nhanVien.UseVisualStyleBackColor = true;
            this.btn_nhanVien.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_gioHang
            // 
            this.btn_gioHang.Location = new System.Drawing.Point(3, 390);
            this.btn_gioHang.Name = "btn_gioHang";
            this.btn_gioHang.Size = new System.Drawing.Size(294, 125);
            this.btn_gioHang.TabIndex = 1;
            this.btn_gioHang.Text = "GIỎ HÀNG";
            this.btn_gioHang.UseVisualStyleBackColor = true;
            this.btn_gioHang.Click += new System.EventHandler(this.btn_gioHang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 211);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pn_body
            // 
            this.pn_body.AutoSize = true;
            this.pn_body.Location = new System.Drawing.Point(315, 15);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(1920, 1402);
            this.pn_body.TabIndex = 3;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2252, 1434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_body);
            this.Name = "frm_home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dangXuat;
        private System.Windows.Forms.Button btn_thongKe;
        private System.Windows.Forms.Button btn_kho;
        private System.Windows.Forms.Button btn_hoaDon;
        private System.Windows.Forms.Button btn_nhanVien;
        private System.Windows.Forms.Button btn_gioHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_body;
    }
}