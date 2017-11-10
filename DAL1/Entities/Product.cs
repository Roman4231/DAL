using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Product
    {
        public int product_ID { get; set; }
        public string category { get; set; }
        public double price { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
