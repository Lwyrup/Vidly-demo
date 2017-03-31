using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
	public class Movie
	{
		// Properties of a Movie
		public int    Id          { get; set; }
		public string Name        { get; set; }
		public string Category    { get; set; }
		public string Description { get; set; }
	}
}
