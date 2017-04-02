using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Vidly.Models;
using Vidly.ViewModels;
using Vidly.Services;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
		public ActionResult Index()
		{
			List<Movie> result = Movie.All();
			var viewModel = new MoviesViewModel { Movies = result };
			return View(viewModel);
        }

		public ActionResult Show(int id)
		{
			var result = Movie.ById(id);
			return View(result);
		}

		public ActionResult Search()
		{
			var result = Movie.Search(Request.Params);
			var viewModel = new MoviesViewModel { Movies = result };
			return View("Index", viewModel);
		}
    }
}
