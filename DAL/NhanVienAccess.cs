using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienAccess : DBAccess
    {
        public string checkLogin(NhanVien nhanvien)
        {
            string infor = checkLoginDTO(nhanvien);
            return infor;
        }

        public List<NhanVien> dsNhanVien()
        {
            List<NhanVien> nhanviens = dsNhanVienDTO();
            return nhanviens;
        }
    }
}
