using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Product
    {
        public int product_ID { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public string name { get; set; }
    }
}
