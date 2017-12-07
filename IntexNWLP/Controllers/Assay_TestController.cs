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
    public class Assay_TestController : Controller
    {
        private NWLPContext db = new NWLPContext();

        // GET: Assay_Test
        public ActionResult Index()
        {
            var assay_Test = db.Assay_Test.Include(a => a.Assay).Include(a => a.Compound_Sample).Include(a => a.Test).Include(a => a.Test_Result);
            return View(assay_Test.ToList());
        }

        // GET: Assay_Test/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Test assay_Test = db.Assay_Test.Find(id);
            if (assay_Test == null)
            {
                return HttpNotFound();
            }
            return View(assay_Test);
        }

        // GET: Assay_Test/Create
        public ActionResult Create(int id, int oid)
        {
            TempData["oid"] = oid;
            TempData["id"] = id;
            ViewBag.compoundSampleId = new SelectList(db.Compund_Sample, "compoundSampleId", "compoundSampleId");
            ViewBag.testId = new SelectList(db.Test, "testId", "testName");
            ViewBag.testResultId = new SelectList(db.Test_Result, "testResultId", "testResultId");
            return View();
        }

        // POST: Assay_Test/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "assayTestId,assayTestDate,assayTestCost,assayTestHours,basePrice,comments,testId,compoundSampleId,testResultId")] Assay_Test assay_Test)
        {
            if (ModelState.IsValid)
            {
                int oid1 = Convert.ToInt32(TempData["oid"]);
                assay_Test.assayId = ViewBag.id;
                
                
                db.Assay_Test.Add(assay_Test);
                db.SaveChanges();
                return RedirectToAction("ReceiveOrderFrom", "Lab", new { id = oid1 });
            }

            ViewBag.assayId = new SelectList(db.Assay, "assayId", "assayId", assay_Test.assayId);
            ViewBag.compoundSampleId = new SelectList(db.Compund_Sample, "compoundSampleId", "receivedBy", assay_Test.compoundSampleId);
            ViewBag.testId = new SelectList(db.Test, "testId", "testName", assay_Test.testId);
            ViewBag.testResultId = new SelectList(db.Test_Result, "testResultId", "testResultId", assay_Test.testResultId);
            return View(assay_Test);
        }

        // GET: Assay_Test/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Test assay_Test = db.Assay_Test.Find(id);
            if (assay_Test == null)
            {
                return HttpNotFound();
            }
            ViewBag.assayId = new SelectList(db.Assay, "assayId", "assayId", assay_Test.assayId);
            ViewBag.compoundSampleId = new SelectList(db.Compund_Sample, "compoundSampleId", "receivedBy", assay_Test.compoundSampleId);
            ViewBag.testId = new SelectList(db.Test, "testId", "testName", assay_Test.testId);
            ViewBag.testResultId = new SelectList(db.Test_Result, "testResultId", "testResultId", assay_Test.testResultId);
            return View(assay_Test);
        }

        // POST: Assay_Test/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "assayTestId,assayTestDate,assayTestCost,assayTestHours,basePrice,comments,assayId,testId,compoundSampleId,testResultId")] Assay_Test assay_Test)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assay_Test).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.assayId = new SelectList(db.Assay, "assayId", "assayId", assay_Test.assayId);
            ViewBag.compoundSampleId = new SelectList(db.Compund_Sample, "compoundSampleId", "receivedBy", assay_Test.compoundSampleId);
            ViewBag.testId = new SelectList(db.Test, "testId", "testName", assay_Test.testId);
            ViewBag.testResultId = new SelectList(db.Test_Result, "testResultId", "testResultId", assay_Test.testResultId);
            return View(assay_Test);
        }

        // GET: Assay_Test/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assay_Test assay_Test = db.Assay_Test.Find(id);
            if (assay_Test == null)
            {
                return HttpNotFound();
            }
            return View(assay_Test);
        }

        // POST: Assay_Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assay_Test assay_Test = db.Assay_Test.Find(id);
            db.Assay_Test.Remove(assay_Test);
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
