using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;
using MySql.Data.MySqlClient;

namespace Services
{
    public class ProductService 
    {

        string connStr;

        public ProductService(string connStr)
        {
            this.connStr = connStr;
        }

        public Product getById(int id)
        {
            Product product = new Product();
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM product WHERE product.product_ID=@product_ID";
                command.Parameters.AddWithValue("@product_ID", id);
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                product.product_ID= id;
                product.name= dataReader["name"].ToString();
                product.category= dataReader["category"].ToString();
                product.price= double.Parse(dataReader["price"].ToString());
                product.description = dataReader["description"].ToString();
                dataReader.Close();
            }
            return product;
        }

        public long add(Product obj)
        {
            long res;
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO product (name,category,price,description) VALUES(@name,@category,@price,@description)";
                command.Parameters.AddWithValue("@name", obj.name);
                command.Parameters.AddWithValue("@category", obj.category);
                command.Parameters.AddWithValue("@price", obj.price);
                command.Parameters.AddWithValue("@description", obj.description);
                connection.Open();
                command.ExecuteNonQuery();
                res = command.LastInsertedId;
            }
            return res;
        }

        public void update(Product obj)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE product SET name=@name,category=@category,price=@price,description=@description WHERE product_ID=@product_ID";
                command.Parameters.AddWithValue("@name", obj.name);
                command.Parameters.AddWithValue("@category", obj.category);
                command.Parameters.AddWithValue("@price", obj.price);
                command.Parameters.AddWithValue("@description", obj.description);
                command.Parameters.AddWithValue("@product_ID", obj.product_ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void delete(Product obj)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM product WHERE product_ID = @product_ID";
                command.Parameters.AddWithValue("@product_ID", obj.product_ID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Product> getAll()
        {
            List<Product> products = new List<Product>();
            Product product;

            using (MySqlConnection connection = new MySqlConnection(connStr))
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM product";
                connection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    product = new Product();
                    product.product_ID= int.Parse(dataReader["product_ID"].ToString());
                    product.price= double.Parse(dataReader["price"].ToString());
                    product.name= dataReader["name"].ToString();
                    product.category= dataReader["category"].ToString();
                    product.description = dataReader["description"].ToString();
                    products.Add(product);
                }
                dataReader.Close();
            }
            return products;
        }
    }
}