﻿using Microsoft.AspNetCore.Mvc;
using PaymentApiDotnet.Entities.DataTransferObjects;
using PaymentApiDotnet.Services.Contracts;

namespace PaymentApiDotnet.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
            return StatusCode(201, _paymentService.ProcessPayment(paymentRequestDto));
        }
    }
}