using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;

namespace PaymentApiDotnet.Services.BankServices.Base
{
    public interface IBankService
    {
        PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto);
    }
}
