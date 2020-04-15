using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.services;

namespace WebApplication1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GuidController : ControllerBase
	{
		private readonly IBusinessService service;

		public GuidController(IBusinessService service)
		{
			this.service = service;
		}

		// api/guid
		[HttpGet]
		public ActionResult<Guid> Get()
		{
			return service.GetGuid();
		}
	}
}
