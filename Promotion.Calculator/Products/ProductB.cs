using System.Collections.Generic;
using System.Linq;

namespace Promotion.Calculator.Products
{
    public class ProductB<T> : IPriceCalculator<T>, IPromotion<T> where T : List<Product>
    {
        public int ApplyPromotion()
        {
            throw new System.NotImplementedException();
        }

        public int CalculateProductPrice()
        {
            throw new System.NotImplementedException();
        }
    }
}