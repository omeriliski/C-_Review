using C__Basics.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Web_Api.Controllers
{
    [ApiController]
    [Route("api/mytestendpoint")]       // write hier the endpoint
    public class TestController: ControllerBase     // write hier the name of the controller
    {
        [HttpGet(Name = "GetTest")]
        public ActionResult<IEnumerable<Product>> Get()
        {
            Product product1 = new Product(1, "TV", 1000);
            Product product2 = new Product(2, "Phone", 2000);
            Product product3 = new Product(3, "Computer", 3000);

            List<Product> products = new List<Product>() { product1, product2, product3 };
            //var productsJson = JsonConvert.SerializeObject(products);
            return Ok(products);
        }
    }
}
