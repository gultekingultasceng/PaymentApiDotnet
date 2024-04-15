using PaymentApiDotnet.Models;
using System.Threading.Tasks;
namespace PaymentApiDotnet.Repository
{
    public interface IPaymentRepository
    {
        void AddTransaction(PaymentTransaction payment);
        Bin GetBankInfosByCardNumber(string cardNumber);
    }
}
