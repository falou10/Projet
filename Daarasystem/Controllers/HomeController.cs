using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Daarasystem.Toubasoft.Service;

namespace Daarasystem.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
            ServiceSOSSoapClient servie = new ServiceSOSSoapClient();
            var op =  servie.AddEleve("", "", "");
            

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
	}
}