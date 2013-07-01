namespace HomeBanking.Web.DataAccess
{
    using System.Data.Entity;

    using HomeBanking.Web.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection") { }

        public IDbSet<Customer> Customers { get; set; }

        public IDbSet<Account> Accounts { get; set; }
    }
}