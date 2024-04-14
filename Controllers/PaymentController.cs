using Microsoft.AspNetCore.Mvc;
using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Services.Base;

namespace PaymentApiDotnet.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {

        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost(Name = "Pay")]
        public IActionResult MakePayment([FromBody] PaymentRequestDto paymentRequestDto)
        {
            return StatusCode(201,_paymentService.ProcessPayment(paymentRequestDto));
        }
    }
}
