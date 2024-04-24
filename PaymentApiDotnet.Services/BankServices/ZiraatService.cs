
using PaymentApiDotnet.Services.BankServices.Base;
using PaymentApiDotnet.Services.PaymentServices;

namespace PaymentApiDotnet.Services.BankServices
{
    public class ZiraatService : BankServiceBase
    {
        public ZiraatService(PaymentTransactionService transactionService) : base(transactionService)
        {

        }
        public override void AfterPayment()
        {

        }
    }
}
