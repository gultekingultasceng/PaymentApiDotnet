using PaymentApiDotnet.Services.BankServices;
using PaymentApiDotnet.Services.Contracts;

namespace PaymentApiDotnet.Services.Factory
{
    public class BankFactory : IBankFactory
    {
        private Dictionary<string, IBankServiceBase> _bankServiceByPaymentType;

        public BankFactory(ZiraatService ziraatService ,AkbankService akbankService,
            SekerbankService sekerbankService , TEBService tebService,
            GarantiService garantiService, VakıfBankService vakıfBankService,
            HalkBankService halkBankService , IsBankService isbankService)
        {
            _bankServiceByPaymentType = new()
        {
            { "T.C. ZİRAAT BANKASI A.Ş.", ziraatService },
            { "AKBANK T.A.Ş.", akbankService },
            { "ŞEKERBANK T.A.Ş.", sekerbankService },
            { "TÜRK EKONOMİ BANKASI A.Ş.", tebService },
            { "T. GARANTİ BANKASI A.Ş.", garantiService },
            { "T. VAKIFLAR BANKASI T.A.O.", vakıfBankService },
            { "T. HALK BANKASI A.Ş.",halkBankService },
            { "T. İŞ BANKASI A.Ş.",isbankService }
        };
        }
        public IBankServiceBase GetBankServiceByPaymentType(string bankName)
        {
            return _bankServiceByPaymentType[bankName];
        }
    }
}
