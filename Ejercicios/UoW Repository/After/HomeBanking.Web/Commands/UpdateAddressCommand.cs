namespace HomeBanking.Web.Commands
{
    using System.ComponentModel.DataAnnotations;

    public class UpdateAddressCommand
    {
        public int CustomerId { get; set; }

        [Required]
        public string Address { get; set; }
    }
}