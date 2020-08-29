using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View(new string[] {"Apples", "Oranges", "Pears"});

        public ViewResult List() => View();
    }
}