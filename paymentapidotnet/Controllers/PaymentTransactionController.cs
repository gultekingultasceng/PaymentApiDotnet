using Microsoft.AspNetCore.Mvc;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.Repository;
using PaymentApiDotnet.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentApiDotnet.Controllers
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
        public IActionResult GetPaymentsByBankCode([FromRoute(Name ="bankCode")]int bankCode)
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
