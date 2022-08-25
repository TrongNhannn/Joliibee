using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class DanhmucController : Controller
    {
        QLbanhang db = new QLbanhang();
        // GET: Danhmuc
        public ActionResult DanhmucPartial()
        {
            var danhmuc = db.Nhacungcaps.ToList();
            return PartialView(danhmuc);
        }
    }
}