namespace HomeBanking.Web.Controllers
{
    using System.ComponentModel;
    using System.Web.Mvc;

    using HomeBanking.Web.Commands;
    using HomeBanking.Web.DataAccess;

    public class CustomerController : Controller
    {
        public ActionResult UpdateEmail([DefaultValue(1)]int customerId)
        {
            var context = new AppDbContext();
            var customer = context.Customers.Find(customerId);
            return View(customer);
        }

        [HttpPost]
        public ActionResult UpdateEmail(UpdateEmailCommand updateInformationCommand)
        {
            if (!ModelState.IsValid) 
                return this.View();

            var context = new AppDbContext();
            var customerToUpdate = context.Customers.Find(updateInformationCommand.CustomerId);
            customerToUpdate.Email = updateInformationCommand.Email;
            context.SaveChanges();
            return RedirectToAction("UpdateEmail");
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
            if (!ModelState.IsValid)
                return this.View();

            var context = new AppDbContext();
            var customerToUpdate = context.Customers.Find(updateAddressCommand.CustomerId);
            customerToUpdate.Email = updateAddressCommand.Address;
            context.SaveChanges();
            return RedirectToAction("UpdateAddress");
        }
    }
}