using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHITIETPHIEUSUACHUA
    {
        public int MaPhieuSuaChua { get; set; }
        public int MaPhuTung { get; set; }
        public int SoLuongPhuTung { get; set; }
        public int MaChiTietPhieuSuaChua { get; set; }

        public CHITIETPHIEUSUACHUA()
        {
            MaChiTietPhieuSuaChua = 0;
            MaPhuTung = 0;
            SoLuongPhuTung = 0;
            MaPhieuSuaChua = 0;
        }
        public CHITIETPHIEUSUACHUA(int MaPhieuSuaChua, int MaPhuTung,
            int SoLuongPhuTung, int MaChiTietPhieuSuaChua)
        {
            this.MaPhieuSuaChua = MaPhieuSuaChua;
            this.MaPhuTung = MaPhuTung;
            this.SoLuongPhuTung = SoLuongPhuTung;
            this.MaChiTietPhieuSuaChua = MaChiTietPhieuSuaChua;
        }
    }
}
