using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataModel
{
    public class User
    {
        public int userID { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public DateTime birthday { get; set; }
        public string password { get; set; }
        public bool IsManager { get; set; }

        public ICollection<Order> Orders { get; set; }

        public User()
        {
        }
        public User(string Name, string Mail, DateTime Birthday, string Password)
        {

            Orders = new List<Order>();
            this.name = Name;
            this.mail = Mail;
            this.birthday = Birthday;
            this.password = Password;
        }
    }
}
