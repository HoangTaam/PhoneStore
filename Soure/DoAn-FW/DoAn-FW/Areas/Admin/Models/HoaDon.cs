using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public KhachHang KH { get; set; }
        public KhuyenMai KM { get; set; }

        public string TenKH { get; set; }
        public int TongTienTT { get; set; }
        public string DiaChiGH { get; set; }
        public DateTime NgayLapHD { get; set; }
        public int TinhTrangTT { get; set; }
        public int TinhTrangHD { get; set; }
        public int SoTienNhan { get; set; }
        public int SoTienTra { get; set; }
        public HoaDon()
        {
        }

        public HoaDon(int maHD, KhachHang kH, KhuyenMai kM, string tenKH, int tongTienTT, string diaChiGH, DateTime ngayLapHD, int tinhTrangTT, int tinhTrangHD, int soTienNhan, int soTienTra)
        {
            MaHD = maHD;
            KH = kH;
            KM = kM;
            TenKH = tenKH;
            TongTienTT = tongTienTT;
            DiaChiGH = diaChiGH;
            NgayLapHD = ngayLapHD;
            TinhTrangTT = tinhTrangTT;
            TinhTrangHD = tinhTrangHD;
            SoTienNhan = soTienNhan;
            SoTienTra = soTienTra;
        }
    }
}
