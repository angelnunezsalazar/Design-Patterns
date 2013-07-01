namespace HomeBanking.Web.DataAccess
{
    using System.Data.Entity;

    using HomeBanking.Web.Models;

    public class DataInitializer : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            var customer = new Customer
                {
                    FullName = "Julio Loayza",
                    Email = "jloayza@gmail.com",
                    Address = "Ca. Los Tulipanes 456"
                };

            customer.Accounts.Add(new Account
                {
                    Number = "1234-1234-1234-1234",
                    CurrentBalance = 1000
                });
            customer.Accounts.Add(new Account
            {
                Number = "5678-5678-5678-5678",
                CurrentBalance = 1000
            });
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}