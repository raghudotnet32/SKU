using Promotion.Calculator.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Promotion.Calculator.Tests
{
    public class ProductBTest : IDisposable
    {

        [Fact(DisplayName = "ProductB TotalPrice returns value")]
        public void ProductBTotalPrice_Returns_Value()
        {
            //Arrange
            DataHelper data = new DataHelper();
            var products = data.GenerateData("B", 2);
            //Assert
            var value = new ProductB<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(45);
        }

        [Fact(DisplayName = "ProductB TotalPrice returns zero")]
        public void ProductBTotalPrice_Returns_Zero()
        {
            //Arrange
            DataHelper data = new DataHelper();
            var products = data.GenerateData("A", 3);

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

