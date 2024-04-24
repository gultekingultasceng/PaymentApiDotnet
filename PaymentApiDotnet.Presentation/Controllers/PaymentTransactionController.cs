using Microsoft.AspNetCore.Mvc;
using PaymentApiDotnet.Services.PaymentServices;


namespace PaymentApiDotnet.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTransactionController : ControllerBase
    {
        private readonly PaymentTransactionService _paymentTransactionService;
        public PaymentTransactionController(PaymentTransactionService paymentTransactionService)
        {
            _paymentTransactionService = paymentTransactionService;
        }
        [HttpGet("{bankCode:int}")]
        public IActionResult GetPaymentsByBankCode([FromRoute(Name = "bankCode")] int bankCode)
        {
            return StatusCode(200, _paymentTransactionService.GetTransactionsByBankCode(bankCode));
        }

        [HttpGet]
        public IActionResult GetTheBankWithMostSuccessfulPayment()
        {
            return StatusCode(200);
        }

    }
}
