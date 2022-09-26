using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class HoaDonEditModel
    {
        public HoaDonEditModel()
        {
        }

        public int MaHD { get; set; }
        public List<KhachHang> KH { get; set; }
        public List<KhuyenMai> KM { get; set; }
        public int MaKH { get; set; }
        public int MaKM { get; set; }
        public int TinhTrangHD { get; set; }
        public string DiaChiGH { get; set; }
        public int TongTienTT { get; set; }
        public DateTime NgayLapHD { get; set; }
        public int TinhTrangTT { get; set; }
        public int SoTienNhan { get; set; }
        public int SoTienTra { get; set; }

        public HoaDonEditModel(int maHD, List<KhachHang> kH, List<KhuyenMai> kM, int maKH, int maKM, int tinhTrangHD, string diaChiGH, int tongTienTT, DateTime ngayLapHD, int tinhTrangTT, int soTienNhan, int soTienTra)
        {
            MaHD = maHD;
            KH = kH;
            KM = kM;
            MaKH = maKH;
            MaKM = maKM;
            TinhTrangHD = tinhTrangHD;
            DiaChiGH = diaChiGH;
            TongTienTT = tongTienTT;
            NgayLapHD = ngayLapHD;
            TinhTrangTT = tinhTrangTT;
            SoTienNhan = soTienNhan;
            SoTienTra = soTienTra;
        }
    }
}
