using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Vidly;
using Vidly.Services;
using Vidly.Models;

namespace Vidly.Tests
{
	[TestFixture]
	public class DatabaseTest
	{
		[Test]
		public void All()
		{
			var result = Database.All();
			Assert.IsNotEmpty(result);
		}

		[Test]
		public void AllWithFilter()
		{
			// Arrange
			del filter = (item) => item[2].ToLowerInvariant().Contains("west");
			// Act
			var result = Database.AllWithFilter(filter);
			//Assert
			Assert.AreEqual(2, result.Count());
		}
	}
}
