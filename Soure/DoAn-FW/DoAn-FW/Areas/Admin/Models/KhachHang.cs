using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class KhachHang
    {
        public KhachHang()
        {
        }

        public int MaKH { get; set; }
        public String TenKH { get; set; }
        public String GioiTinh { get; set; }
        public String SDT { get; set; }
        public String Email { get; set; }
        public String MatKhau { get; set; }
        public String CMND { get; set; }
        public String DiaChi { get; set; }
        public String LoaiKH { get; set; }

        public KhachHang(int maKH, string tenKH, string gioiTinh, string sDT, string email, string matKhau, string cMND, string diaChi, string loaiKH)
        {
            MaKH = maKH;
            TenKH = tenKH;
            GioiTinh = gioiTinh;
            SDT = sDT;
            Email = email;
            MatKhau = matKhau;
            CMND = cMND;
            DiaChi = diaChi;
            LoaiKH = loaiKH;
        }
    }
}
