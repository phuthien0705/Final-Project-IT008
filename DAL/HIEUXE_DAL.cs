using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class HIEUXE_DAL
    {
        private static HIEUXE_DAL instance;
        public static HIEUXE_DAL Instance
        {
            get => instance == null ? new HIEUXE_DAL() : instance;
            private set => instance = value;
        }

        public HIEUXE_DAL() { }

        public DataTable LoadBrandList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM HIEUXE");
        }
    }
}
