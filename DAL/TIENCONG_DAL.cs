using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class TIENCONG_DAL
    {
        private static TIENCONG_DAL instance;
        public static TIENCONG_DAL Instance
        {
            get => instance == null ? new TIENCONG_DAL() : instance;
            private set => instance = value;
        }

        public TIENCONG_DAL() { }

        public DataTable LoadProblemList()
        {
            string query = "SELECT * FROM TIENCONG";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
