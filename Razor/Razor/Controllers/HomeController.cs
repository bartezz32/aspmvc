using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product[] array =
            {
                new Product {Name = "Kyak", Price = 275M},
                new Product {Name = "Lifejack", Price = 49M},
                new Product {Name = "Foot ball", Price = 14M},
                new Product {Name = "Flag", Price = 25M}
            };
            return View(array);
        }
    }

}