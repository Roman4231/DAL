using DAL.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static ProductService productService;

        static void Main(string[] args)
        {
            productService = new ProductService("Database = shop; Data Source = localhost; User Id = Адмін; Password = 1234");
            addProduct(generateProduct(1, 15));
            int i = 0;
        }

        static List<Product> generateProduct(int lastIndex,int amount)
        {
            List<Product> res =new List<Product>();

            Random random = new Random();

            for (int i = lastIndex; i < lastIndex + amount; i++) {
                Product product = new Product();
                product.name = "ItemName" + i;
                product.category = "ItemCategory" + random.Next(i);
                product.price= random.Next(1,i);
                product.description = "Description"+i;
                res.Add(product);
            }
            return res;
        }

        static void addProduct(List<Product> arr){
            foreach (Product i in arr) {
                productService.add(i);
            }
        }
    }
}
