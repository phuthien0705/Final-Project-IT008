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

        public static KHO_DAL Instance {
            get { if (instance == null) { instance = new KHO_DAL(); } return KHO_DAL.instance; }
            private set { KHO_DAL.instance = value; }
        }

        // this function is use to get accessories in stock
        public DataTable getAccessoriesInStock()
        {
            string query = "SELECT * FROM dbo.KHO";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        // this function is use to add accessory
        public void addAccessory(int MaPhuTung, string TenVatTuPhuTung,
            int SoLuong, int DonGia)
        {
            string query = $"INSERT dbo.KHO (MaPhuTung,TenVatTuPhuTung,SoLuong,DonGia) VALUES (N'{MaPhuTung}',N'{TenVatTuPhuTung}',N'{SoLuong}',N'{DonGia}')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        // this function is use to delete accessory
        public void deleteAccessory(int MaPhuTung)
        {
            string query = "DELETE FROM dbo.KHO WHERE MaPhuTung=N'" + MaPhuTung+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        // this function is use to update accessory
        public void updateAccessory(int MaPhuTung, string TenVatTuPhuTung,
            int SoLuong, int DonGia)
        {
            string query = $"UPDATE dbo.KHO SET TenVatTuPhuTung=N'{TenVatTuPhuTung}',SoLuong=N'{SoLuong}',DonGia=N'{DonGia}' WHERE MaPhuTung=N'{MaPhuTung}'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
