using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataModel
{
    public class Order
    {
        public int orderId { get; set; }
        public DateTime timeCreatedOrder { get; set; }
        public double sum { get; set; }
        public bool IsChecked { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public string userName { get; set; }
        public ICollection<Product> Products { get; set; }
        public Order() 
        {
            Products = new List<Product>();
        }
        public Order(User user, double Sum)
        {
            Products = new List<Product>();
            this.user = user;
            this.userName = user.name;
            this.timeCreatedOrder = DateTime.Now;
            this.sum = Sum;
            this.IsChecked = false;
        }
    }
}
