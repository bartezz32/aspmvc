﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class MemoryRepository : IRepository
    {
        private IModelStorage storage;


        public MemoryRepository(IModelStorage modelStorage)
        {
            storage = modelStorage;
            new List<Product>
            {
                  new Product{ Name = "Kayak", Price = 275M},
                  new Product{ Name = "Life jacket", Price = 48.95M},
                  new Product{Name = "Foot ball", Price = 19.50M}
            }.ForEach(p => AddProduct(p));
        }

        public IEnumerable<Product> Products => storage.Items;

        public Product this[string name] => storage[name];

        public void AddProduct(Product product) => storage[product.Name] = product;

        public void DeleteProduct(Product product) => storage.RemoveItem(product.Name);
    }
}
