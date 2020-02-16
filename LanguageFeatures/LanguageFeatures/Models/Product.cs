using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; } = true;
        public bool NameBegginsWithS => Name?[0] == 'K';

        public Product(bool stock = true)
        {
            InStock = stock;
        }

        public static Product[] GetProducts()
        {

            Product kayak = new Product
            {
 
                Name = "Kyak",
                Category = "Water craft",
                Price = 275M
            };

            Product lifejacket = new Product(false)
            {
                Name = "Lifejack",
                Price = 48.95M
            };

            kayak.Related = lifejacket;

            return new Product[] {kayak, lifejacket,null};

        }
    }
}
