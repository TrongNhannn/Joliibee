using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;


namespace Ictshop.Areas.Admin.Controllers
{  
   
    public class DonHangsController : Controller
    {   
       private QLbanhang db = new QLbanhang();
        //
        // GET: /Admin/DonHangs/
        public ActionResult Index()
        {
            return View(db.Donhangs.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang donhang = db.Donhangs.Find(id);
            var chitiet = db.Chitietdonhangs.Include(d => d.Sanpham).Where(d => d.Madon == id).ToList();
            if (donhang == null)
            {
                return HttpNotFound();
            }
            return View(chitiet);
        }



        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang dhang = db.Donhangs.Find(id);
            if (dhang == null)
            {
                return HttpNotFound();
            }
            return View(dhang);
        }

        // POST: Admin/PhanQuyens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Madon,Ngaydat,Tinhtrang,MaNguoidung")] Donhang dh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dh);
        }

        // GET: Admin/PhanQuyens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang dh = db.Donhangs.Find(id);
            if (dh == null)
            {
                return HttpNotFound();
            }
            return View(dh);
        }

        // POST: Admin/PhanQuyens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Donhang dh = db.Donhangs.Find(id);
            db.Donhangs.Remove(dh);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

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