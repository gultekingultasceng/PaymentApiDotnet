
using PaymentApiDotnet.Services.BankServices.Base;
using PaymentApiDotnet.Services.PaymentServices;

namespace PaymentApiDotnet.Services.BankServices
{
    public class SekerbankService : BankServiceBase
    {
        public SekerbankService(PaymentTransactionService transactionService) : base(transactionService)
        {

        }
        public override void AfterPayment()
        {

        }
    }
}
