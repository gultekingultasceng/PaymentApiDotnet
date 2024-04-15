using System.ComponentModel.DataAnnotations;


namespace PaymentApiDotnet.Models
{
    public class PaymentTransaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public long OrderId { get; set; }
        [Required]
        public bool PaymentStatus { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string ExpDate { get; set; }
        [Required]
        public string Cvc { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string CardType { get; set; }

    }
}