namespace HomeBanking.Web.Controllers
{
    using System;
    using System.Web.Mvc;

    using HomeBanking.Web.Commands;
    using HomeBanking.Web.DataAccess;
    using HomeBanking.Web.DataAccess.Repositories;
    using HomeBanking.Web.Models;
    using HomeBanking.Web.Models.Exceptions;

    using StructureMap;

    public class OperationsController : Controller
    {
        private readonly AppDbContext appDbContext;

        private IAccountRepository accounts;

        private readonly ICustomerRepository customerRepository;

        public OperationsController(IAccountRepository accountRepository)
        {
            this.accounts = accountRepository;
            this.customerRepository = customerRepository;
        }

        public ActionResult TransferMoney()
        {
            return this.View();
        }

        [HttpPost]
        [Transactional]
        public ActionResult TransferMoney(TransferMoneyCommand transferMoney)
        {
            var fromAccount = accounts.Get(transferMoney.FromAccountId);
            var toAccount = accounts.Get(transferMoney.ToAccountId);

            if (fromAccount.CurrentBalance < transferMoney.Amount)
                throw new InsufficientFundsException();

            fromAccount.CurrentBalance = fromAccount.CurrentBalance - transferMoney.Amount;
            toAccount.CurrentBalance = toAccount.CurrentBalance + transferMoney.Amount;

            return this.RedirectToAction("TransferMoney");
        }
    }

    public class TransactionalAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var appDbContext = ObjectFactory.GetInstance<AppDbContext>();
            appDbContext.SaveChanges();
        }
    }

    public interface ICustomerRepository
    {
    }


}
