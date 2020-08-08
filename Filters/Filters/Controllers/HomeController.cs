using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public IActionResult Index() => View("Message", "This is Index() method from HomeController");
            
        [RequireHttps]
        public IActionResult SecondAction() => View("Message", "This is SecondAction() method from HomeController");
   
    }
}