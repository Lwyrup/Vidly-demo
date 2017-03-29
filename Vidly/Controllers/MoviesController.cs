using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
		// /movies
        public ActionResult Index()
        {
			return Content("This is /movies");
        }

		// /movies/{name}
    }
}
