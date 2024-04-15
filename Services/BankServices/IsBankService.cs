using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Models;
using PaymentApiDotnet.Services.BankServices.Base;

namespace PaymentApiDotnet.Services.BankServices
{
    public class IsBankService : IBankService
    {
        private readonly PaymentTransactionService _transactionService;
        public IsBankService(PaymentTransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        public PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto , Bin binInfo)
        {
            PaymentInfo paymentInfo = new PaymentInfo(paymentRequestDto.Amount, paymentRequestDto.OrderId);
            CreditCard creditCard = new CreditCard(paymentRequestDto.CardNumber, paymentRequestDto.Name, paymentRequestDto.Surname, paymentRequestDto.ExpDate, paymentRequestDto.Cvc);
            PaymentResponseDto paymentResponseDto = new PaymentResponseDto(paymentInfo);
            _transactionService.CreatePaymentTransactionFromPaymentRequest(paymentRequestDto, binInfo, paymentResponseDto.PaymentStatus);
            return paymentResponseDto;
        }
    }
}
