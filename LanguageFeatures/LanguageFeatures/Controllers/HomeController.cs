using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            var products = new[]
            {
                new {Name = "Kyak", Price = 234M},
                new {Name = "Lifejack",Price=23M},
                new {Name="Foot ball",Price=34M},
                new {Name="Flag",Price=43M}
            };

            return View(products.Select(p=> $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}