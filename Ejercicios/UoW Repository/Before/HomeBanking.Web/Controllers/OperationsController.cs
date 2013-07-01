namespace HomeBanking.Web.Controllers
{
    using System.Web.Mvc;

    using HomeBanking.Web.Commands;
    using HomeBanking.Web.DataAccess;
    using HomeBanking.Web.DataAccess.Repositories;
    using HomeBanking.Web.Models;
    using HomeBanking.Web.Models.Exceptions;

    public class OperationsController : Controller
    {
        private AccountRepository accountRepository = new AccountRepository();

        public ActionResult TransferMoney()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult TransferMoney(TransferMoneyCommand transferMoney)
        {
            var fromAccountBalance = this.accountRepository.GetBalance(transferMoney.FromAccountId);
            var toAccountBalance = this.accountRepository.GetBalance(transferMoney.ToAccountId);
            
            if (fromAccountBalance < transferMoney.Amount)
                throw new InsufficientFundsException();

            this.accountRepository.UpdateBalance(transferMoney.FromAccountId,fromAccountBalance - transferMoney.Amount);
            this.accountRepository.UpdateBalance(transferMoney.ToAccountId, toAccountBalance + transferMoney.Amount);
            
            return this.RedirectToAction("TransferMoney");
        }
    }
}
