using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    internal class DatabaseAccess
    {
        // Tạo chuỗi kết nối cơ sở dữ liệu
        public static SqlConnection Connect()
        {
            String strcon = @"Data Source=.;Initial Catalog=GarageManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn; 
        }
    }
}
