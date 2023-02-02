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

        public bool InsertCustomer(string HoVaTen, string SoDienThoai, string DiaChi, int GioiTinh)
        {
            // Giới tính : 0 là nữ, 1 là nam
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = String.Format("INSERT INTO KHACHHANG(TenKH,DienThoai,DiaChi,GioiTinh,NgayDangKy) VALUES('{0}','{1}','{2}',{3},'{4}')", HoVaTen, SoDienThoai, DiaChi, GioiTinh, currentTime);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCustomer(int MaKhachHang)
        {
            string query = String.Format("DELETE FROM KHACHHANG WHERE MaKH = {0}", MaKhachHang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCustomer(int MaKhachHang, string HoVaTen, string SoDienThoai, string DiaChi, int GioiTinh)
        {
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = String.Format("UPDATE KHACHHANG SET TenKH = '{0}', DienThoai = '{1}', DiaChi = '{2}', GioiTinh = {3}, NgayDangKy = '{4}'  WHERE MaKH = {5}", HoVaTen, SoDienThoai, DiaChi, GioiTinh, currentTime, MaKhachHang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
