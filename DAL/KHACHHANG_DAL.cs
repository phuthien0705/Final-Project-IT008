using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KHACHHANG_DAL
    {
        public static KHACHHANG_DAL instance;
        public static KHACHHANG_DAL Instance
        {
            get => instance == null ? new KHACHHANG_DAL() : instance;
            private set => instance = value;
        }

        public KHACHHANG_DAL() { }

        public DataTable LoadCustomerList()
        {
            string query = "SELECT * FROM dbo.KHACHHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool InsertCustomer(string HoVaTen, string SoDienThoai, string DiaChi, string GioiTinh)
        {
            // Giới tính : f là nữ, m là nam
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = String.Format("INSERT INTO KHACHHANG(TenKH,DienThoai,DiaChi,GioiTinh,NgayDangKy) VALUES('{0}','{1}','{2}','{3}','{4}')", HoVaTen, SoDienThoai, DiaChi, GioiTinh, currentTime);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCustomer(int MaKhachHang)
        {
            string query = String.Format("DELETE FROM KHACHHANG WHERE MaKH = {0}", MaKhachHang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCustomer(int MaKH, string TenKH, string DienThoai, string GioiTinh, string DiaChi)
        {
            string query = String.Format("UPDATE KHACHHANG SET TenKH = N'{0}', DienThoai = '{1}', GioiTinh = '{2}', DiaChi = N'{3}' WHERE MaKH = {4}", TenKH, DienThoai, GioiTinh, DiaChi, MaKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetCustomerDetail(int MaKH)
        {
            string query = String.Format("SELECT * FROM KHACHHANG WHERE MaKH = {0}", MaKH);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchForCustomer(string keyword)
        {
            string query = String.Format("SELECT * FROM KHACHHANG WHERE TenKH LIKE '%{0}%' OR DienThoai LIKE '%{1}%'", keyword, keyword);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
