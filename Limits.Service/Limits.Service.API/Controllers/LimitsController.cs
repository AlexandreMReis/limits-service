using Limits.Service.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Limits.Service.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LimitsController : ControllerBase
    {
        private readonly ILogger<LimitsController> _logger;

        public LimitsController(ILogger<LimitsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAll")]
        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }


        [HttpGet("Get/{limitId}")]
        public IActionResult Get(int limitId)
        {
            throw new NotImplementedException();
        }

        [HttpPost(Name = "Insert")]
        public IActionResult InsertLimit(Limit limit)
        {
            throw new NotImplementedException();
        }
    }
}
