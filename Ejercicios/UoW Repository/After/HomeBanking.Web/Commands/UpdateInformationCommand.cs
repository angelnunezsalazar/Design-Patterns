namespace HomeBanking.Web.Commands
{
    using System.ComponentModel.DataAnnotations;

    public class UpdateEmailCommand : ICommand
    {
        public int CustomerId { get; set; }

        [Required]
        public string Email { get; set; }
    }

    public interface ICommand
    {

    }
}