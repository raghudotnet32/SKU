using System.Collections.Generic;

namespace Promotion.Calculator.Products
{
    interface IPromotion<T> where T : List<Product>
    {
        int ApplyPromotion();
    }
}
