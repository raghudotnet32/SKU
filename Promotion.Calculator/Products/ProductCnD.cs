using System.Collections.Generic;
using System.Linq;

namespace Promotion.Calculator.Products
{
    public class ProductCnD<T> : IPriceCalculator<T>, IPromotion<T> where T : List<Product>
    {
        private readonly int priceOfC = 20;
        private readonly int priceOfD = 15;
        private readonly int priceOfCnD = 30;
        private readonly Product productC;
        private readonly Product productD;

        public ProductCnD(T tType)
        {
            this.productC = tType.Where(x => x.Id == "C").SingleOrDefault();
            this.productD = tType.Where(x => x.Id == "D").SingleOrDefault();
        }

        public int ApplyPromotion()
        {
            if (productC.Count == productD.Count)
            {
                return productD.Count * priceOfCnD;
            }
            else if (productC.Count > productD.Count)
            {
                return ((productC.Count - productD.Count) * priceOfC) + productD.Count * priceOfCnD;
            }
            else
            {
                return productC.Count * priceOfCnD + ((productD.Count - productC.Count) * priceOfD);
            }
        }

        public int CalculateProductPrice()
        {
            if (productC is null && productD is null)
                return 0;
            if(productC is null)
                return (productD.Count * priceOfD);
            if (productD is null)
                return (productC.Count * priceOfC);

            return ApplyPromotion();
        }
    }
}
