using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DoAn_FW.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Web_ProjectFrameWork.Controllers
{
    public class SanPhamController : Controller
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
        public IActionResult DanhSachSP(int pg = 1)
        {
            var context = new SanPhamContext();
            List<object> list = context.ListSPMoiNhat();
            int pageSize = 6;
            if (pg < 1) pg = 1;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            ViewData["list"] = data;
            ViewData["ListLoaiSP"] = context.ListLoaiSP();
            return View();
        }

        public IActionResult MayTinhBang(int pg = 1, int? math = null, string? search = null)
        {
            DataKH();
            DataCart();
            var context = new SanPhamContext();
            int pageSize = 8;
            List<object> list;
            if (math != null)
            {
                list = context.SPLocTheoHangSP(2,math);
            }
            else if (search != null)
            {
                list = context.SearchMTB(search);
                pageSize = 100;
            }
            else
            {
                list = context.FilterSanPham(2);
            }
            if (pg < 1) pg = 1;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            ViewData["list"] = data;
            ViewData["math"] = math;
            ViewData["ListLoaiSP"] = context.ListLoaiSP();
            ViewData["ListHang"] = context.ListHang(2);
            return View();
        }

        [HttpGet]
        public IActionResult DTDD(int pg = 1, int? math = null, string? search = null)
        {
            DataKH();
            DataCart();
            var context = new SanPhamContext();
            List<object> list;
            int pageSize = 8;
            if (math != null) {
                list = context.SPLocTheoHangSP(1,math);
            }
            else if(search != null)
            {
                list = context.SearchDT(search);
                pageSize = 100;
            }
            else
            {
                list = context.FilterSanPham(1);
            }
            if (pg < 1) pg = 1;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            ViewData["list"] = data;
            ViewData["math"] = math;
            ViewData["ListLoaiSP"] = context.ListLoaiSP();
            ViewData["ListHang"] = context.ListHang(1);
            return View();
        }

        [HttpGet]
        public IActionResult ChiTietSP(int t, int l)
        {
            DataKH();
            DataCart();
            var context = new SanPhamContext();
            ViewData["CTSP"] = context.ChiTietSP(t);
            ViewData["ListDT"] = context.FilterSanPham(l);
            ViewData["ListBL"] = context.BinhLuans(t);
            return View();
        }

    }
}
