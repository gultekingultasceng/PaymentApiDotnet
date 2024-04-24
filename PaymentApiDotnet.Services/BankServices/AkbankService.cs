
using PaymentApiDotnet.Services.BankServices.Base;
using PaymentApiDotnet.Services.PaymentServices;

namespace PaymentApiDotnet.Services.BankServices
{
    public class AkbankService : BankServiceBase
    {
        public AkbankService(PaymentTransactionService transactionService) : base(transactionService)
        {

        }

        public override void AfterPayment()
        {
           // AKBANK
        }
    }
}
