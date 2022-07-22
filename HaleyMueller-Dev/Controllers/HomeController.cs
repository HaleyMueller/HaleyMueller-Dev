using HaleyMueller_Dev.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HaleyMueller_Dev.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        //TODO: Make sure all of these sites are able to log into MDO
        //Make sure all projects is updated on repo

        public IActionResult LoadProjectList(int id)
        {
            var model = ProjectList.GetProjects();

            switch (id)
            {
                case 1:
                    model = model.OrderBy(x => x.Significance).ToList();
                    break;
                case 2:
                    model = model.OrderByDescending(x => x.LastUpdated).ToList();
                    break;
                case 3:
                    model = model.OrderBy(x => x.LastUpdated).ToList();
                    break;
            }

            return PartialView("_Project", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}