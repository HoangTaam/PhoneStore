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
    public class BH_ThongKeController : Controller
    {
        // GET: ThongKeController
        public void DataNV()
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=website_dienthoai;");

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

        public ActionResult Index(int y = 2021)
        {
            DataNV();
            if (y != null && y != 0)
            {
                var context = new ThongKe();
                this.ViewBag.DTT1 = context.DoanhThuThang(1, y);
                this.ViewBag.DTT2 = context.DoanhThuThang(2, y);
                this.ViewBag.DTT3 = context.DoanhThuThang(3, y);
                this.ViewBag.DTT4 = context.DoanhThuThang(4, y);
                this.ViewBag.DTT5 = context.DoanhThuThang(5, y);
                this.ViewBag.DTT6 = context.DoanhThuThang(6, y);
                this.ViewBag.DTT7 = context.DoanhThuThang(7, y);
                this.ViewBag.DTT8 = context.DoanhThuThang(8, y);
                this.ViewBag.DTT9 = context.DoanhThuThang(9, y);
                this.ViewBag.DTT10 = context.DoanhThuThang(10, y);
                this.ViewBag.DTT11 = context.DoanhThuThang(11, y);
                this.ViewBag.DTT12 = context.DoanhThuThang(12, y);
                this.ViewBag.TongDT = context.DoanhThuNam(y);
                this.ViewBag.Nam = y;
            }
            return View();
        }
        public ActionResult CTTKTheoThang(int m, int y)
        {
            DataNV();
            var context = new ThongKe();
            this.ViewBag.Thang = m;
            this.ViewBag.Nam = y;
            return View(context.GetHDsTheoThang(m, y));
        }
        public ActionResult DSKH(int y = 2021)
        {
            DataNV();
            var context = new ThongKe();
            this.ViewBag.Nam = y;
            return View(context.Top3KH(y));
        }
        public ActionResult DSSP(int y = 2021)
        {
            DataNV();
            var context = new ThongKe();
            this.ViewBag.Nam = y;
            return View(context.DSSP(y));
        }
        public ActionResult ChiPhi(int y = 2021)
        {
            DataNV();
            if (y != null && y != 0)
            {
                var context = new ThongKe();
                this.ViewBag.DTT1 = context.ChiPhiThang(1, y);
                this.ViewBag.DTT2 = context.ChiPhiThang(2, y);
                this.ViewBag.DTT3 = context.ChiPhiThang(3, y);
                this.ViewBag.DTT4 = context.ChiPhiThang(4, y);
                this.ViewBag.DTT5 = context.ChiPhiThang(5, y);
                this.ViewBag.DTT6 = context.ChiPhiThang(6, y);
                this.ViewBag.DTT7 = context.ChiPhiThang(7, y);
                this.ViewBag.DTT8 = context.ChiPhiThang(8, y);
                this.ViewBag.DTT9 = context.ChiPhiThang(9, y);
                this.ViewBag.DTT10 = context.ChiPhiThang(10, y);
                this.ViewBag.DTT11 = context.ChiPhiThang(11, y);
                this.ViewBag.DTT12 = context.ChiPhiThang(12, y);
                this.ViewBag.TongDT = context.ChiPhiNam(y);
                this.ViewBag.Nam = y;
            }
            return View();
        }
        public ActionResult CTChiPhi(int m, int y)
        {
            DataNV();
            var context = new ThongKe();
            this.ViewBag.Thang = m;
            this.ViewBag.Nam = y;
            return View(context.GetPNsTheoThang(m, y));
        }
    }
}
