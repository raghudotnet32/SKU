using Promotion.Calculator.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Promotion.Calculator.Tests
{
    public class ProductBTests : IDisposable
    {

        [Fact(DisplayName = "ProductBTestTotalPrice_Returns_Promotion_Price")]
        public void ProductBTestTotalPrice_Returns_Promotion_Price()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product("B", 2));
            //Assert
            var value = new ProductB<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(45);
        }

        [Fact(DisplayName = "ProductBTestTotalPrice_Returns_NonPromotion_Price")]
        public void ProductBTestTotalPrice_Returns_NonPromotion_Price()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product("B", 1));
            //Assert
            var value = new ProductA<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(30);
        }

        [Fact(DisplayName = "ProductBTestTotalPrice_Returns_Zero_OnNoProduct")]
        public void ProductBTestTotalPrice_Returns_Zero_OnNoProduct()
        {
            //Arrange
            List<Product> products = new List<Product>();

            //Assert
            var value = new ProductB<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(0);
        }

        public void Dispose()
        {

        }
    }
}

