using System.Threading.Tasks;

namespace PromotionEngine.Service.AutoPromotion.Promotion
{
    public class PromoForD : IPromotion
    {
        private readonly double itemPrice = 15;    //per item
        private readonly double offerPrice = 15;  //per offer group, in this case, no same item promo
        private readonly int multiplier = 1;

        public async Task<double> ApplyProductPromotionAsync(int noOfItems)
        {
            var totalPrice = 0.0;

            while (noOfItems != 0)
            {
                if (noOfItems < multiplier)
                {
                    totalPrice += noOfItems * itemPrice;
                    noOfItems /= multiplier;
                }
                else
                {
                    totalPrice += (noOfItems / multiplier) * offerPrice;
                    noOfItems %= multiplier;
                }
            }
            return totalPrice;
        }
    }
}
