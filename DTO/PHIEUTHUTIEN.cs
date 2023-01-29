using System;
using System.Collections.Generic;
using System.Data;
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

        public PHIEUTHUTIEN(DataRow row)
        {
            this.MaPhieuThuTien = (int)row["MaPhieuThuTien"];
            this.MaKH = (int)row["MaKH"];
            this.TienThu = (int)row["TienThu"];
            this.NgayThuTien = (DateTime)row["NgayThuTien"];
        }
    }
}
