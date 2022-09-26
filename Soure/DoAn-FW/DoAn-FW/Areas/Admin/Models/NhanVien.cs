using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class NhanVien
    {
        public NhanVien()
        {
        }

        public NhanVien(int maNV, string tenNV, DateTime ngayVL, int luong, string sDT, string email, string matKhau, string cMND, string diaChi, string loaiNV)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NgayVL = ngayVL;
            Luong = luong;
            SDT = sDT;
            Email = email;
            MatKhau = matKhau;
            CMND = cMND;
            DiaChi = diaChi;
            LoaiNV = loaiNV;
        }

        public int MaNV { get; set; }
        public String TenNV { get; set; }
        public DateTime NgayVL { get; set; }
        public int Luong { get; set; }
        public String SDT { get; set; }
        public String Email { get; set; }
        public String MatKhau { get; set; }
        public String CMND { get; set; }
        public String DiaChi { get; set; }
        public String LoaiNV { get; set; }

    }
}
