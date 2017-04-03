using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Vidly;
using Vidly.Models;

namespace Vidly.Tests
{
	[TestFixture]
	public class MovieTest
	{
		[Test]
		public void All()
		{
			// Act
			var result = Movie.All();
			// Assert
			Assert.IsNotEmpty(result);
		}

		[Test]
		public void ById()
		{
			// Arrange
			int id = 3;
			// Act
			var result = Movie.ById(id);
			// Assert
			Assert.IsInstanceOf<Movie>(result);
			Assert.AreEqual(id, result.Id);
		}

		[Test]
		public void ByName()
		{
			// Arrange
			string nameSearch = "shrek";
			// Act
			var result = Movie.ByName(nameSearch);
			// Assert
			Assert.IsInstanceOf<List<Movie>>(result);
			Assert.AreEqual(nameSearch, result[0].Name.ToLower());
		}

		[Test]
		public void ByCat()
		{
			// Arrange
			string categeory = "western";
			// Act
			var result = Movie.ByCat(categeory);
			// Assert
			Assert.GreaterOrEqual(result.Count(),2);
			Assert.AreEqual(categeory, result[0].Category.ToLower());
			Assert.AreEqual(categeory, result[1].Category.ToLower());
		}

		[Test]
		public void Search()
		{
			// Arrange
			NameValueCollection searchParams = new NameValueCollection();
			searchParams.Add("searchBy","name");
			searchParams.Add("value","kung fury");
			// Act
			var result = Movie.Search(searchParams);
			// Assert
			Assert.IsInstanceOf<List<Movie>>(result);
			Assert.AreEqual(searchParams["value"], result[0].Name.ToLower());
		}
	}
}
