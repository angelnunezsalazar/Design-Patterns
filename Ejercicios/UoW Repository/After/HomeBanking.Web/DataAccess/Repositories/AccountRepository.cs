namespace HomeBanking.Web.DataAccess.Repositories
{
    using System.Linq;

    using HomeBanking.Web.Models;

    public class AccountRepository
    {
        public decimal GetBalance(int accountId)
        {
            var context = new AppDbContext();
            return context.Accounts.Where(x => x.Id == accountId)
                          .Select(x => x.CurrentBalance).Single();
        }

        public void UpdateBalance(int accountId, decimal newBalance)
        {
            var account = new Account
            {
                Id = accountId,
                CurrentBalance = newBalance
            };
            var context = new AppDbContext();
            context.Accounts.Attach(account);
            context.Entry(account).Property(u => u.CurrentBalance).IsModified = true;
            context.SaveChanges();
        }
    }
}