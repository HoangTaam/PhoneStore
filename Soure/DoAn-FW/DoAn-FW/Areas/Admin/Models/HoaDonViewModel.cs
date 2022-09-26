using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class HoaDonViewModel
    {
        public HoaDonViewModel()
        {
        }

        public int MaHD { get; set; }
        public String TenKH { get; set; }
        public int MaKM { get; set; }
        public int TongTienTT { get; set; }
        public string DiaChiGH { get; set; }
        public DateTime NgayLapHD { get; set; }
        public int TinhTrangHD { get; set; }
        public int TinhTrangTT { get; set; }
        public int SoTienNhan { get; set; }
        public int SoTienTra { get; set; }

        public HoaDonViewModel(int maHD, string tenKH, int maKM, int tongTienTT, string diaChiGH, DateTime ngayLapHD, int tinhTrangHD, int tinhTrangTT, int soTienNhan, int soTienTra)
        {
            MaHD = maHD;
            TenKH = tenKH;
            MaKM = maKM;
            TongTienTT = tongTienTT;
            DiaChiGH = diaChiGH;
            NgayLapHD = ngayLapHD;
            TinhTrangHD = tinhTrangHD;
            TinhTrangTT = tinhTrangTT;
            SoTienNhan = soTienNhan;
            SoTienTra = soTienTra;
        }
    }
}
