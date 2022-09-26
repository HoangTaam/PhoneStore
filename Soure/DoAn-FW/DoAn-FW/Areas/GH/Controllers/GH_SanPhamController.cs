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
    public class GH_SanPhamController : Controller
    {
        // GET: SanPhamController
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
        public IActionResult LietKeSanPham(int page = 1)
        {
            DataNV();
            var DSSP = context.GetSanPhams(page);
            ViewData["pages"] = DSSP.pages;
            ViewData["page"] = DSSP.page;
            return View(DSSP.sp);

        }
        public IActionResult ViewSanPham(string Id)
        {
            DataNV();
            SanPham sp = context.ViewSanPham(Id);
            ViewData.Model = sp;
            List<LoaiSanPham> DSLSP = context.GetLoaiSanPhams();
            ViewBag.DSLSP = DSLSP;
            List<ThuongHieu> DSTH = context.GetThuongHieus();
            ViewBag.DSTH = DSTH;
            return View();
        }
        public IActionResult DeleteSanPham(string Id)
        {
            DataNV();
            int[] count = context.XoaSanPham(Id);
            return View();
        }
        public IActionResult UpdateSanPham(SanPham ttsp)
        {
            int count;
            DataNV();
            count = context.UpdateSanPham(ttsp);
            if (count > 0)
                ViewData["thongbao"] = "Update thành công";
            else
                ViewData["thongbao"] = "Update không thành công";
            return View();
        }
        public IActionResult InsertSanPham(SanPham ttsp)
        {
            int count;
            DataNV();
            count = context.InsertSanPham(ttsp);
            ViewData.Model = ttsp;
            if (count > 0)
                ViewData["thongbao"] = "Thêm sản phẩm thành công";
            else
                ViewData["thongbao"] = "Thêm sản phẩm không thành công";
            return View();
        }
        public IActionResult EnterSanPham()
        {
            DataNV();
            List<LoaiSanPham> DSLSP = context.GetLoaiSanPhams();
            ViewBag.DSLSP = DSLSP;
            List<ThuongHieu> DSTH = context.GetThuongHieus();
            ViewBag.DSTH = DSTH;
            return View();
        }
        public IActionResult FindSanPham(string ten)
        {
            DataNV();
            ViewData["ten"] = ten;
            return View(context.FindSanPham(ten));
        }
        public IActionResult LietKeLoaiSanPham()
        {
            DataNV();
            return View(context.GetLoaiSanPhams());
        }
        public IActionResult InsertLoaiSP(string TENLOAISP)
        {
            int count;
            DataNV();
            count = context.InsertLoaiSanPham(TENLOAISP);
            //ViewData.Model = lsp;
            if (count > 0)
                ViewData["thongbao"] = "Thêm thành công";
            else
                ViewData["thongbao"] = "Thêm không thành công";
            List<LoaiSanPham> DSLSP = context.GetLoaiSanPhams();
            ViewBag.DSLSP = DSLSP;
            return View();
        }
        public IActionResult InsertTH(ThuongHieu th)
        {
            int count;
            DataNV();
            count = context.InsertThuongHieu(th);
            ViewData.Model = th;
            if (count > 0)
                ViewData["thongbao"] = "Thêm thành công";
            else
                ViewData["thongbao"] = "Thêm không thành công";
            List<ThuongHieu> DSTH = context.GetThuongHieus();
            ViewBag.DSTH = DSTH;
            return View();
        }
        public IActionResult DeleteLoaiSP(string Id)
        {
            DataNV();
            int[] count = context.XoaLoaiSanPham(Id);
            return View();
        }
        public IActionResult DeleteTH(string Id)
        {
            DataNV();
            int[] count = context.XoaThuongHieu(Id);
            return View();
        }
    }
}
