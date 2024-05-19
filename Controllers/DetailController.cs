using ComuterStoreProject.Repositories;
using ComuterStoreProject.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ComuterStoreProject.Controllers
{
    public class DetailController : Controller
    {
        private readonly ICompDetailRepository _compDetailRepository ;
        public DetailController(ICompDetailRepository compDetailRepository)
        {
            _compDetailRepository = compDetailRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(DetailViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            await _compDetailRepository.AddAsync(model);

            return RedirectToAction("Index", "Detail");
        }
    }
}
