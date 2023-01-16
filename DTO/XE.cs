using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XE
    {
        public string BienSo { get; set; }
        public int MaHX { get; set; }
        public int MaKH { get; set; }
        public DateTime? NgayTiepNhan { get; set; }
        public int TrangThai { get; set; }

        public XE()
        {
            BienSo = string.Empty;
            MaHX = 0;
            MaKH = 0;
            NgayTiepNhan = DateTime.Now;
            TrangThai = 0;
        }

        public XE(string BienSo, int MaHX, int MaKH,
            DateTime? NgayTiepNhan, int TrangThai)
        {
            this.BienSo = BienSo;
            this.MaHX = MaHX;
            this.MaKH = MaKH;
            this.NgayTiepNhan = NgayTiepNhan;
            this.TrangThai = TrangThai;
        }
    }
}
