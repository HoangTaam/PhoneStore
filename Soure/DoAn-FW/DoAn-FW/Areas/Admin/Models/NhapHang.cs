using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class NhapHang
    {
        private int maPN;
        private int tongtienTT;
        private DateTime ngaylapPN;
        private int tinhtrangTT;
        private int maNCC;
        private int maNV;
        private string tenNCC;
        private string tenNV;
        private string tenSP;
        public int MAPN
        {
            get { return maPN; }
            set { maPN = value; }
        }
        public int TONGTIENTT
        {
            get { return tongtienTT; }
            set { tongtienTT = value; }
        }
        public DateTime NGAYLAPPN
        {
            get { return ngaylapPN; }
            set { ngaylapPN = value; }
        }
        public int TINHTRANGTT
        {
            get { return tinhtrangTT; }
            set { tinhtrangTT = value; }
        }
        public int MANCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public int MANV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string TENNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        public string TENNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public string TENSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }


    }
}
