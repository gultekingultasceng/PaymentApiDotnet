using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;

namespace PaymentApiDotnet.Services.Base
{
    public interface IPaymentService
    {
        PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto);
    }
}
