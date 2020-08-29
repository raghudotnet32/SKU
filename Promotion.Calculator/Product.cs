using System;
using System.Collections.Generic;

namespace Promotion.Calculator
{
    public class Product
    {
        public string Id { get; set; }
        public int Count { get; set; }

        public string dummystring { get; set; }
        

        public Product(string input)
        {
            var itemDetails = input.Split('*');
            Id = itemDetails[1];
            Count = Convert.ToInt32(itemDetails[0]);
        }

        public Product(Tuple<string, int> input)
        {
            Id = input.Item1;
            Count = input.Item2;
        }

        public Product(string productId, int count)
        {
            Id = productId;
            Count = count;
        }
    }
}