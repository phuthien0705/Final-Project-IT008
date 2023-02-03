using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KHO_DAL
    {
        private static KHO_DAL instance;

        public static KHO_DAL Instance
        {
            get { if (instance == null) { instance = new KHO_DAL(); } return KHO_DAL.instance; }
            private set { KHO_DAL.instance = value; }
        }
        public bool checkDuplicateKitName(string kitName)
        {
            try
            {
                int count = 0;
                string query = $"SELECT COUNT(*) FROM dbo.KHO WHERE TenVatTuPhuTung = N'{kitName}'";
                count = (int)DataProvider.Instance.ExecuteScalar(query);
                if (count > 0) return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
        public DataTable getAccessoryByKitName(string kitName)
        {
            string query = $"SELECT * FROM dbo.KHO WHERE TenVatTuPhuTung = N'{kitName}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        // this function is use to get accessories in stock
        public DataTable getAccessoriesInStock()
        {
            string query = "SELECT * FROM dbo.KHO";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        // this function is use to add accessory
        public void addAccessory(string TenVatTuPhuTung, int SoLuong, int DonGia)
        {
            string query = $"INSERT INTO dbo.KHO (TenVatTuPhuTung,SoLuong,DonGia) VALUES (N'{TenVatTuPhuTung}',{SoLuong},{DonGia})";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        // this function is use to delete accessory
        public void deleteAccessory(int MaPhuTung)
        {
            string query = "DELETE FROM dbo.KHO WHERE MaPhuTung=N'" + MaPhuTung + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        // this function is use to update accessory
        public void updateAccessory(int MaPhuTung, int SoLuong, int DonGia)
        {
            string query = $"UPDATE dbo.KHO SET SoLuong=N'{SoLuong}',DonGia=N'{DonGia}' WHERE MaPhuTung=N'{MaPhuTung}'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
