using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace project_cthulhu.Controllers {
	[Route("api/[controller]")]
	public class ValuesController : Controller {
		// GET: api/<controller>
		[HttpGet]
		public IEnumerable<string> Get() {
			return new string[] { "value1", "value2" };
		}

		// GET api/<controller>/5
		[HttpGet("{id}")]
		public string Get(int id) {
			return "value";
		}
	}
}
