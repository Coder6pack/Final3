using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CT_Luong : DBAccess
    {
        public List<CT_LuongDTO> loadDSLuong()
        {
            List<CT_LuongDTO> dsLuong = loadCT_LuongDTO();
            return dsLuong;
        }
    }
}
