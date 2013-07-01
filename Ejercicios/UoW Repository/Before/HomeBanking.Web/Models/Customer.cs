namespace HomeBanking.Web.Models
{
    using System.Collections.Generic;

    public class Customer
    {
        public Customer()
        {
            this.Accounts = new List<Account>();
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public List<Account> Accounts { get; set; }
    }
}