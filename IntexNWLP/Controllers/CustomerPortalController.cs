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
    public class CustomerPortalController : Controller
    {
        private NWLPContext db = new NWLPContext();

        // GET: CustomerPortal
        public ActionResult Index()
        {
            return View(db.Assay_Type.ToList());
        }

        public ActionResult CreateOrder()
        {
            return View(db.Assay_Type.ToList());
        }

        [HttpPost]
        public ActionResult CreateOrder(FormCollection form)
        {
            //create and save order
            Order order = new Order();
            order.orderDate = DateTime.Now;
            order.orderStatusId = 1;
            order.Order_Status = db.Order_Status.Find(order.orderStatusId);
            if (form["runConditionals"] != null)
            {
                order.runConditionals = "Y";
            }
            else
            {
                order.runConditionals = "N";
            }
            order.customerComments = form["comments"];
            order.customerId = 2; //change to active user id
            order.Customer = db.Customer.Find(order.customerId);
            db.Order.Add(order);
            db.SaveChanges();

            //create and save compound
            Compound compound = new Compound();
            compound.compoundName = form["compoundName"];
            compound.compoundDescription = form["compoundDescription"];
            db.Compound.Add(compound);
            db.SaveChanges();

            int numberOfSamples = Convert.ToInt32(form["numberOfSamples"]);
            //create and save compound samples
            for(int i=0; i < numberOfSamples; i++)
            {
                Compound_Sample compound_Sample = new Compound_Sample();
                compound_Sample.compoundSequenceCode = i;
                compound_Sample.LTNumber = compound.LTNumber;
                compound_Sample.weightIndicatedByCustomer = Convert.ToDecimal(form["weight"]);
                compound_Sample.quantity = Convert.ToDecimal(form["quantity"]);
                //string mtd = form["mtd"];
                //if(mtd != "")
                //{
                //    compound_Sample.maxToleratedDose = Convert.ToDouble(mtd);
                //}
                db.Compund_Sample.Add(compound_Sample);
                db.SaveChanges();
            }
            int assayTypeCount = db.Assay_Type.Count();
            for(int i = 1; i <= assayTypeCount; i++)
            {
                var test = form["assay-"+i.ToString()];
                if (test != null)
                {
                    Assay_Type assay_type = db.Assay_Type.Find(i);
                    if (assay_type != null)
                    {
                        Assay assay = new Assay();
                        assay.LTNumber = compound.LTNumber;
                        assay.assayTypeId = assay_type.assayTypeId;
                        db.Assay.Add(assay);
                        db.SaveChanges();

                        Assay_Order assay_order = new Assay_Order();
                        assay_order.assayId = assay.assayId;
                        assay_order.orderId = order.orderId;
                        db.Assay_Order.Add(assay_order);
                        db.SaveChanges();
                    }
                }
                
            }

            
            return View("OrderConfirmation", order);
        }

        public ActionResult Browse()
        {
            return View();
        }

        public ActionResult CheckStatus()
        {
            return View();
        }

        public ActionResult PastOrders()
        {
            int customerId = 2; //edit to be actual, logged in user
            IEnumerable<Order> orders = db.Database.SqlQuery<Order>("SELECT orderId, customerId, orderTotal, orderDate, customerComments, runConditionals, orderStatusId FROM [Order] WHERE customerId = " + customerId + " ");
            List<Order> lOrders = new List<Order>();
            foreach (Order order in orders)
            {
                order.Order_Status = db.Order_Status.Find(order.orderStatusId);
                lOrders.Add(order);
            }
            //List<Order> lOrders = db.Database.;
            //IEnumerable<Order> orders = db.Order.Where(s => s.customerId == customerId).OrderBy(s => s.orderDate);
            //TempData["orders"] = orders;

            ViewBag.Orders = lOrders;

            return View();
        }

        public ActionResult ViewAssays(int id)
        {
            int orderId = id;
            IEnumerable<Assay_Order> assay_orders = db.Database.SqlQuery<Assay_Order>(
                "SELECT * FROM [Assay_Order] WHERE  orderId = " + orderId + " ");
            List<Assay> lAssay = new List<Assay>();
            foreach(Assay_Order ao in assay_orders)
            {
                id = ao.assayId;
                Assay assay = db.Assay.Find(id);
                assay.Assay_Type = db.Assay_Type.Find(assay.assayTypeId);
                lAssay.Add(assay);
            }
            ViewBag.Assays = lAssay;
            return View();
        }
    }
}