using Lab.Models;
using System;
using System.Collections.Generic;

namespace Lab
{
    class Program
    {
        public delegate bool CPrice(double upper500);
        public delegate double GDiscount(double discount);
        static void Main(string[] args)
        {
            Product prod = new Product();
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Asus", Price = 3000});
            products.Add(new Product { Name = "HP", Price = 1200 });
            products.Add(new Product { Name = "Acer", Price = 300 });
            products.Add(new Product { Name = "Apple", Price = 1000 });
            products.Add(new Product { Name = "Lenova", Price = 450 });
            Console.WriteLine("Please enter number ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                GetProduct(CheckPrice, GetDiscount, products);
            }
            else if (a == 2)
            {
                Console.Write("\nProduct Name:  ");
                string ProductName = Console.ReadLine();
                Console.Write("Product Price:  ");
                double PriceProduct = Convert.ToDouble(Console.ReadLine());
                products.Add(new Product { Name = ProductName, Price = PriceProduct });
                GetProduct(CheckPrice, GetDiscount, products);
            }
            else if (a == 3)
            {
                GetProduct(CheckPrice, GetDiscount, products);
                Console.Write("\nProduct Name:  ");
                string DelProduct = Console.ReadLine();

                foreach (var item in products)
                {
                    if (DelProduct == item.Name)
                    {
                        item.isDelete = true;
                    }
                }
                GetProduct(CheckPrice, GetDiscount, products);
            }
        }
        public static double GetDiscount(double discount)
        {
            var result = discount * 0.7;
            return result;
        }
        public static bool CheckPrice(double upper500)
        {
            return upper500 > 500;
        }
        public static void GetProduct(CPrice price, GDiscount discount, List<Product> list)
        {
            foreach (var item in list) {
                if (!item.isDelete)
                {
                    if (price(item.Price))
                    {
                        Console.WriteLine(item.Name + " " + discount(item.Price) + " Endirmli");
                    }
                    else
                    {
                        Console.WriteLine(item.Name + " " + item.Price);
                    }
                }              
            }
        }
    }
}
