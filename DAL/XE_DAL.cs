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
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaXe, BienSo, TrangThai, NgayTiepNhan, TenHieuXe FROM XE, HIEUXE WHERE XE.MaHX = HIEUXE.MaHX ORDER BY NgayTiepNhan DESC");
            return data;
        }

        public DataTable LoadCarListOnStatus(int TrangThai)
        {
            string query = String.Format("SELECT MaXe, BienSo, TrangThai, NgayTiepNhan, TenHieuXe FROM XE, HIEUXE WHERE XE.MaHX = HIEUXE.MaHX AND TrangThai = {0} ORDER BY NgayTiepNhan DESC", TrangThai);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetCarDetail(int MaXe)
        {
            string query = String.Format("SELECT MaXe, BienSo, TrangThai, NgayTiepNhan, TenHieuXe FROM XE, HIEUXE WHERE XE.MaHX = HIEUXE.MaHX AND MaXe = {0}", MaXe);
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
    }
}
