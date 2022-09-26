using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_projectframeword_admin.Models;

namespace DoAn_FW.Areas.BH.Controllers
{
    public class BH_KhuyenMaiController : Controller
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
        public IActionResult LietKeKhuyenMai()
        {
            DataNV();
            return View(context.GetKhuyenMais());
        }
        public IActionResult ViewKhuyenMai(string Id)
        {
            DataNV();
            KhuyenMai km = context.ViewKhuyenMai(Id);
            ViewData.Model = km;
            return View();
        }
        public IActionResult DeleteKhuyenMai(string Id)
        {
            DataNV();
            int[] count = context.XoaKhuyenMai(Id);
            ViewData["thongbao"] = count;
            return View();
        }
        public IActionResult UpdateKhuyenMai(KhuyenMai km)
        {
            int count;
            DataNV();
            count = context.UpdateKhuyenMai(km);
            if (count > 0)
                ViewData["thongbao"] = "Update thành công";
            else
                ViewData["thongbao"] = "Update không thành công";
            return View();
        }
        public IActionResult InsertKhuyenMai(KhuyenMai km)
        {
            int count;
            DataNV();
            count = context.InsertKhuyenMai(km);
            ViewData.Model = km;
            if (count > 0)
                ViewData["thongbao"] = "Thêm thành công";
            else
                ViewData["thongbao"] = "Thêm không thành công";
            return View();
        }
        public IActionResult EnterKhuyenMai()
        {
            return View();
        }
    }
}
