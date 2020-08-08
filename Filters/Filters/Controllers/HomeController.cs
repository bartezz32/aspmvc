using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filters.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [ViewResultDetails]
    public class HomeController : Controller
    {
        public IActionResult Index() => View("Message", "This is Index() method from HomeController");
            
        public IActionResult SecondAction() => View("Message", "This is SecondAction() method from HomeController");
    }
}