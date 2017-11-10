using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Order_item
    {
        public int order_item_ID { get; set; }
        public int order_ID { get; set; }
        public int product_ID { get; set; }
        public int quantity { get; set; }
        public double old_price { get; set; }
    }
}
