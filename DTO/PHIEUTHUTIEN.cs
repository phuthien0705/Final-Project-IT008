using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PHIEUTHUTIEN
    {
        public int MaPhieuThuTien { get; set; }
        public int MaKH { get; set; }
        public int TienThu { get; set; }
        public DateTime? NgayThuTien { get; set; }

        public PHIEUTHUTIEN()
        {
            MaPhieuThuTien = 0;
            MaKH = 0;
            TienThu = 0;
            NgayThuTien = DateTime.Now;
        }

        public PHIEUTHUTIEN(int MaPhieuThuTien, int MaKH,
            int TienThu, DateTime? NgayThuTien)
        {
            this.MaPhieuThuTien = MaPhieuThuTien;
            this.MaKH = MaKH;
            this.TienThu = TienThu;
            this.NgayThuTien = NgayThuTien;
        }
    }
}
