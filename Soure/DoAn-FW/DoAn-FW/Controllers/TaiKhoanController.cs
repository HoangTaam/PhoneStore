using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DoAn_FW.Models;
using Newtonsoft.Json;

namespace Web_ProjectFrameWork.Controllers
{
    public class TaiKhoanController : Controller
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
        public IActionResult DangNhap()
        {
            return View();
        }
        public IActionResult DangKi()
        {
            return View();
        }
        public IActionResult ThongTinTK()
        {
            DataKH();
            DataCart();
            return View();
        }
        public IActionResult ThemTK(KhachHang kh)
        {
            int count;
            var context = new KhachHangContext();
            count = context.ThemTK(kh);
            ViewData["count"] = count;
            return View();
        }
        public IActionResult CapNhatTK(KhachHang kh)
        {
            int count;
            var context = new KhachHangContext();
            count = context.CapNhatTK(kh);
            HttpContext.Session.Remove("KH");
            var khcontext = context.KHDangNhap(kh.Email, kh.MatKhau);
            if (khcontext != null && khcontext.MaKH > 0)
            {
                HttpContext.Session.SetString("KH", JsonConvert.SerializeObject(khcontext));
                return RedirectToAction("ThongTinTK", "TaiKhoan");
            }
            else
            {
                HttpContext.Session.Remove("KH");
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult KTDangNhap()
        {
            String Email = Request.Form["email"];
            String MatKhau = Request.Form["pwd"];
            var context = new KhachHangContext();
            var kh = context.KHDangNhap(Email, MatKhau);
            var context1 = new NhanVienContext();
            var nv = context1.KHDangNhap(Email, MatKhau);
            if (nv!=null && nv.MaNV > 0 && nv.LoaiNV == "Quản lý")
            {
                HttpContext.Session.SetString("NV", JsonConvert.SerializeObject(nv));
                return Redirect("/Admin/HomeAdmin/Index");
            }
            else if (nv != null && nv.MaNV > 0 && nv.LoaiNV == "Bán hàng")
            {
                HttpContext.Session.SetString("NV", JsonConvert.SerializeObject(nv));
                return Redirect("/BH/BanHang/Index");
            }
            else if (nv != null && nv.MaNV > 0 && nv.LoaiNV == "Giao hàng")
            {
                HttpContext.Session.SetString("NV", JsonConvert.SerializeObject(nv));
                return Redirect("/GH/HomeGH/Index");
            }
            else if (nv != null && nv.MaNV > 0 && nv.LoaiNV == "Tiếp tân")
            {
                HttpContext.Session.SetString("NV", JsonConvert.SerializeObject(nv));
                return Redirect("/TT/TT_ThongKe/Index");
            }
            else if (kh != null && kh.MaKH > 0)
            {
                HttpContext.Session.SetString("KH", JsonConvert.SerializeObject(kh)) ;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.check = "Sai tên tài khoản hoặc mật khẩu ";
                return View("DangNhap");
            }
        }
        public IActionResult DangXuat(KhachHang kh)
        {
            
            HttpContext.Session.Remove("KH");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult DangXuatNV(NhanVien nv)
        {

            HttpContext.Session.Remove("NV");
            return RedirectToAction("Index", "Home");
        }
    }
}
