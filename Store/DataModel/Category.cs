using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataModel
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Product> ProductInCategory { get; set; }

        public Category() 
        {
            ProductInCategory = new List<Product>();
        }
        public Category(string name)
        {
            this.Name = name;
            ProductInCategory = new List<Product>();
        }
    }
}
