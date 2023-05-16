using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace keyvault_demo_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SecretsController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        //get secret from keyvault
        [HttpGet]
        public List<string> Get()
        {
            List<string> result = new List<string>() {
                _configuration["SECRETNAME"]
            };
            return result;
        }
    }
}
