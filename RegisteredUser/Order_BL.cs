using DAL.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUser
{
    public class Order_BL
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

        public Order getUnPaidOrder(int userID) {
            foreach (Order order in findUserOrders(userID)) {
                if (!order.isPaid) {
                    return order;
                }
            }

            return addOrder(userID);
        }

        public Order payForOrder(int orderID)
        {
            OrderService orderService = new OrderService(conn);
            Order order = (orderService).getById(orderID);

            order.isPaid = true;
            order.date = DateTime.Now;

            orderService.update(order);

            Order newOrder = new Order();
            newOrder.date = DateTime.Now;
            newOrder.isPaid = false;
            newOrder.user_ID = order.user_ID;

            orderService.add(newOrder);

            return newOrder;
        }

        public Order addOrder(int userID) {
            Order order = new Order();
            order.user_ID = userID;
            order.isPaid = false;
            order.date = DateTime.Now;
            
            OrderService orderService = new OrderService(conn);
            order.order_ID=(int)orderService.add(order);
            return order;
        }

        public List<Order> findUserOrders(int userID) {
            OrderService orderService = new OrderService(conn);
            List < Order > temp= orderService.getAll();
            List<Order> res = new List<Order>();
            foreach (Order order in temp) {
                if (order.user_ID == userID) {
                    res.Add(order);
                }
            }
            return res;
        }
    }
}
