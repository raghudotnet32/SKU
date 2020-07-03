using Promotion.Calculator.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Promotion.Calculator.Tests
{
    public class ProductCnDTests : IDisposable
    {

        [Fact(DisplayName = "ProductCnDTestTotalPrice_Returns_Promotion_Price")]
        public void ProductCnDTestTotalPrice_Returns_Promotion_Price()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product("C", 1));
            products.Add(new Product("D", 1));

            //Assert
            var value = new ProductCnD<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(30);
        }

        [Fact(DisplayName = "ProductCnDTestTotalPrice_Returns_ProductC_NonPromotion_Price")]
        public void ProductCnDTestTotalPrice_Returns_ProductC_NonPromotion_Price()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product("C", 1));

            //Assert
            var value = new ProductCnD<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(20);
        }

        [Fact(DisplayName = "ProductCnDTestTotalPrice_Returns_ProductD_NonPromotion_Price")]
        public void ProductCnDTestTotalPrice_Returns_ProductD_NonPromotion_Price()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product("D", 1));

            //Assert
            var value = new ProductCnD<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(15);
        }

        [Fact(DisplayName = "ProductCnDTestTotalPrice_Returns_Zero_OnNoProduct")]
        public void ProductCnDTestTotalPrice_Returns_Zero_OnNoProduct()
        {
            //Arrange
            List<Product> products = new List<Product>();

            //Assert
            var value = new ProductCnD<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(0);
        }

        public void Dispose()
        {

        }
    }
}

