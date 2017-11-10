using DAL.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUser_BL
{
    public class Product_BL
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

        public List<Product> getAllProduct() {
            ProductService productService = new ProductService(conn);
            return productService.getAll();
        }

        public Product getById(int id)
        {
            return (new ProductService(conn)).getById(id);
        }
    }
}
