namespace PaymentApiDotnet.Entities.Exceptions
{
    public sealed class PaymentTransactionNotFoundException : NotFoundException
    {
        public PaymentTransactionNotFoundException(int id) : base($"The payment with id : {id} could not found. ")
        {

        }
    }
}
