﻿namespace GUI
{
    partial class frm_gioHang
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
            this.dgv_dsTraiCay = new System.Windows.Forms.DataGridView();
            this.maTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_dsDonHang = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.nud_soLuong = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_lo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ptb_anhTraiCay = new System.Windows.Forms.PictureBox();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HSD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_maTraiCay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenTraiCay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kiemTra = new System.Windows.Forms.Button();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.lb_tongGia = new System.Windows.Forms.Label();
            this.lb_thue = new System.Windows.Forms.Label();
            this.lb_giamGia = new System.Windows.Forms.Label();
            this.lb_tamTinh = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsTraiCay)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhTraiCay)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_dsTraiCay
            // 
            this.dgv_dsTraiCay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsTraiCay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.dgv_dsTraiCay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsTraiCay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTC,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dgv_dsTraiCay.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_dsTraiCay.Location = new System.Drawing.Point(0, 0);
            this.dgv_dsTraiCay.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_dsTraiCay.Name = "dgv_dsTraiCay";
            this.dgv_dsTraiCay.ReadOnly = true;
            this.dgv_dsTraiCay.RowHeadersWidth = 82;
            this.dgv_dsTraiCay.RowTemplate.Height = 33;
            this.dgv_dsTraiCay.Size = new System.Drawing.Size(797, 719);
            this.dgv_dsTraiCay.TabIndex = 1;
            // 
            // maTC
            // 
            this.maTC.HeaderText = "Mã Trái Cây";
            this.maTC.MinimumWidth = 10;
            this.maTC.Name = "maTC";
            this.maTC.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Trái Cây";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hạn Sử Dụng";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_dsDonHang);
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Controls.Add(this.nud_soLuong);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_lo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.ptb_anhTraiCay);
            this.panel3.Controls.Add(this.txt_donGia);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_HSD);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_maTraiCay);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_tenTraiCay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btn_kiemTra);
            this.panel3.Controls.Add(this.txt_tenKH);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_sdt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.panel3.Location = new System.Drawing.Point(801, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 719);
            this.panel3.TabIndex = 5;
            // 
            // dgv_dsDonHang
            // 
            this.dgv_dsDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsDonHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.dgv_dsDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.dgv_dsDonHang.Location = new System.Drawing.Point(2, 305);
            this.dgv_dsDonHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_dsDonHang.Name = "dgv_dsDonHang";
            this.dgv_dsDonHang.RowHeadersWidth = 82;
            this.dgv_dsDonHang.RowTemplate.Height = 33;
            this.dgv_dsDonHang.Size = new System.Drawing.Size(565, 221);
            this.dgv_dsDonHang.TabIndex = 35;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Mã trái cây";
            this.Column11.MinimumWidth = 10;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Tên trái cây";
            this.Column12.MinimumWidth = 10;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Loại";
            this.Column13.MinimumWidth = 10;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Lô";
            this.Column14.MinimumWidth = 10;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Hạn sử dụng";
            this.Column15.MinimumWidth = 10;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Giá";
            this.Column16.MinimumWidth = 10;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Số lượng";
            this.Column17.MinimumWidth = 10;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(87, 234);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(96, 34);
            this.btn_them.TabIndex = 33;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(199, 234);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(96, 34);
            this.btn_xoa.TabIndex = 32;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // nud_soLuong
            // 
            this.nud_soLuong.Location = new System.Drawing.Point(477, 118);
            this.nud_soLuong.Margin = new System.Windows.Forms.Padding(2);
            this.nud_soLuong.Name = "nud_soLuong";
            this.nud_soLuong.Size = new System.Drawing.Size(70, 20);
            this.nud_soLuong.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Số lượng:";
            // 
            // txt_lo
            // 
            this.txt_lo.Location = new System.Drawing.Point(355, 118);
            this.txt_lo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_lo.Multiline = true;
            this.txt_lo.Name = "txt_lo";
            this.txt_lo.Size = new System.Drawing.Size(46, 18);
            this.txt_lo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Lô:";
            // 
            // ptb_anhTraiCay
            // 
            this.ptb_anhTraiCay.Location = new System.Drawing.Point(406, 145);
            this.ptb_anhTraiCay.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_anhTraiCay.Name = "ptb_anhTraiCay";
            this.ptb_anhTraiCay.Size = new System.Drawing.Size(152, 132);
            this.ptb_anhTraiCay.TabIndex = 28;
            this.ptb_anhTraiCay.TabStop = false;
            // 
            // txt_donGia
            // 
            this.txt_donGia.Location = new System.Drawing.Point(148, 160);
            this.txt_donGia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_donGia.Multiline = true;
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(147, 18);
            this.txt_donGia.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Đơn giá:";
            // 
            // txt_HSD
            // 
            this.txt_HSD.Location = new System.Drawing.Point(413, 80);
            this.txt_HSD.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HSD.Multiline = true;
            this.txt_HSD.Name = "txt_HSD";
            this.txt_HSD.Size = new System.Drawing.Size(147, 18);
            this.txt_HSD.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Hạn sử dụng:";
            // 
            // txt_maTraiCay
            // 
            this.txt_maTraiCay.Location = new System.Drawing.Point(148, 118);
            this.txt_maTraiCay.Margin = new System.Windows.Forms.Padding(2);
            this.txt_maTraiCay.Multiline = true;
            this.txt_maTraiCay.Name = "txt_maTraiCay";
            this.txt_maTraiCay.Size = new System.Drawing.Size(147, 18);
            this.txt_maTraiCay.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã trái cây:";
            // 
            // txt_tenTraiCay
            // 
            this.txt_tenTraiCay.Location = new System.Drawing.Point(148, 81);
            this.txt_tenTraiCay.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenTraiCay.Multiline = true;
            this.txt_tenTraiCay.Name = "txt_tenTraiCay";
            this.txt_tenTraiCay.Size = new System.Drawing.Size(147, 18);
            this.txt_tenTraiCay.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên trái cây:";
            // 
            // btn_kiemTra
            // 
            this.btn_kiemTra.AutoSize = true;
            this.btn_kiemTra.Location = new System.Drawing.Point(462, 49);
            this.btn_kiemTra.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kiemTra.Name = "btn_kiemTra";
            this.btn_kiemTra.Size = new System.Drawing.Size(96, 23);
            this.btn_kiemTra.TabIndex = 9;
            this.btn_kiemTra.Text = "Kiểm tra";
            this.btn_kiemTra.UseVisualStyleBackColor = true;
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Location = new System.Drawing.Point(382, 29);
            this.txt_tenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenKH.Multiline = true;
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(179, 18);
            this.txt_tenKH.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên KH";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(148, 29);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(147, 18);
            this.txt_sdt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số điện thoại:";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.btn_thanhToan);
            this.panel6.Controls.Add(this.lb_tongGia);
            this.panel6.Controls.Add(this.lb_thue);
            this.panel6.Controls.Add(this.lb_giamGia);
            this.panel6.Controls.Add(this.lb_tamTinh);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(2, 530);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(664, 189);
            this.panel6.TabIndex = 3;
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.Location = new System.Drawing.Point(469, 144);
            this.btn_thanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(96, 34);
            this.btn_thanhToan.TabIndex = 19;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.UseVisualStyleBackColor = true;
            // 
            // lb_tongGia
            // 
            this.lb_tongGia.AutoSize = true;
            this.lb_tongGia.Location = new System.Drawing.Point(360, 121);
            this.lb_tongGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tongGia.Name = "lb_tongGia";
            this.lb_tongGia.Size = new System.Drawing.Size(61, 13);
            this.lb_tongGia.TabIndex = 26;
            this.lb_tongGia.Text = "Tổng giá:";
            // 
            // lb_thue
            // 
            this.lb_thue.AutoSize = true;
            this.lb_thue.Location = new System.Drawing.Point(381, 96);
            this.lb_thue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thue.Name = "lb_thue";
            this.lb_thue.Size = new System.Drawing.Size(40, 13);
            this.lb_thue.TabIndex = 25;
            this.lb_thue.Text = "Thuế:";
            // 
            // lb_giamGia
            // 
            this.lb_giamGia.AutoSize = true;
            this.lb_giamGia.Location = new System.Drawing.Point(357, 69);
            this.lb_giamGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_giamGia.Name = "lb_giamGia";
            this.lb_giamGia.Size = new System.Drawing.Size(62, 13);
            this.lb_giamGia.TabIndex = 24;
            this.lb_giamGia.Text = "Giảm Giá:";
            // 
            // lb_tamTinh
            // 
            this.lb_tamTinh.AutoSize = true;
            this.lb_tamTinh.Location = new System.Drawing.Point(360, 45);
            this.lb_tamTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tamTinh.Name = "lb_tamTinh";
            this.lb_tamTinh.Size = new System.Drawing.Size(62, 13);
            this.lb_tamTinh.TabIndex = 23;
            this.lb_tamTinh.Text = "Tạm tính:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 121);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Tổng giá:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Thuế:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Giảm Giá:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tạm tính:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 12);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày:";
            // 
            // frm_gioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1370, 719);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_dsTraiCay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_gioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GioHang";
            this.Load += new System.EventHandler(this.GioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsTraiCay)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhTraiCay)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dsTraiCay;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_dsDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.NumericUpDown nud_soLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_lo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ptb_anhTraiCay;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_maTraiCay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenTraiCay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kiemTra;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.Label lb_tongGia;
        private System.Windows.Forms.Label lb_thue;
        private System.Windows.Forms.Label lb_giamGia;
        private System.Windows.Forms.Label lb_tamTinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
    }
}