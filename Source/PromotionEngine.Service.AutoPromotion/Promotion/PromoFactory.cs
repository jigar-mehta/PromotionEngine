using System;

namespace PromotionEngine.Service.AutoPromotion.Promotion
{
    public class PromoFactory : IPromoFactory
    {
        public IPromotion CreateInstance(Items items)
        {
            switch (items)
            {
                
                default: return (IPromotion)null;
            }
        }
    }
}
