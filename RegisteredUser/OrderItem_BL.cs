using DAL.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUser
{
    public class OrderItem_BL
    {
        string conn = "Database = shop; Data Source = localhost; User Id = Адмін; Password = 1234";

        public string Conn
        {
            get
            {
                return conn;
            }

            set
            {
                conn = value;
            }
        }

        public List<Order_item> getByOrderID(int orderID) 
        {
            List<Order_item> res=new List<Order_item>();
            foreach (Order_item order_item in (new OrderItemService(conn)).getAll()) {
                if (order_item.order_ID == orderID) {
                    res.Add(order_item);
                }
            }
            return res;
        }

        public List<Order_item> getAll() {
            return (new OrderItemService(conn)).getAll();
        }

        public void add(Order_item orderItem) {
            (new OrderItemService(conn)).add(orderItem);
        }

        public void delete(Order_item orderItem)
        {
            (new OrderItemService(conn)).delete(orderItem);
        }
    }
}
