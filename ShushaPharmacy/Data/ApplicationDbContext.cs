using ShushaPharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShushaPharmacy.Data
{
    public static class ApplicationDbContext
    {
        public static  List<User> Users { get; set; }
        public static  List<Order> Orders { get; set; }
        public static List<OrderDetail> OrderDetails { get; set; }
        public static List<Product> Products { get; set; }

        static ApplicationDbContext()
        {
            Users = new List<User>();
        }

    }
}
