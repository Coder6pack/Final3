﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace Final3
{
    public partial class frm_quanLyTraiCay : Form
    {
        public frm_quanLyTraiCay()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
        public lo_TraiCayBUS lo_traicaybus = new lo_TraiCayBUS();
        private void frm_quanLyTraiCay_Load(object sender, EventArgs e)
        {
            dgv_lohang.DataSource = lo_traicaybus.loadlo_TraiCay();
        }

        private void btn_them_lohang_Click(object sender, EventArgs e)
        {
            lo_TraiCayDTO lo_traicays = new lo_TraiCayDTO();
            lo_traicays.ngayNhap = DateTime.Parse(datetime_lohang.Text);
            if (lo_traicaybus.Themlo_TraiCay(lo_traicays))
            {
                MessageBox.Show("Thêm lô hàng thành công");
                lo_traicaybus.loadlo_TraiCay();
                dgv_lohang.DataSource = lo_traicaybus.loadlo_TraiCay();
            }
            {
                MessageBox.Show("Thêm lô hàng thất bại");
            }
        }

        private void dgv_lohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {
                DataGridViewRow row = dgv_lohang.Rows[e.RowIndex];
                txt_malohang.Text = row.Cells["MaLoTraiCay"].Value.ToString();
                datetime_lohang.Text = row.Cells["NgayNhap"].Value.ToString();
            }    
        }

        private void btn_xoa_lohang_Click(object sender, EventArgs e)
        {
            int malohang = int.Parse(txt_malohang.Text);
            if (lo_traicaybus.Xoalo_TraiCay(malohang))
            {
                MessageBox.Show("Xóa lo hàng thành công");
                lo_traicaybus.loadlo_TraiCay();
                dgv_lohang.DataSource = lo_traicaybus.loadlo_TraiCay();
            }
            else
            {
                MessageBox.Show("Xóa lô hàng thất bại");
            }
        }

        private void btn_capnhat_lohang_Click(object sender, EventArgs e)
        {
            lo_TraiCayDTO lo_traicays = new lo_TraiCayDTO();
            lo_traicays.id = int.Parse(txt_malohang.Text);
            lo_traicays.ngayNhap = datetime_lohang.Value;
            if (lo_traicaybus.CapNhatlo_TraiCay(lo_traicays))
            {
                MessageBox.Show("Cập Nhật lô hàng thành công");
                lo_traicaybus.loadlo_TraiCay();
                dgv_lohang.DataSource = lo_traicaybus.loadlo_TraiCay();
            }
            else
            {
                MessageBox.Show("Cập nhật lô hàng thất bại");
            }
        }

        private void btn_timkiem_lohang_Click(object sender, EventArgs e)
        {
           int maso = int.Parse(txt_matimkiem.Text);
            dgv_lohang.DataSource = lo_traicaybus.TimkiemloTraiCay(maso);
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
