using PaymentApiDotnet.Entities.DataTransferObjects;
using PaymentApiDotnet.Entities.Models;

namespace PaymentApiDotnet.Services.Contracts
{
    public interface IBankServiceBase
    {
        PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto, Bin binInfo);
    }
}
