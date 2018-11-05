using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BoardRank.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[action]")]
    public class ApiController : Controller
    {
        public IActionResult GetValue()
        {
            return new OkObjectResult(new { value = 123 });
        }
    }
}
