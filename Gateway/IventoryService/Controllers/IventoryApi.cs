using domain;
using Microsoft.AspNetCore.Mvc;

namespace IventoryService.Controllers
{
    [ApiController]
    public class IventoryApi : ControllerBase
    {
        [HttpGet]
        [Route("inventory{id}")]
        public IActionResult GetInventory(int id)
        {
            Iventory iventory = Database.GetInventory(id);
            return Ok(iventory);
        }
    }
}
