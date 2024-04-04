using domain;
using Microsoft.AspNetCore.Mvc;

namespace Product_Catalog_Service.Controllers
{
    [ApiController]
    public class ProductCatalog : ControllerBase
    {
        [HttpGet]
        [Route("products/{id}")]
        public ActionResult GetProductByID(int id)
        {
            product product = Database.GetProduct(id);
            return Ok(product);
        }
    }
}
