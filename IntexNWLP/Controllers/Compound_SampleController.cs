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
    public class Compound_SampleController : Controller
    {
        private NWLPContext db = new NWLPContext();

        // GET: Compound_Sample
        public ActionResult Index()
        {
            var compund_Sample = db.Compund_Sample.Include(c => c.Compound);
            return View(compund_Sample.ToList());
        }

        // GET: Compound_Sample/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compound_Sample compound_Sample = db.Compund_Sample.Find(id);
            if (compound_Sample == null)
            {
                return HttpNotFound();
            }
            return View(compound_Sample);
        }

        // GET: Compound_Sample/Create
        public ActionResult Create()
        {
            ViewBag.LTNumber = new SelectList(db.Compound, "LTNumber", "compoundName");
            return View();
        }

        // POST: Compound_Sample/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "compoundSampleId,compoundSequenceCode,quantity,dateArrived,receivedBy,dateDue,appearance,weightIndicatedByCustomer,weightActual,molecularMass,maxToleratedDose,LTNumber")] Compound_Sample compound_Sample)
        {
            if (ModelState.IsValid)
            {
                db.Compund_Sample.Add(compound_Sample);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LTNumber = new SelectList(db.Compound, "LTNumber", "compoundName", compound_Sample.LTNumber);
            return View(compound_Sample);
        }

        // GET: Compound_Sample/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compound_Sample compound_Sample = db.Compund_Sample.Find(id);
            if (compound_Sample == null)
            {
                return HttpNotFound();
            }
            ViewBag.LTNumber = new SelectList(db.Compound, "LTNumber", "compoundName", compound_Sample.LTNumber);
            return View(compound_Sample);
        }

        // POST: Compound_Sample/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "compoundSampleId,compoundSequenceCode,quantity,dateArrived,receivedBy,dateDue,appearance,weightIndicatedByCustomer,weightActual,molecularMass,maxToleratedDose,LTNumber")] Compound_Sample compound_Sample)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compound_Sample).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Lab", null);
            }
            ViewBag.LTNumber = new SelectList(db.Compound, "LTNumber", "compoundName", compound_Sample.LTNumber);
            return View(compound_Sample);
        }

        // GET: Compound_Sample/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compound_Sample compound_Sample = db.Compund_Sample.Find(id);
            if (compound_Sample == null)
            {
                return HttpNotFound();
            }
            return View(compound_Sample);
        }

        // POST: Compound_Sample/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Compound_Sample compound_Sample = db.Compund_Sample.Find(id);
            db.Compund_Sample.Remove(compound_Sample);
            db.SaveChanges();
            return RedirectToAction("Index", "Lab", null);
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
