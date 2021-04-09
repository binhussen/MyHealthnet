using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.IService;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TestMetohd()
        {
            return View();
        }
    }
}
