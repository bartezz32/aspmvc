using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingViewComponents.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product newProduct);
    }


    public class MemoryProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>
        {
            new Product{Name = "Kayak", Price = 275M},
            new Product{Name="Lifejacket", Price = 48.25M},
            new Product{Name = "Foot ball",Price = 10.5M}
        };

        public IEnumerable<Product> Products => products;

        public void AddProduct(Product newProduct)
        {
            products.Add(newProduct);
        }

    } 
}
