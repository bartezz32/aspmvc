using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Hello world";
            ViewBag.Time = DateTime.Now.ToString("HH:mm:ss");
        }

        public ViewResult List() => View();
    }
}