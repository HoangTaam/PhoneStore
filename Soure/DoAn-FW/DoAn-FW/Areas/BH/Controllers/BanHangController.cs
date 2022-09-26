using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web_projectframeword_admin.Models;

namespace DoAn_FW.Areas.BH.Controllers
{
    public class BanHangController : Controller
    {
        StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=website_dienthoai;");

        public void DataNV()
        {
            var nv = new NhanVien();
            if (HttpContext.Session.GetString("NV") != null)
            {
                nv = JsonConvert.DeserializeObject<NhanVien>(HttpContext.Session.GetString("NV"));
            }
            this.ViewBag.NV = nv;
            int sohdcd = context.HDChuaDuyet();
            this.ViewBag.SoHDCD = sohdcd;
            int soghcg = context.GHChuaGiao();
            this.ViewBag.SoGHCG = soghcg;
        }

        public IActionResult Index(string SearchString, int page = 1)
        {
            DataNV();
            var Lhd = context.GetDSCD(page);
            ViewData["pages"] = Lhd.pages;

            ViewData["page"] = Lhd.page;
            if (!String.IsNullOrEmpty(SearchString))
            {
                List<HoaDonViewModel> Lkq = new List<HoaDonViewModel>();
                foreach (var hd in Lhd.hd)
                {
                    if (hd.TenKH.Contains(SearchString))
                    {
                        Lkq.Add(hd);
                    }
                }
                if (Lkq.Count == 0)
                {
                    ViewData["ThongBao"] = "1";
                }
                return View(Lkq);
            }
            ViewData["ThongBao"] = "0";
            return View(Lhd.hd);
        }

        public ActionResult HuyHD(int MAHD, int page)
        {
            context.HuyHD(MAHD);
            var Lhd = context.GetDSCD(page);
            ViewData["pages"] = Lhd.pages;

            ViewData["page"] = Lhd.page;
            ViewData["ThongBao"] = "0";
            return View("Index", Lhd.hd);
        }
    }
}
