
using PaymentApiDotnet.Services.BankServices.Base;
using PaymentApiDotnet.Services.PaymentServices;

namespace PaymentApiDotnet.Services.BankServices
{
    public class IsBankService : BankServiceBase
    {
        public IsBankService(PaymentTransactionService transactionService) : base(transactionService)
        {

        }
        public override void AfterPayment()
        {

        }
    }
}
