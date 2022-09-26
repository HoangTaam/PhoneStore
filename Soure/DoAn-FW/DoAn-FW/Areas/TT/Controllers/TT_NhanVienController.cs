using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_projectframeword_admin.Models;

namespace DoAn_FW.Areas.TT.Controllers
{
    public class TT_NhanVienController : Controller
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
        public IActionResult Index(string ID, int page = 1)
        {
            DataNV();
            var DSNV = context.GetDSNV(page);

            ViewData["pages"] = DSNV.pages;

            ViewData["page"] = DSNV.page;


            if (!String.IsNullOrEmpty(ID))
            {
                List<NhanVien> Lkq = new List<NhanVien>();
                foreach (var nv in DSNV.nv)
                {
                    if (nv.TenNV.Contains(ID))
                    {
                        Lkq.Add(nv);
                    }
                }
                if (Lkq.Count == 0)
                {
                    ViewData["ThongBao"] = "1";
                }
                return View(Lkq);
            }
            ViewData["ThongBao"] = "0";
            return View(DSNV.nv);
        }

        public ActionResult Them(NhanVien nv)
        {
            DataNV();
            if (nv != null)
            {
                if (nv.TenNV == null || nv.NgayVL == null || nv.SDT == null
                    || nv.LoaiNV == null || nv.CMND == null || nv.DiaChi == null || nv.Email == null)
                {
                    ViewData["thongbao"] = "Không được bỏ trống";
                }
                else
                {
                    int count = context.ThemNhanVien(nv);
                    if (count > 0)
                        ViewData["thongbao"] = "Thêm thành công";
                    else
                        ViewData["thongbao"] = "Thêm không thành công";
                }
                
            }
            else
            {
                ViewData["thongbao"] = "Không được bỏ trống";
            }
            return View("ThemNV");
        }
        public ActionResult ThemNV()
        {
            DataNV();
            return View();
        }
        public ActionResult SuaNV(int ID)
        {
            DataNV();

            return View(context.GetNV(ID));
        }

        public ActionResult Xoa(int ID, int page)
        {
            DataNV();
            if (ID != 0)
            {
                int count = context.DeleteNV(ID);
                if (count > 0)
                    ViewData["trangthai"] = "Xóa thành công";
                else
                    ViewData["trangthai"] = "Xóa không thành công";
            }
            var DSNV = context.GetDSNV(page);

            ViewData["pages"] = DSNV.pages;

            ViewData["page"] = DSNV.page;

            return View("Index", DSNV.nv);
        }
        public ActionResult Update(NhanVien nv)
        {
            DataNV();
            if (nv != null)
            {
                if (nv.TenNV == null || nv.NgayVL == null || nv.SDT == null|| nv.LoaiNV == null ||
                    nv.CMND == null || nv.DiaChi == null || nv.Email == null)
                {
                    ViewData["thongbao"] = "Không được bỏ trống";
                }
                else
                {
                    int count = context.UpdateNV(nv);
                    if (count > 0)
                        ViewData["thongbao"] = "Cập nhật thành công";
                    else
                        ViewData["thongbao"] = "Cập nhật không thành công";
                }
            }
            else
            {
                ViewData["thongbao"] = "Không được bỏ trống";
            }
            return View("SuaNV", context.GetNV(nv.MaNV));
        }    
    }
}
