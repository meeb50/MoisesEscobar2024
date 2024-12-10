using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoisesEscobar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Product
            {
                Name = "Coca-Cola Lata " + index,
                Description = "Bebida - La constancia",
                Price = 0.5m,
                UrlImage = "https://m.media-amazon.com/images/I/51v8nyxSOYL._SL1500_.jpg"
            })
            .ToArray();
        }
    }
}
