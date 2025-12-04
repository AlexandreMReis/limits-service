using Limits.Service.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Limits.Service.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAll")]
        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("Get/{customerId}")]
        public IActionResult Get(int customerId)
        {
            throw new NotImplementedException();
        }

        [HttpPost(Name = "Insert")]
        public IActionResult InsertLimit(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
