using System.Collections.Generic;
using System.Collections.Specialized;
using Vidly.Services;

namespace Vidly.Models
{
	// Delegate to create filters for database
	public delegate bool del(string[] item);

	public static class MovieCollection
	{
		// Gets all the movies
		//
		// returns a List of Movie objects
		public static List<Movie> All()
		{
			return ConvertToMovieList(Database.All());
		}

		// Gets a single movie based off an id number
		//
		// id - UrlParameter sent
		//
		// returns a Movie object
		public static Movie ById(int id)
		{
			del filter = (item) => int.Parse(item[0]) == id;
			var result = Database.AllWithFilter(filter)[0];
			return CreateMovie(result);
		}

		// Get a Movie List that contains a string
		//
		// name - String
		//
		// returns a List of Movies
		public static List<Movie> ByName(string name)
		{
			del filter = (item) => item[1].ToLowerInvariant().Contains(name);
			return ConvertToMovieList(Database.AllWithFilter(filter));
		}

		// Gets Movies based on categeory
		//
		// categeory - String
		//
		// reuturns a List of Movies
		public static List<Movie> ByCat(string categeory)
		{
			del filter = (item) => item[2].ToLowerInvariant().Contains(categeory);
			return ConvertToMovieList(Database.AllWithFilter(filter));
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



		// Converts assocaite lists into movie lists
		//
		// rawData - List<string>
		//
		// returns the List<string> as a List<Movie>
		private static List<Movie> ConvertToMovieList(List<string[]> rawData)
		{
			var converted = new List<Movie>();
			foreach (string[] row in rawData)
			{
				converted.Add(CreateMovie(row));
			}
			return converted;
		}

		// Turns an array of strings into a Movie
		//
		// movieProperties - string[] 
		//
		// returns a Movie object
		private static Movie CreateMovie(string[] movieProperties)
		{
			return new Movie
			{
				Id = int.Parse(movieProperties[0]),
				Name = movieProperties[1],
				Category = movieProperties[2],
				Description = movieProperties[3]
			};
		}

	}
}
