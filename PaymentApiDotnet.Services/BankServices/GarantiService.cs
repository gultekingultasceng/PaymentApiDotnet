
using PaymentApiDotnet.Services.BankServices.Base;
using PaymentApiDotnet.Services.PaymentServices;

namespace PaymentApiDotnet.Services.BankServices
{
    public class GarantiService : BankServiceBase
    {
        public GarantiService(PaymentTransactionService transactionService) : base(transactionService)
        {

        }
        public override void AfterPayment()
        {
            // GARANTI
        }
    }
}
