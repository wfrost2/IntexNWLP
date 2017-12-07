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
    public class Assay_ResultController : Controller
    {
        private NWLPContext db = new NWLPContext();

        // GET: Assay_Result
        public ActionResult Index()
        {
            var assay_Result = db.Assay_Result.Include(a => a.Assay_Test);
            return View(assay_Result.ToList());
        }

        // GET: Assay_Result/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Result assay_Result = db.Assay_Result.Find(id);
            if (assay_Result == null)
            {
                return HttpNotFound();
            }
            return View(assay_Result);
        }

        // GET: Assay_Result/Create
        public ActionResult Create()
        {
            ViewBag.assayTestId = new SelectList(db.Assay_Test, "assayTestId", "assayTestId");
            return View();
        }

        // POST: Assay_Result/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "assayResultsId,assayTestFile,assayTestDescriptive,completeDate,assayTestId")] Assay_Result assay_Result)
        {
            if (ModelState.IsValid)
            {
                db.Assay_Result.Add(assay_Result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.assayTestId = new SelectList(db.Assay_Test, "assayTestId", "comments", assay_Result.assayTestId);
            return View(assay_Result);
        }

        // GET: Assay_Result/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Result assay_Result = db.Assay_Result.Find(id);
            if (assay_Result == null)
            {
                return HttpNotFound();
            }
            ViewBag.assayTestId = new SelectList(db.Assay_Test, "assayTestId", "comments", assay_Result.assayTestId);
            return View(assay_Result);
        }

        // POST: Assay_Result/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "assayResultsId,assayTestFile,assayTestDescriptive,completeDate,assayTestId")] Assay_Result assay_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assay_Result).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.assayTestId = new SelectList(db.Assay_Test, "assayTestId", "comments", assay_Result.assayTestId);
            return View(assay_Result);
        }

        // GET: Assay_Result/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Result assay_Result = db.Assay_Result.Find(id);
            if (assay_Result == null)
            {
                return HttpNotFound();
            }
            return View(assay_Result);
        }

        // POST: Assay_Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assay_Result assay_Result = db.Assay_Result.Find(id);
            db.Assay_Result.Remove(assay_Result);
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
