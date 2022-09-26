using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class HoTro
    {
        private int maBL;
        private int maTTSP;
        private int maKH;
        private string noiDung;
        private string tenSP;
        private string tenKH;
        public int MABL
        {
            get { return maBL; }
            set { maBL = value; }
        }
        public int MATTSP
        {
            get { return maTTSP; }
            set { maTTSP = value; }
        }
        public int MAKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string NOIDUNG
        {
            get { return noiDung; }
            set { noiDung = value; }
        }
        public string TENSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        public string TENKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
    }
}
