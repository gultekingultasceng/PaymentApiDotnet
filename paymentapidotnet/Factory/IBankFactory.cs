using PaymentApiDotnet.Services.BankServices.Base;
using System.Reflection.PortableExecutable;

namespace PaymentApiDotnet.Factory
{
    public interface IBankFactory
    {
        IBankServiceBase GetBankServiceByPaymentType(string bankName);
    }
}
