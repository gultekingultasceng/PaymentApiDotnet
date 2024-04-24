using System.ComponentModel.DataAnnotations;

namespace PaymentApiDotnet.Entities.DataTransferObjects
{
    public class PaymentRequestDto
    {
        [Required(ErrorMessage = "Name can not be empty")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Surname can not be empty")]
        public string Surname { get; set; } = string.Empty;

        [Required]
        public double Amount { get; set; }

        [Required]
        public long OrderId { get; set; }

        [Required(ErrorMessage = "Invalid Card Number")]
        [CreditCard]
        public string CardNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Invalid Exp. Date")]
        public string ExpDate { get; set; } = string.Empty;
        [Required(ErrorMessage = "Invalid CVC")]
        [StringLength(3)]
        public string Cvc { get; set; } = string.Empty;
    }
}
