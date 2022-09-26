using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_FW.Models
{
    public class ThongTinSP
    {
        public virtual long Mattsp { get; set; }

        public virtual long Masp { get; set; }

        public virtual long MaKho { get; set; }

        public virtual int Gia { get; set; }

        public virtual int? GiaKM { get; set; }

        public virtual int? SoLuong { get; set; }

        public virtual string Mausac { get; set; }

        public virtual int? Ram { get; set; }

        public virtual int? Bonhotrong { get; set; }

        public virtual int? Pin { get; set; }

        public virtual float? Kichthuongmanhinh { get; set; }

        public virtual string Cameratruoc { get; set; }

        public virtual string Camerasau { get; set; }

        public virtual string Cpu { get; set; }
    }
}
