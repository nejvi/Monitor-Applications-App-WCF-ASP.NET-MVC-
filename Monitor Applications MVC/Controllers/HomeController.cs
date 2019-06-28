using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Monitor_Applications_MVC.Models;
using MonitorApplicationsMVC.Adapters;
using MonitorApplicationsMVC.Models;

namespace Monitor_Applications_MVC.Controllers
{
    public class HomeController : Controller
    {
        ApplicationAdapter _adapter;
        ServiceReference2.Service1Client _appsService;

        public HomeController()
        {
            _adapter = new ApplicationAdapter();
            _appsService = new ServiceReference2.Service1Client();

        }

        public async Task<IActionResult> Index()
        {
            var wcfApplications = await _appsService.GetAllAplicationsAsync();
            List<Application> applications = _adapter.AdaptListOfApplications(wcfApplications);
            return View(applications);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
