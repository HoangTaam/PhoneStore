using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_projectframeword_admin.Models;

namespace DoAn_FW.Areas.GH.Controllers
{
    public class GH_HoTroController : Controller
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
        // GET: HoTroController
        public IActionResult LietKeHoTro()
        {
            DataNV();
            return View(context.GetHoTros());
        }
        public IActionResult ViewHoTro(string Id)
        {
            DataNV();
            HoTro ht = context.ViewHoTro(Id);
            ViewData.Model = ht;
            return View();
        }
        public IActionResult DeleteHoTro(string Id)
        {
            DataNV();
            int[] count = context.XoaHoTro(Id);
            ViewData["thongbao"] = count;
            return View();
        }
    }
}
