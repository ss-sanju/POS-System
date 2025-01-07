using Microsoft.AspNetCore.Mvc;
using POSSystem.Models.Customer_Management;
using POSSystem.Services;

namespace POSSystem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _CustomerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            _CustomerServices = customerServices;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _CustomerServices.GetAllCustomerAsync();
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.CreatedOnUtc = DateTime.Now;
                await _CustomerServices.AddCustomerAsync(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
      
        public async Task<IActionResult> Details(Guid id)
        {
            var customerdetails = await _CustomerServices.GetCustomerByIdAsync(id);
            if (customerdetails != null)
            {
                return View(customerdetails);
            }
            return View();
        }

        public async Task<IActionResult> Update(Guid id)
        {
            var customer = await _CustomerServices.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }


            [HttpPost]
        public async Task<IActionResult> Update(Customer customer)
        {
            if (ModelState.IsValid)
            {
                await _CustomerServices.UpdateCustomerAsync(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var customer = await _CustomerServices.GetCustomerByIdAsync(id);
            if (customer != null)
            {
                await _CustomerServices.DeleteCustomerAsync(id);
                return View(customer);
            }
            return NotFound();

        }


    }
}
