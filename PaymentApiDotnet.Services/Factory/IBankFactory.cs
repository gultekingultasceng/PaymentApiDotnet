using PaymentApiDotnet.Services.Contracts;

namespace PaymentApiDotnet.Factory
{
    public interface IBankFactory
    {
        IBankServiceBase GetBankServiceByPaymentType(string bankName);
    }
}
