using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
		public ActionResult Index()
		{
			return View(MovieCollection.All());
        }

		public ActionResult Show(int id)
		{
			return View(MovieCollection.ById(id));
		}

		public ActionResult Search()
		{
			return View(MovieCollection.Search(Request.Params));
		}
    }
}
