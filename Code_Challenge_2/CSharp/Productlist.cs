using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    // Products Class
    class Products
    {
        public int Productid { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }

    
    class Productlist
    {
        static void Main(string[] args)
        {
            
            List<Products> products = new List<Products>();

           
            for (int i = 1; i <= 10; i++)
            {
                Products p = new Products();
                p.Productid = i;
                Console.Write($" Enter name for product {i}: ");
                p.ProductName = Console.ReadLine();
                Console.Write($" Enter price for product {i}: ");
                p.ProductPrice = decimal.Parse(Console.ReadLine());
                products.Add(p);
            }

            // Sort products using LINQ OrderBy method
            List<Products> sortedProducts = products.OrderBy(p => p.ProductPrice).ToList();

            // Display sorted products
            Console.WriteLine("\n\n Sorted Products by Price:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($" Product ID: {product.Productid},   Name: {product.ProductName},   Price: {product.ProductPrice}");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ Program Execute Successfully. ~ ~ ~ ~");
            Console.WriteLine(" Please Click Any Key To Exit.");
            Console.ReadKey();
        }
    }
}

