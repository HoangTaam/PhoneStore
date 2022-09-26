using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DoAn_FW.Models;
using Newtonsoft.Json;

namespace Web_ProjectFrameWork.Controllers
{
    public class HomeController : Controller
    {
        public void DataKH()
        {
            var KH = new KhachHang();
            if (HttpContext.Session.GetString("KH")!= null) { 
                KH = JsonConvert.DeserializeObject<KhachHang>(HttpContext.Session.GetString("KH"));
            }
            this.ViewBag.KH = KH;
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
        public IActionResult Index()
        {
            DataKH();
            DataCart();
            var context = new SanPhamContext();
            var data = context.ListSPMoiNhat();
            this.ViewBag.ListSP = data;
            return View();
        }
    }
}
