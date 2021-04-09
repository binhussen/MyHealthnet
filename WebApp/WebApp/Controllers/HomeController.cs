
using System.Threading.Tasks;
using BusinessLogic.IService;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private IHomeService _homeService;
        private IAdminService _adminService;
        //ApplicationDbContext _context;

        public HomeController(IHomeService homeService, IAdminService adminService)
        {
            _homeService = homeService;
            _adminService = adminService;
            //    _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //var client = await _context.Content.FirstOrDefaultAsync();
            var result = _homeService.CallApiMethodAsync();
            var contentResult = await _adminService.GetContent();
            return View();

            //return PartialView("_Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
