using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class Order
    {
        public int order_ID { get; set; }
        public int user_ID { get; set; }
        public DateTime date { get; set; }
        public bool isPaid { get; set; }
    }
}
