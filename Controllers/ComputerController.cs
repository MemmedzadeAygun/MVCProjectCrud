
using ComuterStoreProject.Entities;
using ComuterStoreProject.Repositories;
using ComuterStoreProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComuterStoreProject.Controllers
{
    public class ComputerController : Controller
    {
        private readonly IComputerRepository _computerRepository;
        public ComputerController(IComputerRepository computerRepository)
        {
            _computerRepository = computerRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var details = await _computerRepository.GetAllDetails();

            ViewBag.Details = new SelectList(details, "Id", "Price");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ComputerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _computerRepository.AddAsync(model);

            return RedirectToAction("Index", "Computer");
        }
    }
}
