﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CT_LuongBUS
    {
        public CT_Luong ctLuong = new CT_Luong();
        public List<CT_LuongDTO> loadDSLuong()
        {
            return ctLuong.loadCT_LuongDTO();
        }

        public List<CT_LuongDTO> timKiemCT_Luong(string tenid)
        {
            return ctLuong.timKiemCTLuong(tenid);
        }
    }
}
