using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class LoaiSanPham 
    {
        private int maLoaiSP;
        private string tenLoaiSP;
        public int MALOAISP
        {
            get { return maLoaiSP; }
            set { maLoaiSP = value; }
        }
        public string TENLOAISP
        {
            get { return tenLoaiSP; }
            set { tenLoaiSP = value; }
        }
    }
}
