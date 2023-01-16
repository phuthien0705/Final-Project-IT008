using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHITIETTIENCONG
    {
        public int MaChiTietTienCong { get; set; }
        public int MaPhieuSuaChua { get; set; }
        public int MaTC { get; set; }

        public CHITIETTIENCONG()
        {
            MaChiTietTienCong = 0;
            MaPhieuSuaChua = 0;
            MaTC = 0;
        }

        public CHITIETTIENCONG(int MaChiTietTienCong, int MaPhieuSuaChua,
            int MaTC)
        {
            this.MaChiTietTienCong = MaChiTietTienCong;
            this.MaPhieuSuaChua = MaPhieuSuaChua;
            this.MaTC = MaTC;
        }
    }
}
