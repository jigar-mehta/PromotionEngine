﻿using Microsoft.AspNetCore.Mvc;
using PromotionEngine.Service.AutoPromotion.Promotion;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PromotionEngine.Service.AutoPromotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromoController : ControllerBase
    {
        private readonly IPromoFactory myPromoFactory;
        private IPromotion myPromotion;

        public PromoController(IPromoFactory promoFactory)
        {
            myPromoFactory = promoFactory;
        }

        [HttpGet]
        public async Task<double> GetFinalPrice([FromBody] Dictionary<string, int> cartOrder)
        {
            var finalPrice = 0.0;
            foreach (var item in cartOrder)
            {
                myPromotion = myPromoFactory.CreateInstance((Items)Enum.Parse(typeof(Items), item.Key));
                if (myPromotion is null) continue;
                finalPrice += await myPromotion.ApplyProductPromotionAsync(item.Value);
            }

            return finalPrice;
        }

    }
}
