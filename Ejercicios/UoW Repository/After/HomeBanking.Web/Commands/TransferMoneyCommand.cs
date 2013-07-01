namespace HomeBanking.Web.Commands
{
    public class TransferMoneyCommand
    {
        public int CustomerId { get; set; }

        public int FromAccountId { get; set; }

        public int ToAccountId { get; set; }

        public decimal Amount { get; set; }
    }
}