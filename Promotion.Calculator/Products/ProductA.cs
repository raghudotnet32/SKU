using System.Collections.Generic;
using System.Linq;

namespace Promotion.Calculator.Products
{
    public class ProductA<T> : IPriceCalculator<T>, IPromotion<T> where T : List<Product>
    {
        private readonly int price = 50;

        public ProductA(T tType)
        {
            this.product = tType.Where(x => x.Id == "A").SingleOrDefault();
        }

        private readonly Product product;

        public int ApplyPromotion()
        {
            return (product.Count / 3) * 130 + (product.Count % 3 * price);
        }

        public int CalculateProductPrice()
        {
            if (product is null)
                return 0;
            if (product.Count < 3)
                return product.Count * price;
            return ApplyPromotion();
        }
    }
}
