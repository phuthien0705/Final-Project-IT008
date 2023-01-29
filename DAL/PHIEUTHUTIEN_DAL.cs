using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PHIEUTHUTIEN_DAL
    {
        private static PHIEUTHUTIEN_DAL instance;

        public static PHIEUTHUTIEN_DAL Instance
        {
            get { if (instance == null) { instance = new PHIEUTHUTIEN_DAL(); } return PHIEUTHUTIEN_DAL.instance; }
            private set { PHIEUTHUTIEN_DAL.instance = value; }
        }
        // this function is use to get list bill by user id
        public DataTable getListBillByUserId(int MaKH) {
            string query = $"SELECT * FROM dbo.PHIEUTHUTIEN WHERE MaKh=N'{MaKH}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        // this function is use to acc bill
        public void addBill(int MaPhieuThuTien, int MaKH,
            int TienThu, DateTime? NgayThuTien)
        {
            string query = $"INSERT dbo.KHO (MaPhieuThuTien,MaKH,TienThu,NgayThuTien) VALUES (N'{MaPhieuThuTien}',N'{MaKH}',N'{TienThu}',N'{NgayThuTien}')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
