namespace PaymentApiDotnet.Dto
{
    using System.ComponentModel.DataAnnotations;

    public class PaymentRequestDto
    {
        [Required(ErrorMessage = "Name can not be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname can not be empty")]
        public string Surname { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public long OrderId { get; set; }

        [Required(ErrorMessage = "Invalid Card Number")]
        [CreditCard]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Invalid Exp. Date")]
        public string ExpDate { get; set; }
        [Required(ErrorMessage = "Invalid CVC")]
        [StringLength(3)]
        public string Cvc { get; set; }

       

    }
}
