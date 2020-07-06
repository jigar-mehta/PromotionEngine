using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PromotionEngine.Service.AutoPromotion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromoController : ControllerBase
    {
        public PromoController()
        {

        }

        [HttpGet]
        public string GetFinalPrice([FromBody] Dictionary<string, int> cartOrder)
        {
            return string.Empty;
        }

    }
}
