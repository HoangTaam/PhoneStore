using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_FW.Models
{
    public class KhachHang
    {
        public virtual int MaKH { get; set; }

        public virtual string TenKH { get; set; }

        public virtual string GioiTinh { get; set; }

        public virtual string SDT { get; set; }

        public virtual string Email { get; set; }

        public virtual string MatKhau { get; set; }

        public virtual string CMND { get; set; }

        public virtual string DiaChi { get; set; }

        public virtual string LoaiKH { get; set; }
    }
}
