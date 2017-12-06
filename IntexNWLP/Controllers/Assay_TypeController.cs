using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IntexNWLP.DAL;
using IntexNWLP.Models;

namespace IntexNWLP.Controllers
{
    public class Assay_TypeController : Controller
    {
        private NWLPContext db = new NWLPContext();

        // GET: Assay_Type
        public ActionResult Index()
        {
            return View(db.Assay_Type.ToList());
        }

        // GET: Assay_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Type assay_Type = db.Assay_Type.Find(id);
            if (assay_Type == null)
            {
                return HttpNotFound();
            }
            return View(assay_Type);
        }

        // GET: Assay_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assay_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "assayTypeId,assayName,protocol,estNumDaysComplete,assayDescription")] Assay_Type assay_Type)
        {
            if (ModelState.IsValid)
            {
                db.Assay_Type.Add(assay_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assay_Type);
        }

        // GET: Assay_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Type assay_Type = db.Assay_Type.Find(id);
            if (assay_Type == null)
            {
                return HttpNotFound();
            }
            return View(assay_Type);
        }

        // POST: Assay_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "assayTypeId,assayName,protocol,estNumDaysComplete,assayDescription")] Assay_Type assay_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assay_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assay_Type);
        }

        // GET: Assay_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Type assay_Type = db.Assay_Type.Find(id);
            if (assay_Type == null)
            {
                return HttpNotFound();
            }
            return View(assay_Type);
        }

        // POST: Assay_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assay_Type assay_Type = db.Assay_Type.Find(id);
            db.Assay_Type.Remove(assay_Type);
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
