using Promotion.Calculator.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Promotion.Calculator.Tests
{
    public class ProductATest : IDisposable
    {
        [Fact(DisplayName = "ProductA TotalPrice returns value")]
        public void ProductATotalPrice_Returns_Value()
        {
            //Arrange
            DataHelper data = new DataHelper();
            var products = data.GenerateData("A", 3);
            //Assert
            var value = new ProductA<List<Product>>(products).CalculateProductPrice();

            //Act
            value.Equals(130);
        }

        [Fact(DisplayName = "ProductA TotalPrice returns zero")]
        public void ProductATotalPrice_Returns_Zero()
        {
            //Arrange
            DataHelper data = new DataHelper();
            var products = data.GenerateData("B", 3);

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
