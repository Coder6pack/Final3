using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class sqlConnecTionData
    {
        public static SqlConnection connect()
        {
            string strcon = "Data Source=localhost;Initial Catalog=quan_trai_cay;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class DBAccess
    {
        public string checkLoginDTO(NhanVien nhanvien)
        {
            string user = null;

            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from nhanVien where taiKhoan = @taikhoan and matKhau = @matkhau", conn);
            command.Parameters.AddWithValue("@taikhoan", nhanvien.taiKhoan);
            command.Parameters.AddWithValue("@matkhau", nhanvien.matKhau);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetInt32(0).ToString();
                    return user;
                }
                reader.Close();
                conn.Close();

            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác";
            }

            return user;
        }

        public List<NhanVien> dsNhanVienDTO()
        {
            List<NhanVien> dsnv = new List<NhanVien>();
            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();

            SqlCommand command = new SqlCommand("Select * from NhanVien", conn);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    NhanVien nhanvien = new NhanVien();
                    nhanvien.id = reader.GetInt32(0);
                    nhanvien.tenNhanVien = reader.GetString(1);
                    nhanvien.taiKhoan = reader.GetString(2);
                    nhanvien.matKhau = reader.GetString(3);
                    nhanvien.quyen = reader.GetString(4);
                    nhanvien.ngaySinh = reader.GetDateTime(5);
                    nhanvien.gioiTinh = reader.GetString(6);
                    nhanvien.sdt = reader.GetString(7);
                    nhanvien.diaChi = reader.GetString(8);
                    nhanvien.trangThai = reader.GetInt32(9);
                    dsnv.Add(nhanvien);

                }
            }

            return dsnv;
        }

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
