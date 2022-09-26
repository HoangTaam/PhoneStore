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
    public class NhaCungCapController : Controller
    {
        // GET: NhaCungCapController
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
        public ActionResult Index(string? id)
        {
            DataNV();
            int count = 0;
            if (id != null)
            {
                count = context.XoaNCC(id);
            }
            var ListNCC = context.GetNhaCungCaps();
            
            return View(ListNCC);
        }
        public ActionResult ThemNCC(NhaCungCap ncc)
        {
            DataNV();
            return View();
        }
        public ActionResult InsertNCC(NhaCungCap ncc)
        {
            DataNV();
            int count;

            //StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=website_dienthoai;");
            count = context.ThemNCC(ncc);
            if (count > 0)
                ViewData["thongbao"] = "Insert thành công";
            else
                ViewData["thongbao"] = "Insert không thành công";
            return Redirect("/Admin/NhaCungCap/Index");
        }

        public ActionResult SuaNCC(int id)
        {
            DataNV();
            
            this.ViewBag.NCC = context.GetNhaCungCapTheoMa(id);
            return View();
        }
        public ActionResult UpdateNCC(NhaCungCap ncc)
        {
            DataNV();
            int count;

            //StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=website_dienthoai;");
            count = context.SuaNCC(ncc);
            if (count > 0)
                ViewData["thongbao"] = "Update thành công";
            else
                ViewData["thongbao"] = "Update không thành công";
            return Redirect("/Admin/NhaCungCap/Index");

        }
    }
}
