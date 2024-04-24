using PaymentApiDotnet.Entities.DataTransferObjects;

namespace PaymentApiDotnet.Services.Contracts
{
    public interface IPaymentService
    {
        PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto);
    }
}
