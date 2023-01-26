using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CHITIETTIENCONG_DAL
    {
        private static CHITIETTIENCONG_DAL instance;
        public static CHITIETTIENCONG_DAL Instance
        {
            get => instance == null ? new CHITIETTIENCONG_DAL() : instance;
            private set => instance = value;
        }

        public CHITIETTIENCONG_DAL() { }

        public DataTable LoadProblemDetail(int MaPhieuSuaChua)
        {
            string query = String.Format("SELECT TenTienCong, ChiPhi FROM TIENCONG, CHITIETTIENCONG WHERE MaPhieuSuaChua = {0} AND CHITIETTIENCONG.MaTC = TIENCONG.MaTC", MaPhieuSuaChua);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertProblem(int MaPhieuSuaChua, int MaTC)
        {
            string query = String.Format("INSERT INTO CHITIETTIENCONG (MaTC, MaPhieuSuaChua) VALUES ({0},{1})", MaTC, MaPhieuSuaChua);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool RemoveProblem(int MaChiTietTienCong)
        {
            string query = String.Format("DELETE FROM CHITIETTIENCONG WHERE MaChiTietTienCong = {0}", MaChiTietTienCong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
