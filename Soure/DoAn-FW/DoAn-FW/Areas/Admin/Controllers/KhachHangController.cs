using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_projectframeword_admin.Models;

namespace Web_projectframeword_admin.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHangController
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

        public ActionResult Index(string ID, int page = 1)
        {
            DataNV();
            var DSKH = context.GetDSKH(page);

            ViewData["pages"] = DSKH.pages;

            ViewData["page"] = DSKH.page;


            if (!String.IsNullOrEmpty(ID))
            {
                List<KhachHang> Lkq = new List<KhachHang>();
                foreach (var kh in DSKH.kh)
                {
                    if (kh.TenKH.Contains(ID))
                    {
                        Lkq.Add(kh);
                    }
                }
                if (Lkq.Count == 0)
                {
                    ViewData["ThongBao"] = "1";
                }
                return View(Lkq);
            }
            ViewData["ThongBao"] = "0";
            return View(DSKH.kh);
        }

        public ActionResult Xoa(int ID, int page)
        {
            DataNV();
            if (ID != 0)
            {
                int count = context.DeleteKH(ID);
                if (count > 0)
                    ViewData["trangthai"] = "Xóa thành công";
                else
                    ViewData["trangthai"] = "Xóa không thành công";
            }
            var DSNV = context.GetDSKH(page);

            ViewData["pages"] = DSNV.pages;

            ViewData["page"] = DSNV.page;

            return View("Index", DSNV.kh);
        }
        public ActionResult XemKH(int ID)
        {
            DataNV();

            return View(context.GetKH(ID));
        }
    }
}
