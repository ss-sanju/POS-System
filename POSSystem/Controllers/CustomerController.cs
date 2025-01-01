using Microsoft.AspNetCore.Mvc;
using POSSystem.Models.Customer_Management;
using POSSystem.Services;

namespace POSSystem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _CustomerServices;
        public CustomerController(ICustomerServices CustomerServices)
        {
            _CustomerServices = CustomerServices;
        }
        public async Task<IActionResult> Index()
        {
            var Customers=await _CustomerServices.GetAllCustomersAsync();
            return View(Customers);
        }

        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Details(Guid id)
        {
            var Customerdetail = await _CustomerServices.GetCustomerByIdAsync(id);
            if (Customerdetail != null)
            {
                return View(Customerdetail);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer Customer)
        {
            if (ModelState.IsValid)
            {
                await _CustomerServices.AddCustomerAsync(Customer);
                return RedirectToAction(nameof(Index));
            }
            return View(Customer);
        }

        public async Task<IActionResult> Update(Guid id)
        {
            var Customer = await _CustomerServices.GetCustomerByIdAsync(id);
            if (Customer == null)
            {
                return NotFound();
            }
            return View(Customer);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Customer Customer)
        {
            if (ModelState.IsValid)
            {
                await _CustomerServices.UpdateCustomerAsync(Customer);
                return RedirectToAction(nameof(Index));
            }
            return View(Customer);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var Customer = await _CustomerServices.GetCustomerByIdAsync(id);
            if (Customer == null)
            {
                return NotFound();
            }
            return View(Customer);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _CustomerServices.DeleteCustomerAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
