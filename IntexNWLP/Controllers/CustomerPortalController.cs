using IntexNWLP.DAL;
using IntexNWLP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            order.orderDate = DateTime.Now.ToString();
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
                compound_Sample.weightIndicatedByCustomer = Convert.ToDouble(form["weight"]);
                compound_Sample.quantity = Convert.ToDouble(form["quantity"]);
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
            return View();
        }
    }
}