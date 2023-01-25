using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CHITIETPHIEUSUACHUA_DAL
    {
        private static CHITIETPHIEUSUACHUA_DAL instance;
        public static CHITIETPHIEUSUACHUA_DAL Instance
        {
            get => instance == null ? new CHITIETPHIEUSUACHUA_DAL() : instance;
            private set => instance = value;
        }

        public DataTable GetKitListOfCar(int MaPhieuSuaChua)
        {
            string query = String.Format("SELECT KHO.MaPhuTung, TenVatTuPhuTung, SoLuongPhuTung, DonGia FROM KHO, CHITIETPHIEUSUACHUA WHERE KHO.MaPhuTung = CHITIETPHIEUSUACHUA.MaPhuTung AND MaPhieuSuaChua = {0}", MaPhieuSuaChua);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertKit(int MaPhieuSuaChua, int MaPhuTung, int SoLuongPhuTung)
        {
            string query = String.Format("INSERT INTO CHITIETPHIEUSUACHUA (MaPhieuSuaChua, MaPhuTung, SoLuongPhuTung) VALUES ({0},{1},{2})", MaPhieuSuaChua, MaPhuTung, SoLuongPhuTung);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteKit(int MaPhieuSuaChua, int MaPhuTung)
        {
            string query = String.Format("DELETE FROM CHITIETPHIEUSUACHUA WHERE MaPhieuSuaChua = {0} AND MaPhuTung = {1}", MaPhieuSuaChua, MaPhuTung);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateKitQuantity(int MaPhieuSuaChua, int MaPhuTung, int SoLuongPhuTung)
        {
            string query = String.Format("UPDATE CHITIETPHIEUSUACHUA SET SoLuongPhuTung = {0} WHERE MaPhieuSuaChua = {1} AND MaPhuTung = {2}", SoLuongPhuTung, MaPhieuSuaChua, MaPhuTung);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public int GetQuantityOfKit(int MaPhieuSuaChua, int MaPhuTung)
        {
            string query = String.Format("SELECT SoLuongPhuTung FROM CHITIETPHIEUSUACHUA WHERE MaPhieuSuaChua = {0} AND MaPhuTung = {1}", MaPhieuSuaChua, MaPhuTung);
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public bool AddKitQuantity(int MaPhieuSuaChua, int MaPhuTung, int SoLuongPhuTung)
        {
            int SoLuong = GetQuantityOfKit(MaPhieuSuaChua, MaPhuTung);
            return UpdateKitQuantity(MaPhieuSuaChua, MaPhuTung, SoLuongPhuTung + SoLuong);
        }

        public bool ExistKit(int MaPhieuSuaChua, int MaPhuTung)
        {
            string query = String.Format("SELECT COUNT(*) FROM CHITIETPHIEUSUACHUA WHERE MaPhieuSuaChua = {0} AND MaPhuTung = {1}", MaPhieuSuaChua, MaPhuTung);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result > 0;
        }
    }
}
