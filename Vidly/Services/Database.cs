using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Services
{
	public static class Database
	{
		// Finds Movies based on a filter
		//
		// filter - delegate function that returns a bool
		//
		// returns a Movie List of matched Movies
		public static List<Movie> AllWithFilter( del filter )
		{
			var results = new List<Movie>();
			foreach (var item in All())
			{
				if (filter(item))
				{
					results.Add(item);
				}
			}
			return results;
		}

		// Gets all the Movies stored in the "database" *wink wink*
		//
		// returns a Movie List
		public static List<Movie> All()
		{
			return Contents;
		}



//--------------------------------------------------------------------------------------------------//



		// Database Contents
		public static List<Movie> Contents = new List<Movie>
		{
			new Movie()
			{
				Id = 1,
				Name = "Shrek",
				Category = "Kids",
				Description = "Shrek is a 2001 American computer-animated fantasy-comedy film directed by Andrew Adamson and Vicky Jenson in their directorial debut. It features the voices of Mike Myers, Eddie Murphy, Cameron Diaz, and John Lithgow. "
			},
			new Movie()
			{
				Id = 2,
				Name = "Heat",
				Category = "Crime",
				Description = "Heat is a 1995 American crime film written, produced and directed by Michael Mann, and starring Robert De Niro, Al Pacino, and Val Kilmer. De Niro plays Neil McCauley, a professional thief, while Pacino plays Lt. Vincent Hanna, a LAPD robbery-homicide detective tracking down McCauley's crew."
			},
			new Movie()
			{
				Id = 3,
				Name = "Django Unchained",
				Category = "Western",
				Description = "Django Unchained is a 2012 American revisionist Western film written and directed by Quentin Tarantino, starring Jamie Foxx, Christoph Waltz, Leonardo DiCaprio, Kerry Washington, and Samuel L. Jackson. Set in the Old West and Antebellum South, it is a highly stylized tribute to Spaghetti Westerns, in particular the 1966 film Django by Sergio Corbucci, whose star Franco Nero has a cameo appearance."
			},
			new Movie()
			{
				Id = 4,
				Name = "Kung Fury",
				Category = "Action",
				Description = "Kung Fury is a 2015 English-language Swedish martial arts action comedy short film written, directed by, and starring David Sandberg. It pays homage to 1980s martial arts and police action films."
			},
			new Movie()
			{
				Id = 5,
				Name = "Hateful Eight",
				Category = "Western",
				Description = "The Hateful Eight is a 2015 American revisionist Western mystery film written and directed by Quentin Tarantino. It stars Samuel L. Jackson, Kurt Russell, Jennifer Jason Leigh, Walton Goggins, Demián Bichir, Tim Roth, Michael Madsen, and Bruce Dern as eight strangers who seek refuge from a blizzard in a stagecoach stopover some time after the American Civil War."
			}
		};
	}
}
