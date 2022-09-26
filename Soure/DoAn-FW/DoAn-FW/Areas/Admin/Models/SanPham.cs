using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class SanPham
    {
        private string maTTSP;
        private string tenSP;
        private string hinhAnh;
        private int maloaiSP;
        private int maTH;
        private int gia;
        private int giaKM;
        private int soLuong;
        private string mauSac;
        private int ram;
        private int boNhoTrong;
        private int pin;
        private float kichthuocmanhinh;
        private string cameraTruoc;
        private string cameraSau;
        private string cpu;
        private string tenLoaiSP;
        private string tenTH;
        public string MATTSP
        {
            get { return maTTSP; }
            set { maTTSP = value; }
        }
        public string TENSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        public string HINHANH
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }
        public int MALOAISP
        {
            get { return maloaiSP; }
            set { maloaiSP = value; }
        }
        public int MATH
        {
            get { return maTH; }
            set { maTH = value; }
        }
        public int GIA
        {
            get { return gia; }
            set { gia = value; }
        }
        public int GIAKM
        {
            get { return giaKM; }
            set { giaKM = value; }
        }
        public int SOLUONG
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string MAUSAC
        {
            get { return mauSac; }
            set { mauSac = value; }
        }
        public int RAM
        {
            get { return ram; }
            set { ram = value; }
        }
        public int BONHOTRONG
        {
            get { return boNhoTrong; }
            set { boNhoTrong = value; }
        }
        public int PIN
        {
            get { return pin; }
            set { pin = value; }
        }
        public float KICHTHUOCMANHINH
        {
            get { return kichthuocmanhinh; }
            set { kichthuocmanhinh = value; }
        }
        public string CAMERATRUOC
        {
            get { return cameraTruoc; }
            set { cameraTruoc = value; }
        }
        public string CAMERASAU
        {
            get { return cameraSau; }
            set { cameraSau = value; }
        }
        public string CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }
        public string TENLOAISP
        {
            get { return tenLoaiSP; }
            set { tenLoaiSP = value; }
        }
        public string TENTH
        {
            get { return tenTH; }
            set { tenTH = value; }
        }
    }
}
