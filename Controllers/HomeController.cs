using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorFun.Models;

namespace RazorFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Home()
        {
            return View("Home");
        }

    }
}
