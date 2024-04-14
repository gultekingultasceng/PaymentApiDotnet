namespace PaymentApiDotnet.Models
{
    public class PaymentInfo
    {
        public double Amount { get; set; }
        public long OrderId { get; set; }

        public PaymentInfo(double amount, long orderId) 
        {
            Amount = amount;
            OrderId = orderId;
        }

        public bool GetPaymentStatus() => GetRandomPaymentStatus();

        private  bool GetRandomPaymentStatus()
        {
            Random rnd = new Random();
            return  rnd.Next(2) == 0;

        }
    }
}
