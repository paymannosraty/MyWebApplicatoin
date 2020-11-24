using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApplication.Controllers
{
	public class CountriesController : Infrastructure.BaseApiController
	{
		public CountriesController() : base()
		{
		}

		/// <summary>
		/// for retereiv data of Countries
		/// </summary>
		/// <returns>
		/// IEnumerable of Countries
		/// </returns>
		[HttpGet]
		public ActionResult<IEnumerable<Models.Country>> Get()
		{
			var result =
				new Models.Country()
				{
					Name = "Iran",
					Population = 85000000,
				};

			return Ok(value: result);
		}
	}
}
