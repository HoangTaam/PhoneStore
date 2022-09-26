using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class CTPN
    {
        private int maPN;
        private int maTTSP;
        private int giaNhap;
        private int soLuong;
        private int thanhTien;
        private string tenSP;
        public int MAPN
        {
            get { return maPN; }
            set { maPN = value; }
        }
        public int MATTSP
        {
            get { return maTTSP; }
            set { maTTSP = value; }
        }
        public int GIANHAP
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }
        public int SOLUONG
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public int THANHTIEN
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
        public string TENSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
    }
}
