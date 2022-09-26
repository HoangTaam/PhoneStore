using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class GiaoHang
    {
        public GiaoHang()
        {
        }

        public GiaoHang(int maHD, string diaChiGH, int maNV, string tenNV, string sDT, int tinhTrangGH)
        {
            MaHD = maHD;
            DiaChiGH = diaChiGH;
            MaNV = maNV;
            TenNV = tenNV;
            SDT = sDT;
            TinhTrangGH = tinhTrangGH;
        }

        public int MaHD { get; set; }
        public string DiaChiGH { get; set; }
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public int TinhTrangGH { get; set; }

    }
}
