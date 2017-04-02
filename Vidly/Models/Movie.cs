using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Services;

namespace Vidly.Models
{
	public class Movie
	{
		// Properties of a Movie
		public int    Id          { get; set; }
		public string Name        { get; set; }
		public string Category    { get; set; }
		public string Description { get; set; }

		// Gets all the movies
		//
		// returns a List of Movie objects
		public static List<Movie> All()
		{
			return Database.All();
		}

		// Gets a single movie based off an id number
		//
		// returns a Movie object
		public static Movie ById(int id)
		{
			return Database.AllWithFilter(id);
		}
	}
}
