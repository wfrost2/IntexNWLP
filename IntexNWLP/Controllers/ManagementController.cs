using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntexNWLP.Controllers
{
    public class ManagementController : Controller
    {
        [Authorize]
        // GET: Management
        public ActionResult Index()
        {
            return View();
        }
    }
}