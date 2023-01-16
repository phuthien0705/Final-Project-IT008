using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PHIEUSUACHUA
    {
        public int MaPhieuSuaChua { get; set; }
        public string BienSo { get; set; }
        public int MaKH { get; set; }
        public int TienCong { get; set; }
        public int TienPhuTung { get; set; }
        public int TongTien { get; set; }


        public PHIEUSUACHUA()
        {
            MaPhieuSuaChua = 0;
            BienSo = string.Empty;
            MaKH = 0;
            TienCong = 0;
            TienPhuTung = 0;
            TongTien = 0;
        }


        public PHIEUSUACHUA(int MaPhieuSuaChua, string BienSo,
           int MaKH, int TienCong, int TienPhuTung, int TongTien)
        {
            this.MaPhieuSuaChua = MaPhieuSuaChua;
            this.BienSo = BienSo;
            this.MaKH = MaKH;
            this.TienPhuTung = TienPhuTung;
            this.TienCong = TienCong;
            this.TongTien = TongTien;
        }
    }
}
