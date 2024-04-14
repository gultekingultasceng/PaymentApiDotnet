using PaymentApiDotnet.Enums;
using PaymentApiDotnet.Services.BankServices;
using PaymentApiDotnet.Services.BankServices.Base;
using System.Reflection.PortableExecutable;
using static PaymentApiDotnet.Enums.PaymentTypes;

namespace PaymentApiDotnet.Factory
{
    public class BankFactory : IBankFactory
    {
        private Dictionary<PaymentType, IBankService> _bankServiceByPaymentType;

        public BankFactory(AmexService amexService ,DinersClubService dinersClubService, DiscoverService discoverService , EnrouteService enrouteService, JcbService jcbService, MastercardService mastercardService, VisaService visaService)
        {
            _bankServiceByPaymentType = new()
        {
            { PaymentType.Amex, amexService },
            { PaymentType.DinersClub, dinersClubService },
            { PaymentType.Discover, discoverService },
            { PaymentType.enRoute, enrouteService },
            { PaymentType.JCB, jcbService },
            { PaymentType.MasterCard, mastercardService },
            { PaymentType.VISA,visaService },
        };
        }
        public IBankService GetBankServiceByPaymentType(PaymentType paymentType)
        {
            return _bankServiceByPaymentType[paymentType];
        }
    }
}
