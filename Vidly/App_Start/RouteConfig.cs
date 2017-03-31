﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			/* maps the following paths
			*  /movies/{id}
			*  /users/{id}
			*/
			routes.MapRoute(
				name: "Movies",
				url: "movies/{id}",
				defaults: new { controller = "Movies", action = "Index", id = UrlParameter.Optional }
			);

			// "{controller}/{id}"

			/* Deafult maps the following paths
			*  /
			*  /home
			*  /movies
			*  /users
			*/
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
