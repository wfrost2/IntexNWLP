using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntexNWLP.Controllers
{
    public class LabController : Controller
    {
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