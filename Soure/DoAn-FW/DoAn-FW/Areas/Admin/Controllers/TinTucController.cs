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
    public class TinTucController : Controller
    {
        StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=website_dienthoai;");

        // GET: TinTucController
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
                count = context.XoaTT(id);
            }
            
            var ListTT = context.GetTinTucs();
            return View(ListTT);
        }
        public ActionResult ThemTinTuc(TinTuc tt)
        {
            DataNV();
            return View();
        }

        public ActionResult InsertTinTuc(TinTuc tt)
        {
            DataNV();
            int count;

            //StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            tt.hinhbia = "https://localhost:44387/img/TinTuc/" + tt.hinhbia;
            count = context.ThemTT(tt);
            if (count > 0)
                ViewData["thongbao"] = "Insert thành công";
            else
                ViewData["thongbao"] = "Insert không thành công";
            return Redirect("/Admin/TinTuc/Index");
        }
        public ActionResult SuaTinTuc(int id)
        {
            DataNV();
            this.ViewBag.TTuc = context.GetTinTucTheoMa(id);
            return View();
        }
        public ActionResult UpdateTinTuc(TinTuc tt)
        {
            DataNV();
            int count;
            tt.hinhbia = "https://localhost:44387/img/TinTuc/" + tt.hinhbia;
            //StoreContext context = HttpContext.RequestServices.GetService(typeof(firstWeb.Models.StoreContext)) as StoreContext;
            count = context.SuaTT(tt);
            if (count > 0)
                ViewData["thongbao"] = "Insert thành công";
            else
                ViewData["thongbao"] = "Insert không thành công";
            return Redirect("/Admin/TinTuc/Index");
        }
    }
}
