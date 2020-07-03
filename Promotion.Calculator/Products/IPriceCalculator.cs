using System.Collections.Generic;

namespace Promotion.Calculator.Products
{
    public interface IPriceCalculator<T> where T : List<Product>
    {
        int CalculateProductPrice();
    }
}