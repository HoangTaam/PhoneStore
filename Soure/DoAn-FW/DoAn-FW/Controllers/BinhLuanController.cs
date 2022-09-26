using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DoAn_FW.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Web_ProjectFrameWork.Controllers
{
    public class BinhLuanController : Controller
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
        public IActionResult ThemBinhLuan(BinhLuan bl)
        {
            DataKH();
            DataCart();
            var blcontext = new BinhLuan();
            int count = 0;
            var t = bl.MaTTSP;
            if (bl.MaKH != null && bl.MaKH != 0)
            {
                count = blcontext.InsertBL(bl);
                
            }
            ViewData["count"] = count;
            return RedirectToAction("ChiTietSP", new RouteValueDictionary(new { Controller = "SanPham", Action = "ChiTietSP", t}));
        }

    }
}
