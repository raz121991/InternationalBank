using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class ProductService
    {
        public  void AddProduct(string name, decimal price)
        {
            using (var context = new AppDbContext())
            {
                var product = new Product
                {
                    Name = name,
                    Price = price
                };

                context.Products.Add(product);
                context.SaveChanges(); 
                Console.WriteLine("Product added successfully.");
            }
        }


        public  void GetProducts()
        {
            using (var context = new AppDbContext())
            {
                var products = context.Products.ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.ProductId}, Name: {product.Name}, Price: {product.Price}");
                }
            }
        }

        public  void UpdateProduct(int productId, string newName, decimal newPrice)
        {
            using (var context = new AppDbContext())
            {
                var product = context.Products.Find(productId);
                if (product != null)
                {
                    product.Name = newName;
                    product.Price = newPrice;
                    context.SaveChanges(); // Save changes to the database
                    Console.WriteLine("Product updated successfully.");
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
        }

        public  void DeleteProduct(int productId)
        {
            using (var context = new AppDbContext())
            {
                var product = context.Products.Find(productId);
                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges(); 
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
        }

    }
}
