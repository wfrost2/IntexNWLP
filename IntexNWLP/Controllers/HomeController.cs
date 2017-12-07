using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IntexNWLP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: Home
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String username = form["Username"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(username, "Wyatt") && (string.Equals(password, "Frost")))
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);

                return RedirectToAction("Index", "CustomerPortal");

            }
            else if (string.Equals(username, "Lab") && (string.Equals(password, "password")))
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);

                return RedirectToAction("Index", "Lab");

            }
            else if (string.Equals(username, "Customer") && (string.Equals(password, "password")))
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);

                return RedirectToAction("Index", "CustomerPortal");

            }
            else 
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View();
        }
    }
}