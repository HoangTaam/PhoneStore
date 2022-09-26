using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Controllers
{
    public class KhoController : Controller
    {
        // GET: KhoController
        public ActionResult Index()
        {
            return View();
        }
    }
}
