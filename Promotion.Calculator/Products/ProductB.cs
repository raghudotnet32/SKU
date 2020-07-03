using System.Collections.Generic;
using System.Linq;

namespace Promotion.Calculator.Products
{
    public class ProductB<T> : IPriceCalculator<T>, IPromotion<T> where T : List<Product>
    {
        private readonly int price = 30;

        public ProductB(T tType)
        {
            this.product = tType.Where(x => x.Id == "B").SingleOrDefault();
        }

        private readonly Product product;

        public int ApplyPromotion()
        {
            return (product.Count / 2) * 45 + (product.Count % 2 * price);
        }

        public int CalculateProductPrice()
        {
            if (product is null)
                return 0;
            if (product.Count < 2)
                return product.Count * price;
            return ApplyPromotion();
        }
    }
}
