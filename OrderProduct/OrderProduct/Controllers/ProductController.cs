using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderProduct.BusinessLayer.Concrete;
using OrderProduct.DataLayer.Concrete.EntityFramework;

namespace OrderProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductManager productManager = new ProductManager(new EfCoreProductRepository());

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            var product = await productManager.GetAll();
            return Ok(product);
        }


    }
}
