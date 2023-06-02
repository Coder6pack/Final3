using System;
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
    public partial class frm_nhanVien : Form
    {
        public NhanVienBUS nhanvienBUS = new NhanVienBUS();
        public CT_LuongBUS ctLuongBUS = new CT_LuongBUS();
        public frm_nhanVien()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_nhanVien_Load(object sender, EventArgs e)
        {
            dgv_nhanVien.DataSource = nhanvienBUS.dsNhanVien();
            dgv_ctLuong.DataSource = ctLuongBUS.loadDSLuong();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_nhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
