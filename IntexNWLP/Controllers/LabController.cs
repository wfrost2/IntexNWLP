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
using System.Web.Security;

namespace IntexNWLP.Controllers
{
    public class LabController : Controller
    {
        private NWLPContext db = new NWLPContext();

        // GET: Lab
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReceiveOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ReceiveOrder(FormCollection form)
        {
            string orderNum = form["Order"].ToString();
            int orderNum1 = Convert.ToInt32(orderNum);
            Order order = db.Order.Find(orderNum1);

            if (order != null)
            {
                IEnumerable <Assay> assay = db.Database.SqlQuery<Assay>("SELECT Assay.assayId, Assay.assayTypeId, LTNumber " +
                    "FROM Assay_Order INNER JOIN Assay " +
                    "ON Assay_Order.assayId = Assay.assayId " +
                    "INNER JOIN Assay_Type ON Assay.assayTypeId = Assay_Type.assayTypeId " +
                    "WHERE Assay_Order.orderId = " + order.orderId);

                IEnumerable<Compound_Sample> compoundsample = db.Database.SqlQuery<Compound_Sample>("SELECT compoundSampleId, compoundSequenceCode, Compound_Sample.LTNumber, quantity," +
                    " dateArrived, receivedBy, dateDue, appearance, weightIndicatedByCustomer, weightActual, molecularMass, maxToleratedDose " +
                    "FROM Compound_Sample, Compound, Assay_Order, Assay " +
                    "WHERE Assay_Order.orderId = " + order.orderId + " AND Assay_Order.assayId = Assay.assayId " +
                    "AND Assay.LTNumber = Compound.LTNumber AND Compound.LTNumber = Compound_Sample.LTNumber");


                TempData["assay"] = assay;
                TempData["compounds"] = compoundsample;
                TempData["order"] = order;




                return RedirectToAction("ShowOrderAssayInfo", "Lab");

            }
            else
            {
                ViewBag.notFound = "Your order number was not found";
                return View();

            }

        }

        public ActionResult ShowOrderAssayInfo()
        {

            //assign to viewbag
            ViewBag.Order = TempData["order"];
            ViewBag.Assays = TempData["assay"];
            ViewBag.Compound = TempData["compounds"];

            return View();
        }



        public ActionResult ChooseTest()
        {
            return View();
        }

        public ActionResult RecordTest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RecordTest(int parameters)
        {
            return View();
        }

    }
}