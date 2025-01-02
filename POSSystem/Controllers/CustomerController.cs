using Microsoft.AspNetCore.Mvc;
using POSSystem.Models.Customer_Management;
using POSSystem.Services;

namespace POSSystem.Controllers
{
    public class CUSTOMERController : Controller
    {
        private readonly ICustomerServices _CustomerServices;

        public CUSTOMERController(ICustomerServices customerServices)
        {
            _CustomerServices = customerServices;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _CustomerServices.GetAllCustomersAsync();
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> Create(Customer customer)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _CustomerServices.AddCustomerAsync(customer);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(customer);
        //}
        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _CustomerServices.AddCustomerAsync(customer);
                    return RedirectToAction(nameof(Index));
                }

                // Log validation errors if ModelState is invalid
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                foreach (var error in errors)
                {
                    Console.WriteLine($"Validation Error: {error}");
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Exception occurred: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                // Optionally, add a model error to display a user-friendly message
                ModelState.AddModelError(string.Empty, "An error occurred while creating the customer. Please try again.");
            }

            // If we reach here, either ModelState is invalid or an exception occurred
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

        public async Task<IActionResult> Delete(Guid id)
        {
            var customer = await _CustomerServices.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _CustomerServices.DeleteCustomerAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
