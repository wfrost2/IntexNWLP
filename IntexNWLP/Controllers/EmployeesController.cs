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
    public class EmployeesController : Controller
    {
        private NWLPContext db = new NWLPContext();

        // GET: Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Offices).Include(e => e.Roles);
            return View(employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employees = db.Employees.Find(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.officeId = new SelectList(db.Offices, "officeId", "officeName");
            ViewBag.roleId = new SelectList(db.Roles, "roleId", "roleName");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "employeeId,employeeFirstName,employeeLastName,employeeAddress1,employeeAddress2,employeeCity,employeeState,employeeZip,employeePhonePersonal,employeePhoneWork,employeeEmail,officeId,roleId")] Employees employees)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.officeId = new SelectList(db.Offices, "officeId", "officeName", employees.officeId);
            ViewBag.roleId = new SelectList(db.Roles, "roleId", "roleName", employees.roleId);
            return View(employees);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employees = db.Employees.Find(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            ViewBag.officeId = new SelectList(db.Offices, "officeId", "officeName", employees.officeId);
            ViewBag.roleId = new SelectList(db.Roles, "roleId", "roleName", employees.roleId);
            return View(employees);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "employeeId,employeeFirstName,employeeLastName,employeeAddress1,employeeAddress2,employeeCity,employeeState,employeeZip,employeePhonePersonal,employeePhoneWork,employeeEmail,officeId,roleId")] Employees employees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.officeId = new SelectList(db.Offices, "officeId", "officeName", employees.officeId);
            ViewBag.roleId = new SelectList(db.Roles, "roleId", "roleName", employees.roleId);
            return View(employees);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employees = db.Employees.Find(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employees employees = db.Employees.Find(id);
            db.Employees.Remove(employees);
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
