using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XE_DAL
    {
        private static XE_DAL instance;
        public static XE_DAL Instance
        {
            get => instance == null ? new XE_DAL() : instance;
            private set => instance = value;
        }

        public XE_DAL() { }

        public DataTable LoadCarList()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaXe, BienSo, TrangThai, TenKH, DienThoai, NgayTiepNhan, XE.MaHX, TenHieuXe FROM XE, HIEUXE, KHACHHANG WHERE XE.MaHX = HIEUXE.MaHX AND KHACHHANG.MaKH = XE.MaKH AND TrangThai IN (1,2,3) ORDER BY NgayTiepNhan DESC");
            return data;
        }

        public DataTable LoadCarListOnStatus(int TrangThai)
        {
            string query = String.Format("SELECT MaXe,XE.MaKH, BienSo, TenKH, DienThoai, TrangThai, NgayTiepNhan, TenHieuXe FROM XE, HIEUXE, KHACHHANG WHERE XE.MaHX = HIEUXE.MaHX AND TrangThai = {0} AND XE.MaKH = KHACHHANG.MaKH ORDER BY NgayTiepNhan DESC", TrangThai);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetCarDetail(int MaXe)
        {
            string query = String.Format("SELECT MaXe, BienSo, MaKH, TrangThai, NgayTiepNhan, TenHieuXe, XE.MaHX FROM XE, HIEUXE WHERE XE.MaHX = HIEUXE.MaHX AND MaXe = {0}", MaXe);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool InsertCar(string BienSo, int MaHX)
        {
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = String.Format("INSERT INTO XE(BienSo,MaHX,MaKH,TrangThai,NgayTiepNhan) VALUES('{0}',{1}, 1, 1, '{2}')", BienSo, MaHX, currentTime);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCar(int MaXe)
        {
            string query = String.Format("DELETE FROM XE WHERE MaXe = {0}", MaXe);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool SoftDeleteCar(int MaXe)
        {
            string query = String.Format("UPDATE XE SET TrangThai = 0 WHERE MaXe = {0}", MaXe);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCar(int MaXe, string BienSo, int MaHX, int TrangThai)
        {
            string query = String.Format("UPDATE XE SET BienSo = '{0}', MaHX = {1}, TrangThai = {2} WHERE MaXe = '{3}'", BienSo, MaHX, TrangThai, MaXe);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public int GetNumberOfTypeCar(int TrangThai)
        {
            string query = String.Format("SELECT COUNT(*) FROM XE WHERE TrangThai = {0}", TrangThai);
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public DataTable SearchForCar(string keywords)
        {
            string query = String.Format("SELECT MaXe, BienSo, TenKH, DienThoai, TrangThai, NgayTiepNhan, TenHieuXe FROM XE, HIEUXE, KHACHHANG WHERE XE.MaHX = HIEUXE.MaHX AND KHACHHANG.MaKH = XE.MaKH AND (TenHieuXe LIKE '%{0}%' OR BienSo LIKE '%{1}%' OR TenKH LIKE N'%{2}%' OR DienThoai LIKE '%{3}%') AND TrangThai IN (1,2,3) ORDER BY NgayTiepNhan DESC", keywords, keywords, keywords, keywords);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetCustomerFromCar(int MaXe)
        {
            string query = String.Format("SELECT MaKH FROM XE WHERE MaXe = {0}", MaXe);
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public bool UpdateCustomer(int MaKH, string TenKH, string DienThoai, string GioiTinh, string DiaChi)
        {
            string query = String.Format("UPDATE KHACHHANG SET TenKH = N'{0}', DienThoai = '{1}', GioiTinh = '{2}', DiaChi = N'{3}' WHERE MaKH = {4}", TenKH, DienThoai, GioiTinh, DiaChi, MaKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable LoadCustomerList()
        {
            string query = "SELECT * FROM KHACHHANG";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetCustomerDetail(int MaKH)
        {
            string query = String.Format("SELECT * FROM KHACHHANG WHERE MaKH = {0}", MaKH);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
