using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HIEUXE
    {
        public int MaHX { get; set; }
        public string TenHieuXe { get; set; }

        public HIEUXE()
        {
            MaHX = 0;
            TenHieuXe = string.Empty;
        }
        public HIEUXE(int MaHX, string TenHieuXe)
        {
            this.MaHX = MaHX;
            this.TenHieuXe = TenHieuXe;
        }
    }
}
