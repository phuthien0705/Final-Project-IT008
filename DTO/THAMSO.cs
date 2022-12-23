using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class THAMSO
    {
        public string MaThamSo { get; set; }
        public string TenThamSo { get; set; }
        public int GiaTri { get; set; }


        public THAMSO()
        {
            MaThamSo = string.Empty;
            TenThamSo = string.Empty;
            GiaTri = 0;
        }

        public THAMSO(string MaThamSo,
            string TenThamSo, int GiaTri)
        {
            this.MaThamSo = MaThamSo;
            this.TenThamSo = TenThamSo;
            this.GiaTri = GiaTri;
        }
    }
}
