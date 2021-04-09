using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult ECommerceDashboard()
        {
            return View();
        }
        public IActionResult CreateApplication()
        {
            return View("../Cloud/CreateApplication");
        }
    }
}
