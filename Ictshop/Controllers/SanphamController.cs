using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class SanphamController : Controller
    {
       QLbanhang db = new QLbanhang();

        // GET: Sanpham
        public ActionResult GagionPartial()
        {
            var ip = db.Sanphams.Where(n=>n.Mancc==1).Take(8).ToList();
           return PartialView(ip);
        }
        public ActionResult GavacomPartial()
        {
            var ss = db.Sanphams.Where(n => n.Mancc == 2).Take(8).ToList();
            return PartialView(ss);
        }
        public ActionResult TrangmiengPartial()
        {
            var mi = db.Sanphams.Where(n => n.Mancc == 3).Take(8).ToList();
            return PartialView(mi);
        }
        public ActionResult MiYPartial()
        {
            var miy = db.Sanphams.Where(n => n.Mancc == 7).Take(8).ToList();
            return PartialView(miy);
        }
       //// public ActionResult NuocuongPartial()
        //{
        //    var mi = db.Sanphams.Where(n => n.Mancc == 4).Take(4).ToList();
        //    return PartialView(mi);
      //  }
        public ActionResult xemchitiet(int Masp=0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n=>n.Masp==Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

        

    }

}