using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                result = "Test"
            });
        }

        [HttpGet("test2")]
        public IActionResult Get2()
        {
            return Ok(new
            {
                result = "Test2"
            });
        }


        //[HttpGet("test2")]
        //public IActionResult Get3()
        //{
        //    return Ok(new
        //    {
        //        result = "Test3"
        //    });
        //}
    }
}
