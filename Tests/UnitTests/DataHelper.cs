using Promotion.Calculator.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Promotion.Calculator.Tests
{
    public class DataHelper
    {
        public List<Product> GenerateData(string key, int value)
        {
            Dictionary<string, int> cart = new Dictionary<string, int>();
            cart.Add(key, value);
            return (from item in cart select new Product(item.Key, item.Value)).ToList();
        }
    }
}