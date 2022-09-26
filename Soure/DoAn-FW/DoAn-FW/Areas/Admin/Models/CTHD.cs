using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class CTHD
    {
        public CTHD()
        {
        }

        public CTHD(int maHD, int maSP, int soLuong, string tenSP, int thanhTien)
        {
            MaHD = maHD;
            MaSP = maSP;
            SoLuong = soLuong;
            TenSP = tenSP;
            ThanhTien = thanhTien;
        }

        public int MaHD { get; set; }

        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public string TenSP { get; set; }
        public int ThanhTien { get; set; }

    }
}
