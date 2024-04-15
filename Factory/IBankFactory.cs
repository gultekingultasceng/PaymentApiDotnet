using PaymentApiDotnet.Services.BankServices.Base;
using System.Reflection.PortableExecutable;

namespace PaymentApiDotnet.Factory
{
    public interface IBankFactory
    {
        IBankService GetBankServiceByPaymentType(string bankName);
    }
}
