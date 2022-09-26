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
    public class BH_HoaDonController : Controller
    {
        StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=website_dienthoai;");
        // GET: HoaDonController
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
        public ActionResult Index(string SearchString,int page = 1)
        {
            DataNV();
            var Lhd = context.GetDSHD(page);
            ViewData["pages"] = Lhd.pages;

            ViewData["page"] = Lhd.page;
            if (!String.IsNullOrEmpty(SearchString)) 
            {
                List<HoaDonViewModel> Lkq = new List<HoaDonViewModel>();
                foreach(var hd in Lhd.hd)
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
        public ActionResult ThemHD()
        {
            DataNV();
            List<KhachHang> DSKH = context.GetDSKH();
            ViewBag.DSKH = DSKH;
            List<KhuyenMai> DSKM = context.GetDSKM();
            ViewBag.DSKM = DSKM;
            return View();
        }
        public ActionResult XemHD(int ID)
        {
            DataNV();
            HoaDonEditModel hd = context.GetHD(ID);
            List<KhachHang> DSKH = context.GetDSKH();
            ViewBag.DSKH = DSKH;
            List<KhuyenMai> DSKM = context.GetDSKM();
            ViewBag.DSKM = DSKM;
            return View(hd);
        }

        public ActionResult UpdateHD(HoaDonEditModel hd)
        {
            DataNV();
            if (hd != null)
            {
                if (hd.MaKH == 0 || hd.NgayLapHD == null || hd.DiaChiGH == null)
                {
                    ViewData["thongbao"] = "Không được bỏ trống";
                }
                else
                {
                    int count = context.UpdateHD(hd);
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
            List<KhachHang> DSKH = context.GetDSKH();
            ViewBag.DSKH = DSKH;
            List<KhuyenMai> DSKM = context.GetDSKM();
            ViewBag.DSKM = DSKM;
            return View("XemHD", context.GetHD(hd.MaHD));
        }

        public ActionResult XemCTHD(int ID)
        {
            DataNV();
            List<SanPham> DSSP = context.GetDSSP();
            ViewBag.DSSP = DSSP;
            ViewData["mahd"] = ID;
            return View(context.GetDSCTHD(ID));
        }

        public ActionResult InsertCTHD(CTHD ct)
        {
            DataNV();
            List<SanPham> DSSP = context.GetDSSP();
            ViewBag.DSSP = DSSP;
            ViewData["mahd"] = ct.MaHD;
            if (ct.SoLuong == 0 || ct.MaSP ==0)
            {
                ViewData["thongbao"] = "Vui lòng chọn sản phẩm và số lượng";
            }
            else
            {
                int count = context.InsertCTHD(ct);
                if (count > 0)
                {
                    ViewData["thongbao"] = "Thêm thành công";
                }
                else
                {
                    ViewData["thongbao"] = "Thêm thất bại";
                }    
            }    
            return View("XemCTHD",context.GetDSCTHD(ct.MaHD));
        }

        public ActionResult ThemCTHD(HoaDonEditModel hd)
        {
            DataNV();
            if (hd != null)
            {
                if (hd.MaKH == 0 || hd.NgayLapHD == null || hd.DiaChiGH == null)
                {
                    ViewData["thongbao"] = "Không được bỏ trống";
                    List<KhachHang> DSKH = context.GetDSKH();
                    ViewBag.DSKH = DSKH;
                    List<KhuyenMai> DSKM = context.GetDSKM();
                    ViewBag.DSKM = DSKM;
                    return View("ThemHD");
                }
                else
                {
                    int count = context.ThemHD(hd);
                    if (count > 0)
                    {
                        ViewData["thongbao"] = "Thêm hóa đơn thành công";
                        List<KhachHang> DSKH = context.GetDSKH();
                        ViewBag.DSKH = DSKH;
                        List<KhuyenMai> DSKM = context.GetDSKM();
                        ViewBag.DSKM = DSKM;
                        return View("ThemHD");
                    }    
                    else
                    {
                        ViewData["thongbao"] = "Thêm hóa đơn không thành công";
                        List<KhachHang> DSKH = context.GetDSKH();
                        ViewBag.DSKH = DSKH;
                        List<KhuyenMai> DSKM = context.GetDSKM();
                        ViewBag.DSKM = DSKM;
                        return View("ThemHD");
                    }     
                }

            }
            else
            {
                ViewData["thongbao"] = "Không được bỏ trống";
                List<KhachHang> DSKH = context.GetDSKH();
                ViewBag.DSKH = DSKH;
                List<KhuyenMai> DSKM = context.GetDSKM();
                ViewBag.DSKM = DSKM;
                return View("ThemHD");
            }
        }

        public ActionResult HuyHD(int MAHD, int page)
        {
            DataNV();

            context.HuyHD(MAHD);
            var Lhd = context.GetDSHD(page);
            ViewData["pages"] = Lhd.pages;

            ViewData["page"] = Lhd.page;
            ViewData["ThongBao"] = "0";
            return View("Index", Lhd.hd);
        }

        public ActionResult Delete(int MAHD, int page)
        {
            DataNV();

            if (MAHD != 0)
            {
                int count = context.DeleteHD(MAHD);
                if (count > 0)
                    ViewData["trangthai"] = "Xóa thành công";
                else
                    ViewData["trangthai"] = "Xóa không thành công";
            }
            var DSNV = context.GetDSHD(page);

            ViewData["pages"] = DSNV.pages;

            ViewData["page"] = DSNV.page;

            return View("Index", DSNV.hd);
        }

        public ActionResult DeleteCTHD(int MAHD, int MASP)
        {
            DataNV();

            if (MAHD != 0 && MASP != 0)
            {
                int count = context.DeleteCTHD(MAHD, MASP);
                if (count > 0)
                    ViewData["trangthai"] = "Xóa thành công";
                else
                    ViewData["trangthai"] = "Xóa không thành công";
            }

            List<SanPham> DSSP = context.GetDSSP();
            ViewBag.DSSP = DSSP;
            ViewData["mahd"] = MAHD;
            return View("XemCTHD",context.GetDSCTHD(MAHD));
        }
    }
}
