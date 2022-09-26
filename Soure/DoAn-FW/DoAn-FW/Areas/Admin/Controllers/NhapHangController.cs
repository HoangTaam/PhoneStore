using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_projectframeword_admin.Models;

namespace Web_projectframeword_admin.Controllers
{
    public class NhapHangController : Controller
    {
        // GET: NhapHangController
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
        public IActionResult LietKeNhapHang()
        {
            DataNV();
            return View(context.GetNhapHangs());
        }
        public IActionResult ViewNhapHang(string Id)
        {
            DataNV();
            NhapHang nh = context.ViewNhapHang(Id);
            ViewData.Model = nh;
            return View();
        }
        public IActionResult DeleteNhapHang(string Id)
        {
            DataNV();
            int count = context.XoaNhapHang(Id);
            return View("LietKeNhapHang", context.GetNhapHangs());
        }
        public IActionResult UpdateNhapHang(NhapHang nh)
        {
            int count;
            DataNV();
            count = context.UpdateNhapHang(nh);
            if (count > 0)
                ViewData["thongbao"] = "Update thành công";
            else
                ViewData["thongbao"] = "Update không thành công";
            return View("LietKeNhapHang", context.GetNhapHangs());
        }
        public IActionResult InsertNhapHang(NhapHang nh)
        {
            int count;
            DataNV();
            count = context.InsertNhapHang(nh);
            ViewData.Model = nh;
            if (count > 0)
                ViewData["thongbao"] = "Thêm thành công";
            else
                ViewData["thongbao"] = "Thêm không thành công";
            return View("LietKeNhapHang", context.GetNhapHangs());
        }
        public IActionResult EnterNhapHang()
        {
            DataNV();
            return View();
        }
        public ActionResult CTPN(int ID)
        {
            DataNV();
            List<SanPham> DSSP = context.GetDSSP();
            ViewBag.DSSP = DSSP;
            ViewData["mapn"] = ID;
            return View(context.GetDSCTPN(ID));
        }
        public ActionResult InsertCTPN(CTPN ct)
        {
            DataNV();
            List<SanPham> DSSP = context.GetDSSP();
            ViewBag.DSSP = DSSP;
            ViewData["mapn"] = ct.MAPN;
            if (ct.SOLUONG == 0 || ct.MATTSP == 0)
            {
                ViewData["thongbao"] = "Vui lòng chọn sản phẩm và số lượng";
            }
            else
            {
                int count = context.InsertCTPN(ct);
                if (count > 0)
                {
                    ViewData["thongbao"] = "Thêm thành công";
                }
                else
                {
                    ViewData["thongbao"] = "Thêm thất bại";
                }
            }
            int ID = ct.MAPN;
            return View("CTPN", context.GetDSCTPN(ID)); ;
            /*            return View("CTPN", context.GetDSCTPN(ct.MAPN));
            */
        }
        /*        public ActionResult ThemCTPN()
                {
                    return View();            
                }*/
        public ActionResult DeleteCTPN(int MAPN, int MASP)
        {
            DataNV();
            List<SanPham> DSSP = context.GetDSSP();
            ViewBag.DSSP = DSSP;
            ViewData["mapn"] = MAPN;
            if (MAPN != 0)
            {
                int count = context.DeleteCTPN(MAPN, MASP);
                if (count > 0)
                    ViewData["trangthai"] = "Xóa thành công";
                else
                    ViewData["trangthai"] = "Xóa không thành công";
            }
            return View("CTPN", context.GetDSCTPN(MAPN));
        }
    }
}
