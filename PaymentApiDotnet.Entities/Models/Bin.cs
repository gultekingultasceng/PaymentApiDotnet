using System.ComponentModel.DataAnnotations;


namespace PaymentApiDotnet.Entities.Models
{
    public class Bin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BinNumber { get; set; }
        [Required]
        public int BankCode { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string CardType { get; set; }
        [Required]
        public string CardSubType { get; set; }
        [Required]
        public string Virtual { get; set; }
        [Required]
        public string Prepaid { get; set; }
    }
}
