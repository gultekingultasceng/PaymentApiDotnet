using Microsoft.AspNetCore.Mvc;
using PaymentApiDotnet.Entities.DataTransferObjects;
using PaymentApiDotnet.Services.Contracts;

namespace PaymentApiDotnet.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public PaymentController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost(Name = "Pay")]
        public IActionResult MakePayment([FromBody] PaymentRequestDto paymentRequestDto)
        {
            return StatusCode(201, _serviceManager.PaymentService.ProcessPayment(paymentRequestDto));
        }
    }
}
