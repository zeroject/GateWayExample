using domain;
using Microsoft.AspNetCore.Mvc;

namespace OrdersApi.Controllers
{
    [ApiController]
    public class OrderAPI : ControllerBase
    {
        [HttpGet]
        [Route("orders/{id}")]
        public IActionResult GetOrder(int id)
        {
            Order order = Database.GetOrder(id);
            return Ok(order);
        }

        [HttpPost]
        [Route("orders")]
        public IActionResult PostOrder(Order order)
        {
            Database.PostOrder(order);
            return Ok();
        }
    }
}
