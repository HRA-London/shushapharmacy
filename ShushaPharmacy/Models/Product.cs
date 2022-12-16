using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShushaPharmacy.Models
{
    public class Product:Entity
    {
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int ProductType { get; set; }
        public byte ListCount { get; set; }
        public byte CountInList { get; set; }
        public bool HasSaleAsList { get; set; }
        public bool HasSaleAsOne { get; set; }


    }
}
