namespace HomeBanking.Web.Controllers
{
    using System;
    using System.ComponentModel;
    using System.Web.Mvc;

    using HomeBanking.Web.Commands;
    using HomeBanking.Web.DataAccess;

    using StructureMap;

    public class CustomerController : BaseController
    {
        public ActionResult UpdateEmail([DefaultValue(1)]int customerId)
        {
            var context = new AppDbContext();
            var customer = context.Customers.Find(customerId);
            return View(customer);
        }

        [HttpPost]
        public ActionResult UpdateEmail(UpdateEmailCommand updateEmailCommand)
        {
            return this.ExecuteCommand(updateEmailCommand, () => this.RedirectToAction("UpdateEmail"));
        }

        public ActionResult UpdateAddress([DefaultValue(1)]int customerId)
        {
            var context = new AppDbContext();
            var customer = context.Customers.Find(customerId);
            return View(customer);
        }

        [HttpPost]
        public ActionResult UpdateAddress(UpdateAddressCommand updateAddressCommand)
        {
            return this.ExecuteCommand(updateAddressCommand, () => this.RedirectToAction("UpdateAddress"));
        }

    }

    public class BaseController : Controller
    {
        public ActionResult ExecuteCommand(ICommand command, Func<ActionResult> whenBusinessLogicIsOk)
        {
            if (ModelState.IsValid)
                return this.View();
            try
            {
                var handlerType = typeof(IHandler<>).MakeGenericType(command.GetType());
                dynamic handler = ObjectFactory.GetInstance(handlerType);
                handler.Execute(command);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return whenBusinessLogicIsOk();
            }

            return whenBusinessLogicIsOk();
        }
    }

    public interface IHandler<TCommand> where TCommand : ICommand
    {
        void Execute(TCommand command);
    }

    public class UpdateAddressHandler : IHandler<UpdateAddressCommand>
    {
        public void Execute(UpdateAddressCommand command)
        {
            var context = new AppDbContext();
            var customerToUpdate = context.Customers.Find(command.CustomerId);
            customerToUpdate.Address = command.Address;
            context.SaveChanges();
        }
    }

    public class UpdateMailHandler : IHandler<UpdateEmailCommand>
    {
        public void Execute(UpdateEmailCommand command)
        {
            var context = new AppDbContext();
            var customerToUpdate = context.Customers.Find(command.CustomerId);
            customerToUpdate.Email = command.Email;
            context.SaveChanges();
        }
    }
}