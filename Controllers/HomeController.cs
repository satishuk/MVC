using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFramework.Controllers
{
    public class HomeController : Controller
    {
	   public ActionResult Index()
	   {
		  ViewBag.Message = "Your application description page.";
		   

		  return View();
	   }

	   public ActionResult About()
	   {
		  ViewBag.Message = "MY application description page.";
		  ViewBag.Satish = "Developer";

		  return View();
	   }

	   public ActionResult Contact()
	   {
		  ViewBag.Message = "MY contact page.";

		  return View();
	   }

	    public ActionResult Laptop()
	    {
		    return View("About");
	    }
	   public ActionResult Development()
	   {
		   ViewBag.tempMessage = "Enter your comments";
		  return View();
	   }
	  [HttpPost]
	   public ActionResult Development(string taReachout,string emailid, string ssn)
	   {
		  ViewBag.tempMessage = "Thanks for submiting the commetns";
		  return View();
	   }
    }
}