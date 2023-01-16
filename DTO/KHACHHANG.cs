using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHACHHANG
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }

        public KHACHHANG()
        {
            MaKH = 0;
            TenKH = string.Empty;
            DienThoai = string.Empty;
            DiaChi = string.Empty;
        }

        public KHACHHANG(int MaKH, string TenKH, string DienThoai
            , string DiaChi)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.DiaChi = DiaChi;
            this.DienThoai = DienThoai;
        }
    }
}
