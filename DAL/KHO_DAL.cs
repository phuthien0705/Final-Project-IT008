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
        public DataTable getKitDetailOnKitIndex(int MaPhuTung)
        {
            string query = String.Format("SELECT * FROM KHO WHERE MaPhuTung = {0}", MaPhuTung);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        // this function is use to get accessories in stock
        public DataTable getAccessoriesInStock()
        {
            string query = "SELECT * FROM dbo.KHO WHERE SoLuong > 0";
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
        public bool deleteAccessory(int MaPhuTung)
        {
            string query = String.Format("DELETE FROM KHO WHERE MaPhuTung = {0}", MaPhuTung);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // this function is use to update accessory
        public void updateAccessory(int MaPhuTung, int SoLuong, int DonGia)
        {
            string query = $"UPDATE dbo.KHO SET SoLuong=N'{SoLuong}',DonGia=N'{DonGia}' WHERE MaPhuTung=N'{MaPhuTung}'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool UpdateKitAvailableQuantityAfterChoosing(int MaPhuTung, int SoLuong) 
        {
            string query = String.Format("UPDATE KHO SET SoLuong = {0} WHERE MaPhuTung = {1}", SoLuong, MaPhuTung);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
