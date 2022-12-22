using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHO
    {
        public int MaPhuTung { get; set; }
        public string TenVatTuPhuTung { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        public KHO()
        {
            MaPhuTung = 0;
            TenVatTuPhuTung = string.Empty;
            SoLuong = 0;
            DonGia = 0;
        }

        public KHO(int MaPhuTung, string TenVatTuPhuTung,
            int SoLuong, int DonGia)
        {
            this.MaPhuTung = MaPhuTung;
            this.TenVatTuPhuTung = TenVatTuPhuTung;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
        }
    }
}
