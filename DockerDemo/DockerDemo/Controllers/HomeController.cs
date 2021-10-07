using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Route("getAllName")]
        [HttpGet]
        [ProducesResponseType(200,Type = typeof(string))]
        public async Task<IActionResult> GetAllNames()
        {
            var result = new List<string>()
            {
                "Duc",
                "Nguyen"
            };
            return Ok(result);

        }
    }
}
