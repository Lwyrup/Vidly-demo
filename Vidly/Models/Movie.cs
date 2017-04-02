using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using Vidly.Services;


namespace Vidly.Models
{	
	// Delegate to create filters for database
	public delegate bool del(Movie item);

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
		// id - UrlParameter sent
		//
		// returns a Movie object
		public static Movie ById(int id)
		{
			del filter = (item) => item.Id == id;
			return Database.AllWithFilter(filter)[0];
		}

		// Get a Movie List that contains a string
		//
		// name - String
		//
		// returns a List of Movies
		public static List<Movie> ByName(string name)
		{
			del filter = (item) => item.Name.ToLowerInvariant().Contains(name);
			return Database.AllWithFilter(filter);
		}

		// Gets Movies based on categeory
		//
		// categeory - String
		//
		// reuturns a List of Movies
		public static List<Movie> ByCat(string categeory)
		{
			del filter = (item) => item.Category.ToLowerInvariant().Contains(categeory);
			return Database.AllWithFilter(filter);
		}

		// Handles searches and calls the correct function based on the 'searchBy' String
		//
		// query - Request.Params
		//
		// returns a Movie List
		public static List<Movie> Search(NameValueCollection query)
		{
			string method = query["searchBy"].ToLowerInvariant();
			string queryVal = query["value"].ToLowerInvariant();
			if (method == "name") { return ByName(queryVal); }
			if (method == "categeory") { return ByCat(queryVal); }
			else { return All(); }
		}
	}
}
