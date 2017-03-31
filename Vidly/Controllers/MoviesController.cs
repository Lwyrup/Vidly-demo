using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Vidly.Models;
using Vidly.ViewModels;
using Vidly.Helpers;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
		// /movies/{name?}
		public ActionResult Index(int? id)
		{
			// Get all the movies / or if and id is present, just that movie
			var result = MoviesHelper.GetMovies(id);

			// Insert the result into the view model
			var viewModel = new MoviesViewModel
			{
				Movies = result,
				CurrentMovieId = id
			};

			return View(viewModel);
        }
    }
}
