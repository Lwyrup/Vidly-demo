using System.Collections.Generic;
using Vidly.Models;
using Microsoft.VisualBasic.FileIO;

namespace Vidly.Services
{
	public static class Database
	{
		// Finds rows based on a filter
		//
		// filter - delegate function that returns a bool
		//
		// returns a List of string Arrays that match the filter
		public static List<string[]> AllWithFilter( del filter )
		{
			var results = new List<string[]>();
			foreach (var item in All())
			{
				if (filter(item))
				{
					results.Add(item);
				}
			}
			return results;
		}

		// Gets all the rows stored in the "csv database"
		//
		// returns a List of string Arrays
		public static List<string[]> All()
		{
			var parser = CreateTextParser();
			var fileText = new List<string[]>();
			addRows(parser, fileText);
			return fileText;
		}

		// Creates the parsers
		//
		// returns the TextFieldParser object
		private static TextFieldParser CreateTextParser()
		{
			var parser = new TextFieldParser("Data/Movies.csv");
			SetParserDefaults(parser);
			return parser;
		}

		// Sets TextFieldParser options for the csv
		private static void SetParserDefaults(TextFieldParser parser)
		{
			parser.TextFieldType = FieldType.Delimited;
			parser.SetDelimiters(new string[] { "," });
		}

		// Adds all csv rows to a List
		//
		// parser   - TextFieldParser
		// fileText - List<string[]>
		private static void addRows(TextFieldParser parser, List<string[]> fileText)
		{
			while (!parser.EndOfData)
			{
				string[] row = parser.ReadFields();
				fileText.Add(row);
			}
		}
	}
}
