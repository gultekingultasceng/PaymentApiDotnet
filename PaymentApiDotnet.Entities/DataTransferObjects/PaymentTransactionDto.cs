namespace PaymentApiDotnet.Entities.DataTransferObjects
{
    public class PaymentTransactionDto
    {
        public double Amount { get; set; }
        public long OrderId { get; set; }
        public bool PaymentStatus { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string SurName { get; set; } = string.Empty;
        public string ExpDate { get; set; } = string.Empty;
        public string Cvc { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public string CardType { get; set; } = string.Empty;
        public int BankCode { get; set; }
    }
}
