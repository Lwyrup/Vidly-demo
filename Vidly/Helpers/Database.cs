using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Helpers
{
	public static class MoviesHelper
	{
		// Pass in a list of movies and the id param
		//
		// array    - List of Movies
		// moviesId - Int of the url param
		// 
		// reuturns the Movie object with that Id or an error Movie
		private static List<Movie> FilterArrayById( List<Movie> array, int? filter )
		{
			foreach (var item in array)
			{
				if (item.Id == filter)
				{
					return new List<Movie> { item };
				}
			}
			return new List<Movie>
			{
				new Movie() { Name = "Oops! No movie here." }
			};
		}

		// Check for the id params
		//
		// array    - List of Movies
		// moviesId - Int of url param
		//
		// returns List of a Movie or nothing
		private static List<Movie> CheckforId( List<Movie> array, int? filter )
		{
			if (filter != null)
			{
				return FilterArrayById( array, filter );
			}
			{
				return array;
			}
		}

		// Gets Movies from the 'Database' *wink wink*
		//
		// returns List of Movies
		public static List<Movie> GetMovies()
		{
			var movies = new List<Movie>
			{
				new Movie() { Id = 1, Name = "Shrek", Category = "Kids", Description = "A fun time"},
				new Movie() { Id = 2, Name = "Heat", Category = "Crime" },
				new Movie() { Id = 3, Name = "Django", Category = "Western" },
				new Movie() { Id = 4, Name = "Kung Fury", Category = "Action" },
				new Movie() { Id = 5, Name = "Hateful Eight", Category = "Western" },
			};
			//return CheckforId( movies, filter );
			return movies;
		}
	}
}
