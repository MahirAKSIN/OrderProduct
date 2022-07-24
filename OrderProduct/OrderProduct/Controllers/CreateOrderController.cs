using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderProduct.BusinessLayer.Concrete;
using OrderProduct.DataLayer.Concrete.EntityFramework;
using OrderProduct.EntityLayer;

namespace OrderProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CreateOrderController : ControllerBase
    {

        CreateOrderManager createOrderManager = new CreateOrderManager(new EfCoreCreateOrderRepository());


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCreateOder(int id)
        {
            var createOrder = await createOrderManager.GetById(id);
            if (createOrder == null)
            {
                return NotFound();
            }
            return Ok(createOrder);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrder entity)
        {
            await createOrderManager.CreateAsync(entity);
            return CreatedAtAction(nameof(GetCreateOder), new { id = entity.Id }, entity);
        }
    }
}
