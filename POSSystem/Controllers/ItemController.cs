using Microsoft.AspNetCore.Mvc;
using POSSystem.Models.Item_Management;
using POSSystem.Services;

namespace POSSystem.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemServices _itemServices;

        public ItemController(IItemServices ItemServices)
        {
            _itemServices = ItemServices;
        }

        public async Task<IActionResult> Index()
        {
            var Items = await _itemServices.GetAllItemAsync();
            return View(Items);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Item Item)
        {
            if (ModelState.IsValid)
            {
                await _itemServices.AddItemAsync(Item);
                return RedirectToAction(nameof(Index));
            }
            return View(Item);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var Itemdetails = await _itemServices.GetItemByIdAsync(id);
            if (Itemdetails != null)
            {
                return View(Itemdetails);
            }
            return View();
        }

        public async Task<IActionResult> Update(Guid id)
        {
            var Item = await _itemServices.GetItemByIdAsync(id);
            if (Item == null)
            {
                return NotFound();
            }
            return View(Item);
        }


        [HttpPost]
        public async Task<IActionResult> Update(Item Item)
        {
            if (ModelState.IsValid)
            {
                await _itemServices.UpdateItemAsync(Item);
                return RedirectToAction(nameof(Index));
            }
            return View(Item);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Item = await _itemServices.GetItemByIdAsync(id);
            if (Item != null)
            {
                await _itemServices.DeleteItemAsync(id);
                return View(Item);
            }
            return NotFound();
        }
    }
}
