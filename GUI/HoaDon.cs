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
namespace GUI
{
    public partial class frm_HoaDon : Form
    {
        public HoaDonBUS hoadonbus = new HoaDonBUS();
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            dgv_hoadon.DataSource = hoadonbus.loadDSHoaDon();
        }
    }
}
