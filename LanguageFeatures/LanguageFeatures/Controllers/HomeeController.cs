using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeeController : Controller
    {

        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart
            {
                Products = Product.GetProducts()
            };

            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Foot ball",Price = 19.50M},
                new Product{Name = "Flag",Price=34.90M}
            };

            Func<Product, bool> nameFilter = delegate(Product prod) { return prod?.Name?[0] == 'K'; };


            decimal priceFilterTotal = productArray
                .Filter(p => (p?.Price ?? 0) >=20)
                .TotalPrices();

            decimal nameFilterTotal = productArray
                .Filter(p => p?.Name?[0] == 'K')
                .TotalPrices();

            //decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
            //decimal nameFilterTotal = productArray.FilterByName('K').TotalPrices();

            return View("Index",new string[]
            {
                $"Total by price: {priceFilterTotal:C2}",
                $"Total by name: {nameFilterTotal:C2}"
            });
        }
        
    }
}
