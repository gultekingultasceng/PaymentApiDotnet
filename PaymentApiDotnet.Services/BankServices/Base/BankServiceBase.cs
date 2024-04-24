using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.Services.Contracts;
using PaymentApiDotnet.Entities.DataTransferObjects;
using PaymentApiDotnet.Services.PaymentServices;

namespace PaymentApiDotnet.Services.BankServices.Base
{
    public abstract class BankServiceBase : IBankServiceBase
    {
        protected readonly IPaymentTransactionService _paymentTransactionService;
        public BankServiceBase(IPaymentTransactionService paymentTransactionService)
        {
            _paymentTransactionService = paymentTransactionService;
        }
        public virtual PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto, Bin binInfo)
        {
            PaymentInfo paymentInfo = new PaymentInfo(paymentRequestDto.Amount, paymentRequestDto.OrderId);
            PaymentResponseDto paymentResponseDto = new PaymentResponseDto(paymentInfo);
            _paymentTransactionService.CreatePaymentTransactionFromPaymentRequest(paymentRequestDto, binInfo, paymentResponseDto.PaymentStatus);
            AfterPayment();
            return paymentResponseDto;
        }
        public abstract void AfterPayment();
    }
}
