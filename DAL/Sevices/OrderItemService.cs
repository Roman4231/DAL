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
    class OrderItemService
    {

        string connStr;

        public OrderItemService(string connStr)
        {
            this.connStr = connStr;
        }

        public Order_item getById(int id)
        {
            Order_item order_item = new Order_item();
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM order_item WHERE order_item.order_item_ID=@order_item_ID";
                command.Parameters.AddWithValue("@order_item_ID", id);
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                order_item.order_item_ID = id;
                order_item.order_ID= int.Parse(dataReader["order_ID"].ToString());
                order_item .product_ID= int.Parse(dataReader["product_ID"].ToString());
                order_item.quantity = int.Parse(dataReader["quantity"].ToString());
                dataReader.Close();
            }
            return order_item;
        }

        public void add(Order_item obj)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO shop.order_item (order_ID,product_ID,quantity) VALUES (@order_ID,@product_ID,@quantity)";
                command.Parameters.AddWithValue("@order_ID", obj.order_ID);
                command.Parameters.AddWithValue("@product_ID", obj.product_ID);
                command.Parameters.AddWithValue("@quantity", obj.quantity);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void update(Order_item obj)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE order_item SET order_ID=@order_ID,product_ID=@product_ID,quantity=@quantity WHERE order_item_ID=@order_item_ID";
                command.Parameters.AddWithValue("@order_ID", obj.order_ID);
                command.Parameters.AddWithValue("@product_ID", obj.product_ID);
                command.Parameters.AddWithValue("@quantity", obj.quantity);
                command.Parameters.AddWithValue("@order_item_ID", obj.order_item_ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void delete(Order_item obj)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM order_item WHERE order_item_ID = @order_item_ID";
                command.Parameters.AddWithValue("@order_item_ID", obj.order_item_ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Order_item> getAll()
        {
            List<Order_item> orders = new List<Order_item>();
            Order_item order_item;

            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM order_item";
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    order_item = new Order_item();
                    order_item.order_item_ID = int.Parse(dataReader["order_item_ID"].ToString());
                    order_item.order_ID= int.Parse(dataReader["order_ID"].ToString());
                    order_item.product_ID = int.Parse(dataReader["product_ID"].ToString());
                    order_item.quantity= int.Parse(dataReader["quantity"].ToString());
                    orders.Add(order_item);
                }
                dataReader.Close();
            }
            return orders;
        }
    }
}