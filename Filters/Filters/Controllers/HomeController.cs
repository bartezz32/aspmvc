using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filters.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [Message("Global range of a controller", Order = 10)]
    public class HomeController : Controller
    {
        [Message("First filter of an action", Order = 1)]
        [Message("Second filter of an action", Order = 1)]
        public IActionResult Index() => View("Message", "This is Index() method from HomeController");
    }
}