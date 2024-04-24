
using PaymentApiDotnet.Services.BankServices.Base;
using PaymentApiDotnet.Services.Contracts;
using PaymentApiDotnet.Services.PaymentServices;

namespace PaymentApiDotnet.Services.BankServices
{
    public class IsBankService : BankServiceBase
    {
        public IsBankService(IPaymentTransactionService paymentTransactionService) : base(paymentTransactionService)
        {
        }

        public override void AfterPayment()
        {

        }
    }
}
