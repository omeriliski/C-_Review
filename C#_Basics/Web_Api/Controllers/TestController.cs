using Microsoft.AspNetCore.Mvc;

namespace Web_Api.Controllers
{
    [ApiController]
    [Route("api/mytestendpoint")]       // write hier the endpoint
    public class TestController: ControllerBase     // write hier the name of the controller
    {
        [HttpGet(Name = "GetTest")]
        public string Get()
        {
            return "lorem ipsum";
        }
    }
}
