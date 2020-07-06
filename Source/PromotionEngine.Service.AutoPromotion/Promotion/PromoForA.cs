using System.Threading.Tasks;

namespace PromotionEngine.Service.AutoPromotion.Promotion
{
    class PromoForA : IPromotion
    {
        private readonly double itemPrice = 50;    //per item
        private readonly double offerPrice = 130;  //per offer group, in this case 3items
        private readonly int multiplier = 3;

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
