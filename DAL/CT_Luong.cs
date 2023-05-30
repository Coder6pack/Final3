using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CT_Luong 
    {
        public List<CT_LuongDTO> loadCT_LuongDTO()
        {
            List<CT_LuongDTO> ctluong = new List<CT_LuongDTO>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from CT_Luong", conn);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CT_LuongDTO ct_luong = new CT_LuongDTO();
                    ct_luong.id = reader.GetInt32(0);
                    ct_luong.nhanVien_id = reader.GetInt32(1);
                    ct_luong.luong = reader.GetSqlMoney(2);
                    ct_luong.gioDangNhap = reader.GetInt32(3);
                    ct_luong.thang_Nam = reader.GetString(4);
                    ct_luong.tongLuong = reader.GetDecimal(5);
                    ctluong.Add(ct_luong);
                }

            }

            return ctluong;
        }
    }
}
