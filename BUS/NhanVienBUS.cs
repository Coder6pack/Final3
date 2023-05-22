using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        public NhanVienAccess nhanVienAccess = new NhanVienAccess();

        public string checkLogin(NhanVien nhanvien)
        {
            if (nhanvien.taiKhoan == "")
            {
                return "requireAccount";
            }
            if (nhanvien.matKhau == "")
            {
                return "requirePassword";
            }

            string infor = nhanVienAccess.checkLogin(nhanvien);
            return infor;
        }

        public List<NhanVien> dsNhanVien()
        {
            return nhanVienAccess.dsNhanVienDTO();
        }
    }
}
