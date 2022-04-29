using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IConfiguration configuration;

        public ValuesController(IConfiguration config)
        {
            this.configuration = config;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            string dbConn = configuration.GetSection("MySettings").GetSection("DbConnection").Value;

            var list = new List<string>();
            list.Add("John");
            list.Add("Doe");
            return Ok(list);
        }
    }

}

