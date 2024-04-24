using PaymentApiDotnet.Entities.DataTransferObjects;
using PaymentApiDotnet.Entities.Models;


namespace PaymentApiDotnet.Services.Contracts
{
    public interface IPaymentTransactionService
    {
        void CreatePaymentTransactionFromPaymentRequest(PaymentRequestDto paymentRequestDto, Bin binInfo, bool paymentStatus);
        public IEnumerable<PaymentTransactionDto> GetTransactionsByBankCode(int bankCode);
    }
}
