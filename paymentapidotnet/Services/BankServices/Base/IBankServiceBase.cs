using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Entities.Models;

namespace PaymentApiDotnet.Services.BankServices.Base
{
    public interface IBankServiceBase
    {
         PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto , Bin binInfo);
    }
}
