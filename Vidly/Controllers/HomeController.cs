using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Vidly.Controllers
{
	public class HomeController : Controller
	{
		// / | /home
		public ActionResult Index()
		{
			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono" : ".NET";

			return View();
		}

		// /about
		public ActionResult About()
		{
			return View("About");
		}

		// /faq
		public ActionResult Faq()
		{
			return View("Faq");
		}

	}
}
