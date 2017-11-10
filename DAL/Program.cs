using DAL.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.user_ID= 2;
            order.isPaid = false;
            order.date = DateTime.Now;
            OrderService orderServise = new OrderService("Database = shop; Data Source = localhost; User Id = Адмін; Password = 1234");
            orderServise.add(order);
        }
    }
}
