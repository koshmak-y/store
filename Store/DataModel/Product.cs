using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataModel
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Product() 
        {
            Orders = new List<Order>();
        }
        public Product(string name, double price, Category category)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
            Orders = new List<Order>();
        }
    }
}
