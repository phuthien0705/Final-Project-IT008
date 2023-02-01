using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class PHIEUSUACHUA_DAL
    {
        public static PHIEUSUACHUA_DAL instance;
        public static PHIEUSUACHUA_DAL Instance
        {
            get => instance == null ? new PHIEUSUACHUA_DAL() : instance;
            private set => instance = value;
        }

        public PHIEUSUACHUA_DAL() { }

        public DataTable GetRepairCardFromCar(int MaXe)
        {
            string query = String.Format("SELECT * FROM PHIEUSUACHUA WHERE MaXe = {0}", MaXe);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool InsertRepairCard(int MaXe, int MaKH, int TienCong, int TienPhuTung)
        {
            int tongTien = TienCong + TienPhuTung;
            string query = String.Format("INSERT INTO PHIEUSUACHUA(MaXe,MaKH,TienCong,TienPhuTung,TongTIen) VALUES({0},{1},{2},{3},{4})", MaXe, MaKH, TienCong, TienPhuTung, tongTien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteRepairCard(int MaPhieuSuaChua)
        {
            string query = String.Format("DELETE FROM PHIEUSUACHUA WHERE MaPhieuSuaChua = {0}", MaPhieuSuaChua);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCustomer(int MaPhieuSuaChua, int MaXe, int MaKH, int TienCong, int TienPhuTung)
        {
            int tongTien = TienCong + TienPhuTung;
            string query = String.Format("UPDATE PHIEUSUACHUA SET MaXe = {1}, MaKH = {2}, TienCong = {3}, TienPhuTung = {4},  TongTien = {5} WHERE MaPhieuSuaChua = {0}", MaPhieuSuaChua, MaXe, MaKH, TienCong, TienPhuTung, tongTien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
