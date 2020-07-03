using Promotion.Calculator.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Promotion.Calculator.Tests
{
    public class ProductATests : IDisposable
    {
        [Fact(DisplayName = "ProductATestTotalPrice_Returns_Promotion_Price")]
        public void ProductATestTotalPrice_Returns_Promotion_Price()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product("A", 3));
            //Assert
            var value = new ProductA<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(130);
        }

        [Fact(DisplayName = "ProductATestTotalPrice_Returns_NonPromotion_Price")]
        public void ProductATestTotalPrice_Returns_NonPromotion_Price()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product("A", 2));
            //Assert
            var value = new ProductA<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(100);
        }

        [Fact(DisplayName = "ProductATestTotalPrice_Returns_Zero_OnNoProduct")]
        public void ProductATestTotalPrice_Returns_Zero_OnNoProduct()
        {
            //Arrange
            List<Product> products = new List<Product>();

            //Assert
            var value = new ProductA<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(0);
        }

        public void Dispose()
        {

        }
    }
}
