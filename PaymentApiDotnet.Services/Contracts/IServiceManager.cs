using PaymentApiDotnet.Services.Factory;
using PaymentApiDotnet.Services.Logger;
using PaymentApiDotnet.Services.MessageQueue.Rabbitmq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Services.Contracts
{
    public interface IServiceManager
    {
        IPaymentService PaymentService { get; }
        IPaymentTransactionService PaymentTransactionService { get; }
        IBinService BinService { get; } 
        IBankFactory BankFactory { get; }
        ILoggerService LoggerService { get; }
    }
}
