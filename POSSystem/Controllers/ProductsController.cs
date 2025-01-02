using Microsoft.AspNetCore.Mvc;

namespace POSSystem.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
