using System.Web.Mvc;

namespace Vidly.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View("Index");
		}

		public ActionResult About()
		{
			return View("About");
		}

		public ActionResult Faq()
		{
			return View("Faq");
		}
	}
}
