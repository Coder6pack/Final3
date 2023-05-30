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
}
