
using PaymentApiDotnet.Services.BankServices.Base;
using PaymentApiDotnet.Services.PaymentServices;

namespace PaymentApiDotnet.Services.BankServices
{
    public class HalkBankService : BankServiceBase
    {
        public HalkBankService(PaymentTransactionService transactionService) : base(transactionService)
        {

        }
        public override void AfterPayment()
        {

        }
    }
}
