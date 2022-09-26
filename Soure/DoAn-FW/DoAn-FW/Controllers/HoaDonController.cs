using DoAn_FW.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace DoAn_FW.Controllers
{
    public class HoaDonController : Controller
    {
        public void DataKH()
        {
            var KH = new KhachHang();
            if (HttpContext.Session.GetString("KH") != null)
            {
                KH = JsonConvert.DeserializeObject<KhachHang>(HttpContext.Session.GetString("KH"));
            }
            this.ViewBag.KH = KH;
        }
        public KhachHang GetDataKH()
        {
            var KH = new KhachHang();
            if (HttpContext.Session.GetString("KH") != null)
            {
                KH = JsonConvert.DeserializeObject<KhachHang>(HttpContext.Session.GetString("KH"));
            }
            this.ViewBag.KH = KH;
            return KH;
        }
        public void DataCart()
        {
            var KH = new KhachHang();
            if (HttpContext.Session.GetString("KH") != null)
            {
                KH = JsonConvert.DeserializeObject<KhachHang>(HttpContext.Session.GetString("KH"));
            }
            var context = new GioHang();
            var cart = context.ListGioHang(KH.MaKH);
            this.ViewBag.cart = cart;
        }
        public IActionResult HoaDon()
        {
            return View();
        }
       
        public IActionResult LichSuHD()
        {
            KhachHang KH = GetDataKH();
            DataCart();
            var hdcontext = new HoaDon();
            var listhd = new List<HoaDon>();
            listhd = hdcontext.ListHD(KH.MaKH);
            this.ViewBag.ListHD = listhd;
            return View();
        }
        [HttpPost]
        public IActionResult InsertHD(List<int> MaTTSP, List<int> SoLuong, int MaKM, string DiaChi)
        {
            KhachHang KH = GetDataKH();
            DataCart();
            var hdcontext = new HoaDon();
            int count = 0;
            count = hdcontext.InsertHD(KH.MaKH, MaKM, DiaChi);
            if (count > 0)
            {
                for (var i = 0; i < MaTTSP.Count(); i++)
                {
                    var cthdcontext = new CTHD();
                    var check = 0;
                    CTHD ct = new CTHD();
                    ct.MaHD = count;
                    ct.MaTTSP = MaTTSP[i];
                    ct.SoLuong = SoLuong[i];
                    check = cthdcontext.InsertCTHD(ct);
                }
                this.ViewBag.Count = 1;
            }
            else
            {
                this.ViewBag.Count = 0;
            }
            return View();
        }
        public IActionResult CapNhatHD(int mahd, int tthd)
        {
            var hdcontext = new HoaDon();
            var count = 0;
            count = hdcontext.CapNhatHD(mahd, tthd);
            return RedirectToAction("LichSuHD", "HoaDon");
        }
        [HttpPost]
        public IActionResult XacNhanHD(List<int> MaTTSP, List<string> TenSP, List<long> SoLuong, List<long> Gia, int MaKM)
        {
            KhachHang KH = GetDataKH();
            DataCart();
            var kmcontext = new KhuyenMai();
            var km = kmcontext.GetKM(MaKM);
            List<CTHD> listcthd = new List<CTHD>();
            for(var i = 0; i < MaTTSP.Count(); i++)
            {
                listcthd.Add(new CTHD
                {
                    MaTTSP = MaTTSP[i],
                    SoLuong = SoLuong[i],
                    TenSP = TenSP[i],
                    Gia = Gia[i],
                }); ;
            }
            this.ViewBag.KM = km;
            this.ViewBag.listcthd = listcthd;
            return View();
        }
        public IActionResult CTHD(int mahd)
        {
            DataKH();
            DataCart();
            var hdcontext = new HoaDon();
            var cthdcontext = new CTHD();
            this.ViewBag.HD = hdcontext.GetHD(mahd);
            this.ViewBag.CTHD = cthdcontext.ListCTHD(mahd);
            return View();
        }
    }
}
