using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShushaPharmacy.Models
{
    public class Order:Entity
    {
        public decimal TotalPrice { get; set; }
        public decimal GivedMoney { get; set; }
        public decimal Remainder { get; set; }
        public int UserId { get; set; }
        public int OrderStatus { get; set; }
    }
}
