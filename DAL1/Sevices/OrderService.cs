using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DAL.Entities;
using DAL;

namespace Services
{
    public class OrderService 
    {

        string connStr;

        public OrderService(string connStr)
        {
            this.connStr = connStr;
        }

        public Order getById(int id)
        {
            Order order = new Order();
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM shop.order WHERE order.order_ID=@order_ID";
                command.Parameters.AddWithValue("@order_ID", id);
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                order.order_ID = id;
                order.user_ID= int.Parse(dataReader["user_ID"].ToString());
                order.date = DateTime.Parse(dataReader["date"].ToString());
                order.isPaid = dataReader.GetBoolean(3);
                dataReader.Close();
            }
            return order;
        }

        public long add(Order obj)
        {
            long res;
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO shop.order (user_ID,date,isPaid) VALUES (@user_ID,@date,@isPaid)";
                command.Parameters.AddWithValue("@user_ID", obj.user_ID);
                command.Parameters.AddWithValue("@date", obj.date);
                command.Parameters.AddWithValue("@isPaid", obj.isPaid);
                connection.Open();
                command.ExecuteNonQuery();
                res = command.LastInsertedId;
            }
            return res;
        }

        public void update(Order obj)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE shop.order SET user_ID=@user_ID,date=@date,isPaid=@isPaid WHERE order.order_ID=@order_ID";
                command.Parameters.AddWithValue("@user_ID", obj.user_ID);
                command.Parameters.AddWithValue("@date", obj.date);
                command.Parameters.AddWithValue("@isPaid", obj.isPaid);
                command.Parameters.AddWithValue("@order_ID", obj.order_ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void delete(Order obj)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM order WHERE order_ID = @order_ID";
                command.Parameters.AddWithValue("@order_ID", obj.order_ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Order> getAll()
        {
            List<Order> orders= new List<Order>();
            Order order;

            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM shop.order";
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    order = new Order();
                    order.user_ID = int.Parse(dataReader["user_ID"].ToString());
                    order.isPaid = dataReader.GetBoolean(3);
                    order.date = DateTime.Parse(dataReader["date"].ToString());
                    order.order_ID= int.Parse(dataReader["order_ID"].ToString());
                    orders.Add(order);
                }
                dataReader.Close();
            }
            return orders;
        }
    }
}