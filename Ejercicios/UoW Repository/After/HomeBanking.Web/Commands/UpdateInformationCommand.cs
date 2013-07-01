namespace HomeBanking.Web.Commands
{
    using System.ComponentModel.DataAnnotations;

    public class UpdateEmailCommand
    {
        public int CustomerId { get; set; }

        [Required]
        public string Email { get; set; }
    }
}