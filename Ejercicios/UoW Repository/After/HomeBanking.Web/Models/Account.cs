namespace HomeBanking.Web.Models
{
    public class Account
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string Number { get; set; }

        public decimal CurrentBalance { get; set; }
    }
}