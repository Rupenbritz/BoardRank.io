using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BoardRank.Controllers
{
    [Route("home/[action]")]
    public class HomeController : Controller
    {
        [Route("/home")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
