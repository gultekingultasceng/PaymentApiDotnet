using PaymentApiDotnet.Services.Contracts;

namespace PaymentApiDotnet.Services.Factory
{
    public interface IBankFactory
    {
        IBankServiceBase? GetBankServiceByPaymentType(string bankName);
    }
}
