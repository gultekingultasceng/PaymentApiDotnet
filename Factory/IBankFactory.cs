using PaymentApiDotnet.Enums;
using PaymentApiDotnet.Services.BankServices.Base;
using System.Reflection.PortableExecutable;
using static PaymentApiDotnet.Enums.PaymentTypes;

namespace PaymentApiDotnet.Factory
{
    public interface IBankFactory
    {
        IBankService GetBankServiceByPaymentType(PaymentType paymentType);
    }
}
