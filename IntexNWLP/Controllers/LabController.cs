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
            var order = db.Order.Include(o => o.Customer).Include(o => o.Order_Status);
            return View(order.ToList());
        }

        public ViewResult StatusChange(int orderNumber)
        {

            return View();//create assay?)
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