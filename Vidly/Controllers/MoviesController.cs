using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
		// /movies/{name?}
		public ActionResult Index(int? id)
		{
			var movies = new List<Movie>
			{
				new Movie() { Id = 1, Name = "Shrek", Category = "Kids" },
				new Movie() { Id = 2, Name = "Heat", Category = "Crime" },
				new Movie() { Id = 3, Name = "Django", Category = "Western" },
				new Movie() { Id = 4, Name = "Kung Fury", Category = "Action" },
				new Movie() { Id = 5, Name = "Hateful Eight", Category = "Western" },
			};

			var viewModel = new MoviesViewModel
			{
				Movies = movies,
				CurrentId = id
			};

			return View(viewModel);
        }
    }
}
