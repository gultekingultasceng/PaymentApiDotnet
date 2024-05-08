namespace PaymentApiDotnet.Entities.Exceptions
{
    public sealed class ReleatedBankServiceNotFoundException : NotFoundException
    {
        public ReleatedBankServiceNotFoundException(string bankName) : base($"The bank service named : {bankName} can not found.")
        {

        }
    }
}
