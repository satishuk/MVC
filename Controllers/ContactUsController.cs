using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFramework.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
	        ViewBag.message = "wel come to Contact page";
            return View();
        }
	   public ActionResult Development()
	   {
		  ViewBag.tempMessage = "Enter your comments Development";
		  return View();
	   }
	   [HttpPost]
	   public ActionResult Development(string taReachout, string emailid, string ssn)
	   {
		  ViewBag.tempMessage = "Thanks for submiting the commetns";
		  return View();
	   }

	   public ActionResult DefaultDevelopment()
	   {
		  ViewBag.tempMessage = "Enter your comments DefaultDevelopment";
		  return View("Development");
	   }
    }
}