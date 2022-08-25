using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class TinTucsController : Controller
    {
        QLbanhang db = new QLbanhang();
        // GET: /TinTucs/
         public ActionResult Index()
        {
            return View(db.Tintucs.ToList());
        }

        // GET: Admin/Hedieuhanhs/Details/5
        public ActionResult Chitiet(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           Tintuc hedieuhanh = db.Tintucs.Find(id);
            if (hedieuhanh == null)
            {
                return HttpNotFound();
            }
            return View(hedieuhanh);
        }

        // GET: Admin/Hedieuhanhs/Create
       
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
	
        
    
}