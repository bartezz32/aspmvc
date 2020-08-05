﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Hello";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        public ViewResult Result() => View((object) "Hello world!");

        public RedirectToRouteResult Redirect() => RedirectToRoute(new
        {
            controller = "Example",
            action = "Index",
            ID = "MyID"
        });
    }
}