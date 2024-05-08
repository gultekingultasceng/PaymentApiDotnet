using AutoMapper;
using PaymentApiDotnet.Services.Factory;
using PaymentApiDotnet.Repositories.Contracts;
using PaymentApiDotnet.Services.BankServices;
using PaymentApiDotnet.Services.BinServices;
using PaymentApiDotnet.Services.Contracts;
using PaymentApiDotnet.Services.MessageQueue.Rabbitmq;
using PaymentApiDotnet.Services.PaymentServices;
using PaymentApiDotnet.Services.Logger;


namespace PaymentApiDotnet.Services.Base
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IPaymentService> _paymentService;
        private readonly Lazy<IPaymentTransactionService> _paymentTransactionService;
        private readonly Lazy<IBinService> _binService;
        private readonly Lazy<IBankFactory> _bankFactory;
        private readonly Lazy<ILoggerService> _loggerService;
        public ServiceManager(IRepositoryManager repositoryManager,IProducerService producerService,IMapper mapper , ILoggerService loggerService)
        {
            _paymentTransactionService = new Lazy<IPaymentTransactionService>(() => new PaymentTransactionService(repositoryManager, mapper));
            
            _bankFactory = new Lazy<IBankFactory>(() => new BankFactory(
                new ZiraatService(_paymentTransactionService.Value), 
                new AkbankService(_paymentTransactionService.Value),
                new SekerbankService(_paymentTransactionService.Value),
                new TEBService(_paymentTransactionService.Value),
                new GarantiService(_paymentTransactionService.Value),
                new VakıfBankService(_paymentTransactionService.Value),
                new HalkBankService(_paymentTransactionService.Value),
                new IsBankService(_paymentTransactionService.Value)
                 ));
            _loggerService = new Lazy<ILoggerService>(()=> new LoggerManager());
            _paymentService = new Lazy<IPaymentService>(() => new PaymentService(this , _bankFactory.Value, producerService , _loggerService.Value));
            _binService = new Lazy<IBinService>(() => new BinService(repositoryManager));
        }
        public IPaymentService PaymentService => _paymentService.Value;

        public IPaymentTransactionService PaymentTransactionService => _paymentTransactionService.Value;

        public IBinService BinService => _binService.Value;

        public IBankFactory BankFactory => _bankFactory.Value;

        public ILoggerService LoggerService => _loggerService.Value;
    }
}
