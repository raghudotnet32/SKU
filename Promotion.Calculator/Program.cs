using Promotion.Calculator.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Promotion.Calculator
{
    class Program
    {
        static Dictionary<string, int> cart = new Dictionary<string, int>();
        public static void Main(string[] args)
        {


            Console.WriteLine("total number of order");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the type of product:A,B,C or D along with quantity Example: 3*A");
            for (int i = 0; i < a; i++)
            {
                string input = Console.ReadLine();
                Product product = new Product(input);
                if (cart.ContainsKey(product.Id))
                    cart[product.Id] += product.Count;
                else
                    cart.Add(product.Id, product.Count);
            }
            var products = (from item in cart select new Product(item.Key, item.Value)).ToList();
            int totalPrice = GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        private static int GetTotalPrice(List<Product> products)
        {
            var finalPrice = 0;
            finalPrice += new ProductA<List<Product>>(products.Where(x => x.Id == "A").ToList()).CalculateProductPrice();
            finalPrice += new ProductB<List<Product>>(products.Where(x => x.Id == "B").ToList()).CalculateProductPrice();
            finalPrice += new ProductCnD<List<Product>>(products.Where(x => x.Id == "C" || x.Id == "D").ToList()).CalculateProductPrice();
            return finalPrice;
        }
    }
}