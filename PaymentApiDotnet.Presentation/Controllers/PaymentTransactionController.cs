using Microsoft.AspNetCore.Mvc;
using PaymentApiDotnet.Services.Contracts;
using PaymentApiDotnet.Services.PaymentServices;


namespace PaymentApiDotnet.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTransactionController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public PaymentTransactionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet("{bankCode:int}")]
        public IActionResult GetPaymentsByBankCode([FromRoute(Name = "bankCode")] int bankCode)
        {
            return StatusCode(200, _serviceManager.PaymentTransactionService.GetTransactionsByBankCode(bankCode));
        }

        [HttpGet]
        public IActionResult GetTheBankWithMostSuccessfulPayment()
        {
            return StatusCode(200);
        }

    }
}
