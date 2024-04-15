using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Services.BankServices.Base;

namespace PaymentApiDotnet.Services.BankServices
{
    public class DiscoverService : IBankService
    {
        private readonly PaymentTransactionService _transactionService;
        public DiscoverService(PaymentTransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        public PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto)
        {
            PaymentInfo paymentInfo = new PaymentInfo(paymentRequestDto.Amount, paymentRequestDto.OrderId);
            CreditCard creditCard = new CreditCard(paymentRequestDto.CardNumber, paymentRequestDto.Name, paymentRequestDto.Surname, paymentRequestDto.ExpDate, paymentRequestDto.Cvc);
            PaymentResponseDto paymentResponseDto = new PaymentResponseDto(paymentInfo);
            _transactionService.CreatePaymentTransactionFromPaymentRequest(paymentRequestDto, paymentResponseDto.PaymentStatus);
            return paymentResponseDto;
        }
    }
}
