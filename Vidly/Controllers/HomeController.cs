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
			return View("Home");
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
