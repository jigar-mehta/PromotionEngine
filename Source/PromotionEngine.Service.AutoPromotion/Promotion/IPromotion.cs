using System.Threading.Tasks;

namespace PromotionEngine.Service.AutoPromotion.Promotion
{
    public interface IPromotion
    {
        public Task<double> ApplyProductPromotionAsync(int noOfItems);
    }
}
