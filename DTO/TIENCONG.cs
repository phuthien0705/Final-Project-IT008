using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TIENCONG
    {
        public int MaTC { get; set; }
        public string TenTienCong { get; set; }
        public int ChiPhi { get; set; }

        public TIENCONG()
        {
            MaTC = 0;
            TenTienCong = string.Empty;
            ChiPhi = 0;
        }

        public TIENCONG(int MaTC, string TenTienCong,
            int ChiPhi)
        {
            this.MaTC = MaTC;
            this.TenTienCong = TenTienCong;
            this.ChiPhi = ChiPhi;
        }
    }
}
