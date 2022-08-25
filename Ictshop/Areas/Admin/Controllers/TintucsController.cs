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
    public class TintucsController : Controller
    {
      private   QLbanhang db = new QLbanhang();
        // GET: /Admin/Tintucs/
        public ActionResult Index()
        {
            return View(db.Tintucs.ToList());
        }

        // GET: Admin/Hedieuhanhs/Details/5
        public ActionResult Details(int? id)
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
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Hedieuhanhs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tieude,Noidung,Hinhanh,MaNguoidung")] Tintuc tt)
        {
            if (ModelState.IsValid)
            {
                db.Tintucs.Add(tt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tt);
        }

        // GET: Admin/Hedieuhanhs/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Admin/Hedieuhanhs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tieude,Noidung,Hinhanh,MaNguoidung")] Tintuc hedieuhanh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hedieuhanh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hedieuhanh);
        }

        // GET: Admin/Hedieuhanhs/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Admin/Hedieuhanhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tintuc hedieuhanh = db.Tintucs.Find(id);
            db.Tintucs.Remove(hedieuhanh);
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