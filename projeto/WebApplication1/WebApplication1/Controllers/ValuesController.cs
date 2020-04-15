using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.services;

namespace WebApplication1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private readonly IBusinessService service;

		public ValuesController(IBusinessService service)
		{
			this.service = service;
		}

		// api/values/guid
		[HttpGet("guid")]
		public ActionResult<Guid> Get()
		{
			return service.GetGuid();
		}

		// api/values
		[HttpGet]
		public ActionResult<List<string>> GetAll()
		{
			return service.GetAll();
		}
	}
}
