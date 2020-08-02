using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("SimpleForm");

        public ViewResult ReceiveForm()
        {
            var name = Request.Form["name"];
            var city = Request.Form["city"];

            return View("Result", $"{name} live in {city}");
        }
    }
}