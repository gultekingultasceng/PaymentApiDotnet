using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Entities.Models;

namespace PaymentApiDotnet.Services.BankServices.Base
{
    public abstract class BankServiceBase : IBankServiceBase
    {
        protected readonly PaymentTransactionService _transactionService;
        public BankServiceBase(PaymentTransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        public virtual PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto, Bin binInfo)
        {
            PaymentInfo paymentInfo = new PaymentInfo(paymentRequestDto.Amount, paymentRequestDto.OrderId);            PaymentResponseDto paymentResponseDto = new PaymentResponseDto(paymentInfo);
            _transactionService.CreatePaymentTransactionFromPaymentRequest(paymentRequestDto, binInfo, paymentResponseDto.PaymentStatus);
            AfterPayment();
            return paymentResponseDto;
        }
        public abstract void AfterPayment();

  

     
    }
}
