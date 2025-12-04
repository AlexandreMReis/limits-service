using Limits.Service.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Limits.Service.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ILogger<TransactionsController> _logger;

        public TransactionsController(ILogger<TransactionsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAll")]
        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("Get/{transactionId}")]
        public IActionResult Get(int transactionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost(Name = "Validate")]
        public IActionResult InsertLimit(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
